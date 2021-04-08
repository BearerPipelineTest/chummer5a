/*  This file is part of Chummer5a.
 *
 *  Chummer5a is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Chummer5a is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Chummer5a.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  You can obtain the full source code for Chummer5a at
 *  https://github.com/chummer5a/chummer5a
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Xml.XPath;

namespace Chummer
{
    public partial class frmSelectQuality : Form
    {
        private string _strSelectedQuality = string.Empty;
        private bool _blnAddAgain;
        private bool _blnLoading = true;
        private readonly Character _objCharacter;

        private readonly XPathNavigator _xmlBaseQualityDataNode;
        private readonly XPathNavigator _xmlMetatypeQualityRestrictionNode;

        private readonly List<ListItem> _lstCategory = new List<ListItem>();

        private static string s_StrSelectCategory = string.Empty;

        #region Control Events
        public frmSelectQuality(Character objCharacter)
        {
            InitializeComponent();
            this.UpdateLightDarkMode();
            this.TranslateWinForm();
            _objCharacter = objCharacter ?? throw new ArgumentNullException(nameof(objCharacter));

            // Load the Quality information.
            _xmlBaseQualityDataNode = _objCharacter.LoadDataXPath("qualities.xml").SelectSingleNode("/chummer");
            _xmlMetatypeQualityRestrictionNode = _objCharacter.GetNode().SelectSingleNode("qualityrestriction");
        }

        private void frmSelectQuality_Load(object sender, EventArgs e)
        {
            // Populate the Quality Category list.
            foreach (XPathNavigator objXmlCategory in _xmlBaseQualityDataNode.Select("categories/category"))
            {
                string strInnerText = objXmlCategory.Value;
                _lstCategory.Add(new ListItem(strInnerText, objXmlCategory.SelectSingleNode("@translate")?.Value ?? strInnerText));
            }

            if (_lstCategory.Count > 0)
            {
                _lstCategory.Insert(0, new ListItem("Show All", LanguageManager.GetString("String_ShowAll")));
            }

            cboCategory.BeginUpdate();
            cboCategory.ValueMember = nameof(ListItem.Value);
            cboCategory.DisplayMember = nameof(ListItem.Name);
            //this could help circumvent a exception like this?	"InvalidArgument=Value of '0' is not valid for 'SelectedIndex'. Parameter name: SelectedIndex"
            BindingList<ListItem> templist = new BindingList<ListItem>(_lstCategory);
            cboCategory.DataSource = templist;

            // Select the first Category in the list.
            if (string.IsNullOrEmpty(s_StrSelectCategory))
                cboCategory.SelectedIndex = 0;
            else
            {
                cboCategory.SelectedValue = s_StrSelectCategory;

                if (cboCategory.SelectedIndex == -1)
                    cboCategory.SelectedIndex = 0;
            }
            cboCategory.Enabled = _lstCategory.Count > 1;
            cboCategory.EndUpdate();

            if (_objCharacter.MetagenicLimit == 0)
                chkNotMetagenic.Checked = true;

            lblBPLabel.Text = LanguageManager.GetString("Label_Karma");
            _blnLoading = false;
            BuildQualityList();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildQualityList();
        }

        private void lstQualities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_blnLoading)
                return;

            string strSpace = LanguageManager.GetString("String_Space");
            XPathNavigator xmlQuality = null;
            string strSelectedQuality = lstQualities.SelectedValue?.ToString();
            if (!string.IsNullOrEmpty(strSelectedQuality))
            {
                xmlQuality = _xmlBaseQualityDataNode.SelectSingleNode("qualities/quality[id = " + strSelectedQuality.CleanXPath() + "]");
            }

            if (xmlQuality != null)
            {
                if (chkFree.Checked)
                    lblBP.Text = 0.ToString(GlobalOptions.CultureInfo);
                else
                {
                    string strKarma = xmlQuality.SelectSingleNode("karma")?.Value ?? string.Empty;
                    if (strKarma.StartsWith("Variable(", StringComparison.Ordinal))
                    {
                        int intMin;
                        int intMax = int.MaxValue;
                        string strCost = strKarma.TrimStartOnce("Variable(", true).TrimEndOnce(')');
                        if (strCost.Contains('-'))
                        {
                            string[] strValues = strCost.Split('-');
                            int.TryParse(strValues[0], NumberStyles.Any, GlobalOptions.InvariantCultureInfo, out intMin);
                            int.TryParse(strValues[1], NumberStyles.Any, GlobalOptions.InvariantCultureInfo, out intMax);
                        }
                        else
                            int.TryParse(strCost.FastEscape('+'), NumberStyles.Any, GlobalOptions.InvariantCultureInfo, out intMin);

                        lblBP.Text = intMax == int.MaxValue
                            ? intMin.ToString(GlobalOptions.CultureInfo)
                            : string.Format(GlobalOptions.CultureInfo, "{0}{1}-{1}{2}", intMin, strSpace, intMax);
                    }
                    else
                    {
                        int.TryParse(strKarma, NumberStyles.Any, GlobalOptions.InvariantCultureInfo, out int intBP);

                        if (xmlQuality.SelectSingleNode("costdiscount").RequirementsMet(_objCharacter) && !chkFree.Checked)
                        {
                            string strValue = xmlQuality.SelectSingleNode("costdiscount/value")?.Value;
                            switch (xmlQuality.SelectSingleNode("category")?.Value)
                            {
                                case "Positive":
                                    intBP += Convert.ToInt32(strValue, GlobalOptions.InvariantCultureInfo);
                                    break;
                                case "Negative":
                                    intBP -= Convert.ToInt32(strValue, GlobalOptions.InvariantCultureInfo);
                                    break;
                            }
                        }
                        if (_objCharacter.Created && !_objCharacter.Options.DontDoubleQualityPurchases)
                        {
                            string strDoubleCostCareer = xmlQuality.SelectSingleNode("doublecareer")?.Value;
                            if (string.IsNullOrEmpty(strDoubleCostCareer) || strDoubleCostCareer == bool.TrueString)
                            {
                                intBP *= 2;
                            }
                        }
                        lblBP.Text = (intBP * _objCharacter.Options.KarmaQuality).ToString(GlobalOptions.CultureInfo);
                        if (!_objCharacter.Created && _objCharacter.FreeSpells > 0 && Convert.ToBoolean(xmlQuality.SelectSingleNode("canbuywithspellpoints")?.Value, GlobalOptions.InvariantCultureInfo))
                        {
                            int i = (intBP * _objCharacter.Options.KarmaQuality);
                            int spellPoints = 0;
                            while (i > 0)
                            {
                                i -= 5;
                                spellPoints++;
                            }

                            lblBP.Text += string.Format(GlobalOptions.CultureInfo, "{0}/{0}{1}{0}{2}", LanguageManager.GetString("String_Space"), spellPoints, LanguageManager.GetString("String_SpellPoints"));
                            lblBP.ToolTipText = LanguageManager.GetString("Tip_SelectSpell_MasteryQuality");
                        }
                        else
                        {
                            lblBP.ToolTipText = string.Empty;
                        }
                    }
                }
                lblBPLabel.Visible = lblBP.Visible = !string.IsNullOrEmpty(lblBP.Text);

                string strSource = xmlQuality.SelectSingleNode("source")?.Value ?? LanguageManager.GetString("String_Unknown");
                string strPage = xmlQuality.SelectSingleNode("altpage")?.Value ?? xmlQuality.SelectSingleNode("page")?.Value ?? LanguageManager.GetString("String_Unknown");
                lblSource.Text = _objCharacter.LanguageBookShort(strSource) + strSpace + strPage;
                lblSource.SetToolTip(_objCharacter.LanguageBookLong(strSource) + strSpace + LanguageManager.GetString("String_Page") + strSpace + strPage);
                lblSourceLabel.Visible = lblSource.Visible = !string.IsNullOrEmpty(lblSource.Text);
            }
            else
            {
                lblBPLabel.Visible = false;
                lblBP.Visible = false;
                lblSourceLabel.Visible = false;
                lblSource.Visible = false;
                lblSource.SetToolTip(string.Empty);
            }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            _blnAddAgain = false;
            AcceptForm();
        }

        private void cmdOKAdd_Click(object sender, EventArgs e)
        {
            _blnAddAgain = true;
            AcceptForm();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lstQualities_DoubleClick(object sender, EventArgs e)
        {
            _blnAddAgain = false;
            AcceptForm();
        }

        private void chkLimitList_CheckedChanged(object sender, EventArgs e)
        {
            BuildQualityList();
        }

        private void chkFree_CheckedChanged(object sender, EventArgs e)
        {
            lstQualities_SelectedIndexChanged(sender, e);
        }

        private void chkMetagenic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMetagenic.Checked)
                chkNotMetagenic.Checked = false;
            BuildQualityList();
        }

        private void chkNotMetagenic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotMetagenic.Checked)
                chkMetagenic.Checked = false;
            BuildQualityList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BuildQualityList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lstQualities.SelectedIndex + 1 < lstQualities.Items.Count)
                {
                    lstQualities.SelectedIndex += 1;
                }
                else if (lstQualities.Items.Count > 0)
                {
                    lstQualities.SelectedIndex = 0;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                if (lstQualities.SelectedIndex - 1 >= 0)
                {
                    lstQualities.SelectedIndex -= 1;
                }
                else if (lstQualities.Items.Count > 0)
                {
                    lstQualities.SelectedIndex = lstQualities.Items.Count - 1;
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                txtSearch.Select(txtSearch.Text.Length, 0);
        }

        private void KarmaFilter(object sender, EventArgs e)
        {
            _blnLoading = true;
            if (string.IsNullOrWhiteSpace(nudMinimumBP.Text))
            {
                nudMinimumBP.Value = 0;
            }
            if (string.IsNullOrWhiteSpace(nudValueBP.Text))
            {
                nudValueBP.Value = 0;
            }
            if (string.IsNullOrWhiteSpace(nudMaximumBP.Text))
            {
                nudMaximumBP.Value = 0;
            }
            _blnLoading = false;
            BuildQualityList();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Quality that was selected in the dialogue.
        /// </summary>
        public string SelectedQuality => _strSelectedQuality;

        /// <summary>
        /// Forcefully add a Category to the list.
        /// </summary>
        public string ForceCategory
        {
            set
            {
                if (_lstCategory.Any(x => x.Value.ToString() == value))
                {
                    cboCategory.BeginUpdate();
                    cboCategory.SelectedValue = value;
                    cboCategory.Enabled = false;
                    cboCategory.EndUpdate();
                }
            }
        }

        /// <summary>
        /// A Quality the character has that should be ignored for checking Forbidden requirements (which would prevent upgrading/downgrading a Quality).
        /// </summary>
        public string IgnoreQuality { get; set; } = string.Empty;

        /// <summary>
        /// Whether or not the user wants to add another item after this one.
        /// </summary>
        public bool AddAgain => _blnAddAgain;

        /// <summary>
        /// Whether or not the item has no cost.
        /// </summary>
        public bool FreeCost => chkFree.Checked;

        #endregion

        #region Methods
        /// <summary>
        /// Build the list of Qualities.
        /// </summary>
        private void BuildQualityList()
        {
            if (_blnLoading)
                return;

            string strCategory = cboCategory.SelectedValue?.ToString() ?? string.Empty;
            StringBuilder sbdFilter = new StringBuilder('(' + _objCharacter.Options.BookXPath() + ')');
            if (!string.IsNullOrEmpty(strCategory) && strCategory != "Show All" && (GlobalOptions.SearchInCategoryOnly || txtSearch.TextLength == 0))
            {
                sbdFilter.Append(" and category = " + strCategory.CleanXPath());
            }
            else
            {
                StringBuilder objCategoryFilter = new StringBuilder();
                foreach (string strItem in _lstCategory.Select(x => x.Value))
                {
                    if (!string.IsNullOrEmpty(strItem))
                        objCategoryFilter.Append("category = " + strItem.CleanXPath() + " or ");
                }
                if (objCategoryFilter.Length > 0)
                {
                    objCategoryFilter.Length -= 4;
                    sbdFilter.Append(" and (" + objCategoryFilter + ')');
                }
            }
            if (chkMetagenic.Checked)
            {
                sbdFilter.Append(" and (metagenic = 'True' or required/oneof[contains(., 'Changeling')])");
            }
            else if (chkNotMetagenic.Checked)
            {
                sbdFilter.Append(" and not(metagenic = 'True') and not(required/oneof[contains(., 'Changeling')])");
            }
            if (nudValueBP.Value != 0)
            {
                if (_objCharacter.Created && !_objCharacter.Options.DontDoubleQualityPurchases && nudValueBP.Value > 0)
                {
                    sbdFilter.Append(" and ((doublecareer = 'False' and karma = " + nudValueBP.Value.ToString(GlobalOptions.InvariantCultureInfo)
                        + ") or (not(doublecareer = 'False') and karma = " + (nudValueBP.Value / 2).ToString(GlobalOptions.InvariantCultureInfo) + "))");
                }
                else
                {
                    sbdFilter.Append(" and karma = " + nudValueBP.Value.ToString(GlobalOptions.InvariantCultureInfo));
                }
            }
            else
            {
                if (nudMinimumBP.Value != 0)
                {
                    if (_objCharacter.Created && !_objCharacter.Options.DontDoubleQualityPurchases)
                    {
                        sbdFilter.Append(" and (((doublecareer = 'False' or karma < 0) and karma >= " + nudMinimumBP.Value.ToString(GlobalOptions.InvariantCultureInfo)
                            + ") or (not(doublecareer = 'False' or karma < 0) and karma >= " + (nudMinimumBP.Value / 2).ToString(GlobalOptions.InvariantCultureInfo) + "))");
                    }
                    else
                    {
                        sbdFilter.Append(" and karma >= " + nudMinimumBP.Value.ToString(GlobalOptions.InvariantCultureInfo));
                    }
                }

                if (nudMaximumBP.Value != 0)
                {
                    if (_objCharacter.Created && !_objCharacter.Options.DontDoubleQualityPurchases && nudMaximumBP.Value > 0)
                    {
                        sbdFilter.Append(" and (((doublecareer = 'False' or karma < 0) and karma <= " + nudMaximumBP.Value.ToString(GlobalOptions.InvariantCultureInfo)
                            + ") or (not(doublecareer = 'False' or karma < 0) and karma <= " + (nudMaximumBP.Value / 2).ToString(GlobalOptions.InvariantCultureInfo) + "))");
                    }
                    else
                    {
                        sbdFilter.Append(" and karma <= " + nudMaximumBP.Value.ToString(GlobalOptions.InvariantCultureInfo));
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtSearch.Text))
                sbdFilter.Append(" and " + CommonFunctions.GenerateSearchXPath(txtSearch.Text));

            string strCategoryLower = strCategory == "Show All" ? "*" : strCategory.ToLowerInvariant();
            List <ListItem> lstQuality = new List<ListItem>();
            foreach (XPathNavigator objXmlQuality in _xmlBaseQualityDataNode.Select("qualities/quality[" + sbdFilter + "]"))
            {
                string strLoopName = objXmlQuality.SelectSingleNode("name")?.Value;
                if (!string.IsNullOrEmpty(strLoopName))
                {
                    if (_xmlMetatypeQualityRestrictionNode != null && _xmlMetatypeQualityRestrictionNode.SelectSingleNode(strCategoryLower + "/quality[. = " + strLoopName.CleanXPath() + "]") == null)
                    {
                        continue;
                    }
                    if (!chkLimitList.Checked || objXmlQuality.RequirementsMet(_objCharacter, string.Empty, string.Empty, IgnoreQuality))
                    {
                        lstQuality.Add(new ListItem(objXmlQuality.SelectSingleNode("id")?.Value ?? string.Empty, objXmlQuality.SelectSingleNode("translate")?.Value ?? strLoopName));
                    }
                }
            }
            lstQuality.Sort(CompareListItems.CompareNames);

            string strOldSelectedQuality = lstQualities.SelectedValue?.ToString();
            _blnLoading = true;
            lstQualities.BeginUpdate();
            lstQualities.ValueMember = nameof(ListItem.Value);
            lstQualities.DisplayMember = nameof(ListItem.Name);
            lstQualities.DataSource = lstQuality;
            _blnLoading = false;
            if (string.IsNullOrEmpty(strOldSelectedQuality))
                lstQualities.SelectedIndex = -1;
            else
                lstQualities.SelectedValue = strOldSelectedQuality;
            lstQualities.EndUpdate();
        }

        /// <summary>
        /// Accept the selected item and close the form.
        /// </summary>
        private void AcceptForm()
        {
            string strSelectedQuality = lstQualities.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(strSelectedQuality))
                return;

            XPathNavigator objNode = _xmlBaseQualityDataNode.SelectSingleNode("qualities/quality[id = " + strSelectedQuality.CleanXPath() + "]");

            if (objNode == null || !objNode.RequirementsMet(_objCharacter, null, LanguageManager.GetString("String_Quality"), IgnoreQuality))
                return;

            _strSelectedQuality = strSelectedQuality;
            s_StrSelectCategory = (GlobalOptions.SearchInCategoryOnly || txtSearch.TextLength == 0) ? cboCategory.SelectedValue?.ToString() : objNode.SelectSingleNode("category")?.Value;
            DialogResult = DialogResult.OK;
        }

        private void OpenSourceFromLabel(object sender, EventArgs e)
        {
            CommonFunctions.OpenPdfFromControl(sender, e);
        }
        #endregion
    }
}
