using System;
using Chummer.UI.Powers;
using Chummer.UI.Attributes;
using Chummer.UI.Shared;

namespace Chummer
{
    partial class frmCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Selected Positive Qualities");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Selected Negative Qualities");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Selected Martial Arts");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Selected Qualities");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Selected Combat Spells");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Selected Detection Spells");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Selected Health Spells");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Selected Illusion Spells");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Selected Manipulation Spells");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Selected Rituals");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Selected Enchantments");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Selected Complex Forms");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Selected AI Programs and Advanced Programs");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Critter Powers");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Weaknesses");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Selected Cyberware");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Selected Bioware");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Unequipped Modular Cyberware");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Selected Gear");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Selected Armor");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Selected Weapons");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Selected Drugs");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Selected Lifestyles");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Selected Vehicles");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreate));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.tssBPLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBPRemainLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssBPRemain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEssence = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNuyenRemaining = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.lblAttributesAug = new System.Windows.Forms.Label();
            this.lblAttributesBase = new System.Windows.Forms.Label();
            this.lblAttributesMetatype = new System.Windows.Forms.Label();
            this.lblAttributes = new System.Windows.Forms.Label();
            this.lblNuyen = new System.Windows.Forms.Label();
            this.chkArmorEquipped = new System.Windows.Forms.CheckBox();
            this.chkWeaponAccessoryInstalled = new System.Windows.Forms.CheckBox();
            this.chkVehicleWeaponAccessoryInstalled = new System.Windows.Forms.CheckBox();
            this.lblNotoriety = new System.Windows.Forms.Label();
            this.lblStreetCred = new System.Windows.Forms.Label();
            this.chkCharacterCreated = new System.Windows.Forms.CheckBox();
            this.lblBuildFoci = new System.Windows.Forms.Label();
            this.lblBuildMartialArts = new System.Windows.Forms.Label();
            this.lblBuildNuyen = new System.Windows.Forms.Label();
            this.lblBuildEnemies = new System.Windows.Forms.Label();
            this.lblBuildComplexForms = new System.Windows.Forms.Label();
            this.lblBuildSprites = new System.Windows.Forms.Label();
            this.lblBuildSpirits = new System.Windows.Forms.Label();
            this.lblBuildSpells = new System.Windows.Forms.Label();
            this.lblBuildKnowledgeSkills = new System.Windows.Forms.Label();
            this.lblBuildActiveSkills = new System.Windows.Forms.Label();
            this.lblBuildSkillGroups = new System.Windows.Forms.Label();
            this.lblBuildContacts = new System.Windows.Forms.Label();
            this.lblBuildPrimaryAttributes = new System.Windows.Forms.Label();
            this.lblBuildNegativeQualities = new System.Windows.Forms.Label();
            this.lblBuildPositiveQualities = new System.Windows.Forms.Label();
            this.lblRiggingINILabel = new System.Windows.Forms.Label();
            this.lblMatrixINIHotLabel = new System.Windows.Forms.Label();
            this.lblMatrixINIColdLabel = new System.Windows.Forms.Label();
            this.lblMemoryLabel = new System.Windows.Forms.Label();
            this.lblLiftCarryLabel = new System.Windows.Forms.Label();
            this.lblJudgeIntentionsLabel = new System.Windows.Forms.Label();
            this.lblComposureLabel = new System.Windows.Forms.Label();
            this.lblRemainingNuyenLabel = new System.Windows.Forms.Label();
            this.lblESS = new System.Windows.Forms.Label();
            this.lblArmorLabel = new System.Windows.Forms.Label();
            this.lblAstralINILabel = new System.Windows.Forms.Label();
            this.lblMatrixINILabel = new System.Windows.Forms.Label();
            this.lblINILabel = new System.Windows.Forms.Label();
            this.lblCMStunLabel = new System.Windows.Forms.Label();
            this.lblCMPhysicalLabel = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSpellDefenceIndirectDodgeLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceIndirectSoakLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDirectSoakManaLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDirectSoakPhysicalLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttBODLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDetectionLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttAGILabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttSTRLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttREALabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttWILLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttLOGLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttINTLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceDecAttCHALabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceManipPhysicalLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceManipMentalLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceIllusionPhysicalLabel = new System.Windows.Forms.Label();
            this.lblSpellDefenceIllusionManaLabel = new System.Windows.Forms.Label();
            this.lblCounterspellingDiceLabel = new System.Windows.Forms.Label();
            this.lblFoci = new System.Windows.Forms.Label();
            this.lblBuildAIAdvancedPrograms = new System.Windows.Forms.Label();
            this.lblBuildRitualsBPLabel = new System.Windows.Forms.Label();
            this.lblBuildPrepsBPLabel = new System.Windows.Forms.Label();
            this.lblPublicAware = new System.Windows.Forms.Label();
            this.cmsMartialArts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMartialArtsAddAdvantage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMartialArtsNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSpellButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCreateSpell = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsComplexForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddComplexFormOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsComplexFormNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCyberware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCyberwareAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCyberwareAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCyberwareNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleCyberware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleCyberwareAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleCyberwareAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleCyberwareNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLifestyle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAdvancedLifestyle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArmor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddArmorMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddArmorGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArmorName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArmorNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWeapon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCreateNaturalWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponAddAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponAddUnderbarrel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponMountLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.lmtControl = new Chummer.UI.Shared.LimitTabUserControl();
            this.tsWeaponAddModification = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGearButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGearButtonAddAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleAddWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddWeaponWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddWeaponAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddUnderbarrelWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddWeaponMount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddMod = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddCyberware = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddSensor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleSensorAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleWeaponMountNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWeaponMount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleMountWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleMountWeaponAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleMountWeaponAccessory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleMountWeaponUnderbarrel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditWeaponMount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateMenu = new System.Windows.Forms.MenuStrip();
            this.mnuCreateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialAddCyberwareSuite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialAddBiowareSuite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialCreateCyberwareSuite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialCreateBiowareSuite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialAddPACKSKit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialCreatePACKSKit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialChangeMetatype = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialChangeOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialMutantCritter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialToxicCritter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialCyberzombie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialConvertToFreeSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialReapplyImprovements = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialBPAvailLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialConfirmValidity = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpecialKarmaValue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.cmsGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGearAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearAllowRenameAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearAllowRenameName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearAllowRenameNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleWeapon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleAddWeaponAccessoryAlt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleAddUnderbarrelWeaponAlt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleWeaponNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleGearAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleGearNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArmorGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsArmorGearAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArmorGearNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArmorMod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsArmorModNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsQuality = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsQualityNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSpell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsSpellNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCritterPowers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCritterPowersNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLifestyleNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEditLifestyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLifestyleName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLifestyleNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWeaponAccessory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsWeaponAccessoryAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponAccessoryNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGearPlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGearPluginNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsComplexFormPlugin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsComplexFormPluginNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBioware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsBiowareNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAdvancedLifestyle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEditAdvancedLifestyle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdvancedLifestyleNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGearLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGearRenameLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGearLocationAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArmorLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsArmorLocationAddArmor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsArmorRenameLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCyberwareGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsCyberwareGearMenuAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleCyberwareGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleCyberwareGearMenuAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWeaponAccessoryGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsWeaponAccessoryGearMenuAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleRenameLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleLocationAddVehicle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleWeaponAccessory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleWeaponAccessoryAddGear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVehicleWeaponAccessoryNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVehicleWeaponAccessoryGear = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsWeaponLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsWeaponRenameLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWeaponLocationAddWeapon = new System.Windows.Forms.ToolStripMenuItem();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabCharacterTabs = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.tlpCommon = new Chummer.BufferedTableLayoutPanel(this.components);
            this.tlpCommonLeftSide = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treQualities = new System.Windows.Forms.TreeView();
            this.cmdLifeModule = new System.Windows.Forms.Button();
            this.tlpCommonBottomLeftSide = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblQualitySource = new System.Windows.Forms.Label();
            this.lblQualityBP = new System.Windows.Forms.Label();
            this.lblQualitySourceLabel = new System.Windows.Forms.Label();
            this.lblQualityBPLabel = new System.Windows.Forms.Label();
            this.nudQualityLevel = new System.Windows.Forms.NumericUpDown();
            this.lblQualityLevelLabel = new System.Windows.Forms.Label();
            this.cmdAddQuality = new System.Windows.Forms.Button();
            this.cmdDeleteQuality = new System.Windows.Forms.Button();
            this.lblAlias = new System.Windows.Forms.Label();
            this.pnlAttributes = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.lblMetatypeLabel = new System.Windows.Forms.Label();
            this.lblMetatype = new System.Windows.Forms.Label();
            this.lblMetatypeSource = new System.Windows.Forms.Label();
            this.lblMetatypeSourceLabel = new System.Windows.Forms.Label();
            this.lblMysticAdeptAssignment = new System.Windows.Forms.Label();
            this.flpNuyen = new System.Windows.Forms.FlowLayoutPanel();
            this.nudNuyen = new System.Windows.Forms.NumericUpDown();
            this.lblNuyenTotal = new System.Windows.Forms.Label();
            this.nudMysticAdeptMAGMagician = new System.Windows.Forms.NumericUpDown();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tabSkillUc = new Chummer.UI.Skills.SkillsTabUserControl();
            this.tabLimits = new System.Windows.Forms.TabPage();
            this.tabMartialArts = new System.Windows.Forms.TabPage();
            this.tlpMartialArts = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treMartialArts = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddMartialArt = new SplitButton();
            this.cmdDeleteMartialArt = new System.Windows.Forms.Button();
            this.lblMartialArtSource = new System.Windows.Forms.Label();
            this.lblMartialArtSourceLabel = new System.Windows.Forms.Label();
            this.tabMagician = new System.Windows.Forms.TabPage();
            this.tlpMagician = new Chummer.BufferedTableLayoutPanel(this.components);
            this.cmdAddSpirit = new System.Windows.Forms.Button();
            this.panSpirits = new System.Windows.Forms.Panel();
            this.treSpells = new System.Windows.Forms.TreeView();
            this.lblSpellDV = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddSpell = new SplitButton();
            this.cmdDeleteSpell = new System.Windows.Forms.Button();
            this.lblSpellType = new System.Windows.Forms.Label();
            this.cboSpiritManipulation = new Chummer.ElasticComboBox();
            this.lblSpellDamage = new System.Windows.Forms.Label();
            this.lblTraditionSource = new System.Windows.Forms.Label();
            this.lblSpiritManipulation = new System.Windows.Forms.Label();
            this.lblSpellDescriptorsLabel = new System.Windows.Forms.Label();
            this.cboSpiritIllusion = new Chummer.ElasticComboBox();
            this.lblTraditionSourceLabel = new System.Windows.Forms.Label();
            this.cboSpiritHealth = new Chummer.ElasticComboBox();
            this.lblSpiritIllusion = new System.Windows.Forms.Label();
            this.lblSpellDescriptors = new System.Windows.Forms.Label();
            this.lblSpellCategoryLabel = new System.Windows.Forms.Label();
            this.lblSpiritHealth = new System.Windows.Forms.Label();
            this.lblSpellCategory = new System.Windows.Forms.Label();
            this.lblSpellRangeLabel = new System.Windows.Forms.Label();
            this.lblSpellRange = new System.Windows.Forms.Label();
            this.lblSpellDurationLabel = new System.Windows.Forms.Label();
            this.lblSpellDuration = new System.Windows.Forms.Label();
            this.lblSpellSourceLabel = new System.Windows.Forms.Label();
            this.lblSpellSource = new System.Windows.Forms.Label();
            this.lblSpellDicePoolLabel = new System.Windows.Forms.Label();
            this.lblSpellDicePool = new System.Windows.Forms.Label();
            this.lblTraditionLabel = new System.Windows.Forms.Label();
            this.lblDrainAttributesLabel = new System.Windows.Forms.Label();
            this.cboTradition = new Chummer.ElasticComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboDrain = new Chummer.ElasticComboBox();
            this.lblDrainAttributes = new System.Windows.Forms.Label();
            this.lblTraditionName = new System.Windows.Forms.Label();
            this.txtTraditionName = new System.Windows.Forms.TextBox();
            this.lblSpiritCombat = new System.Windows.Forms.Label();
            this.cboSpiritCombat = new Chummer.ElasticComboBox();
            this.lblSpiritDetection = new System.Windows.Forms.Label();
            this.cboSpiritDetection = new Chummer.ElasticComboBox();
            this.lblDrainAttributesValue = new Chummer.LabelWithToolTip();
            this.lblSpellTypeLabel = new System.Windows.Forms.Label();
            this.lblSpellDamageLabel = new System.Windows.Forms.Label();
            this.lblSpellDVLabel = new System.Windows.Forms.Label();
            this.lblMentorSpiritLabel = new System.Windows.Forms.Label();
            this.lblMentorSpirit = new System.Windows.Forms.Label();
            this.lblMentorSpiritInformation = new System.Windows.Forms.Label();
            this.tabAdept = new System.Windows.Forms.TabPage();
            this.tabPowerUc = new Chummer.UI.Powers.PowersTabUserControl();
            this.tabTechnomancer = new System.Windows.Forms.TabPage();
            this.tlpTechnomancer = new Chummer.BufferedTableLayoutPanel(this.components);
            this.cmdAddSprite = new System.Windows.Forms.Button();
            this.panSprites = new System.Windows.Forms.Panel();
            this.treComplexForms = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddComplexForm = new System.Windows.Forms.Button();
            this.cmdDeleteComplexForm = new System.Windows.Forms.Button();
            this.lblTargetLabel = new System.Windows.Forms.Label();
            this.lblFadingAttributesValue = new Chummer.LabelWithToolTip();
            this.cboStream = new Chummer.ElasticComboBox();
            this.lblFadingAttributes = new System.Windows.Forms.Label();
            this.lblFV = new System.Windows.Forms.Label();
            this.lblFadingAttributesLabel = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblFVLabel = new System.Windows.Forms.Label();
            this.lblDurationLabel = new System.Windows.Forms.Label();
            this.lblStreamLabel = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblComplexFormSource = new System.Windows.Forms.Label();
            this.lblComplexFormSourceLabel = new System.Windows.Forms.Label();
            this.lblParagonInformation = new System.Windows.Forms.Label();
            this.lblParagonLabel = new System.Windows.Forms.Label();
            this.lblParagon = new System.Windows.Forms.Label();
            this.tabAdvancedPrograms = new System.Windows.Forms.TabPage();
            this.tlpAdvancedPrograms = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treAIPrograms = new System.Windows.Forms.TreeView();
            this.lblAIProgramsSource = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddAIProgram = new System.Windows.Forms.Button();
            this.cmdDeleteAIProgram = new System.Windows.Forms.Button();
            this.lblAIProgramsRequires = new System.Windows.Forms.Label();
            this.lblAIProgramsRequiresLabel = new System.Windows.Forms.Label();
            this.lblAIProgramsSourceLabel = new System.Windows.Forms.Label();
            this.tabCritter = new System.Windows.Forms.TabPage();
            this.tlpCritter = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treCritterPowers = new System.Windows.Forms.TreeView();
            this.chkCritterPowerCount = new System.Windows.Forms.CheckBox();
            this.lblCritterPowerPointsLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerPointCost = new System.Windows.Forms.Label();
            this.lblCritterPowerPoints = new System.Windows.Forms.Label();
            this.lblCritterPowerPointCostLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerNameLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerName = new System.Windows.Forms.Label();
            this.lblCritterPowerCategoryLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerSource = new System.Windows.Forms.Label();
            this.lblCritterPowerCategory = new System.Windows.Forms.Label();
            this.lblCritterPowerSourceLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerTypeLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerDurationLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerDuration = new System.Windows.Forms.Label();
            this.lblCritterPowerType = new System.Windows.Forms.Label();
            this.lblCritterPowerActionLabel = new System.Windows.Forms.Label();
            this.lblCritterPowerRange = new System.Windows.Forms.Label();
            this.lblCritterPowerAction = new System.Windows.Forms.Label();
            this.lblCritterPowerRangeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddCritterPower = new System.Windows.Forms.Button();
            this.cmdDeleteCritterPower = new System.Windows.Forms.Button();
            this.tabInitiation = new System.Windows.Forms.TabPage();
            this.tlpInitiation = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treMetamagic = new System.Windows.Forms.TreeView();
            this.lblMetamagicSourceLabel = new System.Windows.Forms.Label();
            this.lblMetamagicSource = new System.Windows.Forms.Label();
            this.flpInitiationCheckBoxes = new System.Windows.Forms.FlowLayoutPanel();
            this.chkInitiationOrdeal = new System.Windows.Forms.CheckBox();
            this.chkInitiationSchooling = new System.Windows.Forms.CheckBox();
            this.chkInitiationGroup = new System.Windows.Forms.CheckBox();
            this.flpInitiationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddMetamagic = new System.Windows.Forms.Button();
            this.cmdDeleteMetamagic = new System.Windows.Forms.Button();
            this.tabCyberware = new System.Windows.Forms.TabPage();
            this.tlpCyberware = new Chummer.BufferedTableLayoutPanel(this.components);
            this.treCyberware = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddCyberware = new SplitButton();
            this.cmdAddBioware = new System.Windows.Forms.Button();
            this.cmdDeleteCyberware = new System.Windows.Forms.Button();
            this.flpCyberware = new System.Windows.Forms.FlowLayoutPanel();
            this.gpbEssenceConsumption = new System.Windows.Forms.GroupBox();
            this.tlpCyberwareEssenceConsumption = new System.Windows.Forms.TableLayoutPanel();
            this.lblCyberwareESSLabel = new System.Windows.Forms.Label();
            this.lblBiowareESSLabel = new System.Windows.Forms.Label();
            this.lblEssenceHoleESSLabel = new System.Windows.Forms.Label();
            this.lblPrototypeTranshumanESSLabel = new System.Windows.Forms.Label();
            this.lblCyberwareESS = new System.Windows.Forms.Label();
            this.lblBiowareESS = new System.Windows.Forms.Label();
            this.lblEssenceHoleESS = new System.Windows.Forms.Label();
            this.lblPrototypeTranshumanESS = new System.Windows.Forms.Label();
            this.tlpCyberwareCommon = new System.Windows.Forms.TableLayoutPanel();
            this.lblCyberwareNameLabel = new System.Windows.Forms.Label();
            this.nudCyberwareRating = new System.Windows.Forms.NumericUpDown();
            this.lblCyberwareRatingLabel = new System.Windows.Forms.Label();
            this.lblCyberwareCapacity = new System.Windows.Forms.Label();
            this.chkPrototypeTranshuman = new System.Windows.Forms.CheckBox();
            this.lblCyberwareCost = new System.Windows.Forms.Label();
            this.lblCyberwareCostLabel = new System.Windows.Forms.Label();
            this.lblCyberlimbAGI = new System.Windows.Forms.Label();
            this.lblCyberlimbAGILabel = new System.Windows.Forms.Label();
            this.lblCyberlimbSTR = new System.Windows.Forms.Label();
            this.lblCyberlimbSTRLabel = new System.Windows.Forms.Label();
            this.lblCyberwareCapacityLabel = new System.Windows.Forms.Label();
            this.lblCyberwareName = new System.Windows.Forms.Label();
            this.cmdCyberwareChangeMount = new System.Windows.Forms.Button();
            this.lblCyberwareCategoryLabel = new System.Windows.Forms.Label();
            this.lblCyberwareSource = new System.Windows.Forms.Label();
            this.lblCyberwareSourceLabel = new System.Windows.Forms.Label();
            this.lblCyberwareAvail = new System.Windows.Forms.Label();
            this.lblCyberwareAvailLabel = new System.Windows.Forms.Label();
            this.lblCyberwareEssence = new System.Windows.Forms.Label();
            this.lblCyberwareEssenceLabel = new System.Windows.Forms.Label();
            this.cboCyberwareGrade = new Chummer.ElasticComboBox();
            this.lblCyberwareGradeLabel = new System.Windows.Forms.Label();
            this.lblCyberwareCategory = new System.Windows.Forms.Label();
            this.tlpCyberwareMatrix = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblCyberFirewallLabel = new System.Windows.Forms.Label();
            this.lblCyberSleazeLabel = new System.Windows.Forms.Label();
            this.lblCyberDeviceRatingLabel = new System.Windows.Forms.Label();
            this.lblCyberDeviceRating = new System.Windows.Forms.Label();
            this.lblCyberAttack = new System.Windows.Forms.Label();
            this.lblCyberAttackLabel = new System.Windows.Forms.Label();
            this.lblCyberSleaze = new System.Windows.Forms.Label();
            this.lblCyberDataProcessingLabel = new System.Windows.Forms.Label();
            this.lblCyberDataProcessing = new System.Windows.Forms.Label();
            this.lblCyberFirewall = new System.Windows.Forms.Label();
            this.chkCyberwareHomeNode = new System.Windows.Forms.CheckBox();
            this.chkCyberwareActiveCommlink = new System.Windows.Forms.CheckBox();
            this.tabStreetGear = new System.Windows.Forms.TabPage();
            this.tabStreetGearTabs = new System.Windows.Forms.TabControl();
            this.tabGear = new System.Windows.Forms.TabPage();
            this.tlpGear = new Chummer.BufferedTableLayoutPanel(this.components);
            this.cmdCreateStackedFocus = new System.Windows.Forms.Button();
            this.chkGearActiveCommlink = new System.Windows.Forms.CheckBox();
            this.treFoci = new System.Windows.Forms.TreeView();
            this.chkGearHomeNode = new System.Windows.Forms.CheckBox();
            this.lblGearAttackLabel = new System.Windows.Forms.Label();
            this.lblGearSleazeLabel = new System.Windows.Forms.Label();
            this.lblGearDataProcessingLabel = new System.Windows.Forms.Label();
            this.lblGearFirewallLabel = new System.Windows.Forms.Label();
            this.cboGearFirewall = new Chummer.ElasticComboBox();
            this.lblGearDeviceRating = new System.Windows.Forms.Label();
            this.cboGearDataProcessing = new Chummer.ElasticComboBox();
            this.lblGearDeviceRatingLabel = new System.Windows.Forms.Label();
            this.treGear = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddGear = new SplitButton();
            this.cmdDeleteGear = new System.Windows.Forms.Button();
            this.cmdAddLocation = new System.Windows.Forms.Button();
            this.chkCommlinks = new System.Windows.Forms.CheckBox();
            this.cboGearSleaze = new Chummer.ElasticComboBox();
            this.lblGearNameLabel = new System.Windows.Forms.Label();
            this.cboGearAttack = new Chummer.ElasticComboBox();
            this.lblGearName = new System.Windows.Forms.Label();
            this.lblGearCategoryLabel = new System.Windows.Forms.Label();
            this.lblGearCategory = new System.Windows.Forms.Label();
            this.lblGearRatingLabel = new System.Windows.Forms.Label();
            this.nudGearRating = new System.Windows.Forms.NumericUpDown();
            this.lblGearCapacityLabel = new System.Windows.Forms.Label();
            this.lblGearCapacity = new System.Windows.Forms.Label();
            this.lblGearQtyLabel = new System.Windows.Forms.Label();
            this.chkGearEquipped = new System.Windows.Forms.CheckBox();
            this.lblGearAP = new System.Windows.Forms.Label();
            this.nudGearQty = new System.Windows.Forms.NumericUpDown();
            this.lblGearAPLabel = new System.Windows.Forms.Label();
            this.lblGearSource = new System.Windows.Forms.Label();
            this.lblGearDamageLabel = new System.Windows.Forms.Label();
            this.lblGearSourceLabel = new System.Windows.Forms.Label();
            this.lblGearDamage = new System.Windows.Forms.Label();
            this.lblGearAvailLabel = new System.Windows.Forms.Label();
            this.lblGearAvail = new System.Windows.Forms.Label();
            this.lblGearCostLabel = new System.Windows.Forms.Label();
            this.lblGearCost = new System.Windows.Forms.Label();
            this.tabArmor = new System.Windows.Forms.TabPage();
            this.tlpArmor = new Chummer.BufferedTableLayoutPanel(this.components);
            this.chkIncludedInArmor = new System.Windows.Forms.CheckBox();
            this.cmdArmorUnEquipAll = new System.Windows.Forms.Button();
            this.lblArmorEquippedLabel = new System.Windows.Forms.Label();
            this.lblArmorFirewall = new System.Windows.Forms.Label();
            this.treArmor = new System.Windows.Forms.TreeView();
            this.lblArmorDataProcessing = new System.Windows.Forms.Label();
            this.lblArmorFirewallLabel = new System.Windows.Forms.Label();
            this.lblArmorSleaze = new System.Windows.Forms.Label();
            this.lblArmorValueLabel = new System.Windows.Forms.Label();
            this.lblArmorSource = new System.Windows.Forms.Label();
            this.lblArmorAttack = new System.Windows.Forms.Label();
            this.lblArmorValue = new System.Windows.Forms.Label();
            this.lblArmorDeviceRating = new System.Windows.Forms.Label();
            this.lblArmorDataProcessingLabel = new System.Windows.Forms.Label();
            this.lblArmorDeviceRatingLabel = new System.Windows.Forms.Label();
            this.lblArmorRatingLabel = new System.Windows.Forms.Label();
            this.nudArmorRating = new System.Windows.Forms.NumericUpDown();
            this.lblArmorAvailLabel = new System.Windows.Forms.Label();
            this.lblArmorAvail = new System.Windows.Forms.Label();
            this.lblArmorCapacityLabel = new System.Windows.Forms.Label();
            this.lblArmorCapacity = new System.Windows.Forms.Label();
            this.lblArmorSourceLabel = new System.Windows.Forms.Label();
            this.lblArmorCostLabel = new System.Windows.Forms.Label();
            this.lblArmorCost = new System.Windows.Forms.Label();
            this.lblArmorAttackLabel = new System.Windows.Forms.Label();
            this.lblArmorSleazeLabel = new System.Windows.Forms.Label();
            this.cmdArmorEquipAll = new System.Windows.Forms.Button();
            this.lblArmorEquipped = new System.Windows.Forms.Label();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddArmor = new SplitButton();
            this.cmdDeleteArmor = new System.Windows.Forms.Button();
            this.cmdAddArmorBundle = new System.Windows.Forms.Button();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tlpWeapons = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblWeaponCapacity = new System.Windows.Forms.Label();
            this.treWeapons = new System.Windows.Forms.TreeView();
            this.lblWeaponCapacityLabel = new System.Windows.Forms.Label();
            this.lblWeaponNameLabel = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.lblWeaponCategoryLabel = new System.Windows.Forms.Label();
            this.lblWeaponCategory = new System.Windows.Forms.Label();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddWeapon = new SplitButton();
            this.cmdDeleteWeapon = new System.Windows.Forms.Button();
            this.cmdAddWeaponLocation = new System.Windows.Forms.Button();
            this.lblWeaponDamageLabel = new System.Windows.Forms.Label();
            this.lblWeaponDamage = new System.Windows.Forms.Label();
            this.lblWeaponRating = new System.Windows.Forms.Label();
            this.lblWeaponRatingLabel = new System.Windows.Forms.Label();
            this.lblWeaponAPLabel = new System.Windows.Forms.Label();
            this.lblWeaponAP = new System.Windows.Forms.Label();
            this.lblWeaponAccuracyLabel = new System.Windows.Forms.Label();
            this.lblWeaponAccuracy = new System.Windows.Forms.Label();
            this.lblWeaponSlotsLabel = new System.Windows.Forms.Label();
            this.lblWeaponSlots = new System.Windows.Forms.Label();
            this.lblWeaponConceal = new System.Windows.Forms.Label();
            this.lblWeaponSourceLabel = new System.Windows.Forms.Label();
            this.lblWeaponConcealLabel = new System.Windows.Forms.Label();
            this.lblWeaponSource = new System.Windows.Forms.Label();
            this.lblWeaponAvailLabel = new System.Windows.Forms.Label();
            this.lblWeaponAvail = new System.Windows.Forms.Label();
            this.lblWeaponCostLabel = new System.Windows.Forms.Label();
            this.lblWeaponCost = new System.Windows.Forms.Label();
            this.lblWeaponReachLabel = new System.Windows.Forms.Label();
            this.lblWeaponReach = new System.Windows.Forms.Label();
            this.lblWeaponAmmoLabel = new System.Windows.Forms.Label();
            this.lblWeaponAmmo = new System.Windows.Forms.Label();
            this.lblWeaponModeLabel = new System.Windows.Forms.Label();
            this.chkIncludedInWeapon = new System.Windows.Forms.CheckBox();
            this.lblWeaponMode = new System.Windows.Forms.Label();
            this.lblWeaponRCLabel = new System.Windows.Forms.Label();
            this.lblWeaponRC = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblWeaponAlternateRangeExtreme = new System.Windows.Forms.Label();
            this.lblWeaponRangeAlternate = new System.Windows.Forms.Label();
            this.lblWeaponAlternateRangeLong = new System.Windows.Forms.Label();
            this.lblWeaponRangeLabel = new System.Windows.Forms.Label();
            this.lblWeaponAlternateRangeMedium = new System.Windows.Forms.Label();
            this.lblWeaponRangeMain = new System.Windows.Forms.Label();
            this.lblWeaponAlternateRangeShort = new System.Windows.Forms.Label();
            this.lblWeaponDicePoolLabel = new System.Windows.Forms.Label();
            this.lblWeaponDicePool = new System.Windows.Forms.Label();
            this.lblWeaponRangeShortLabel = new System.Windows.Forms.Label();
            this.lblWeaponRangeShort = new System.Windows.Forms.Label();
            this.lblWeaponRangeMediumLabel = new System.Windows.Forms.Label();
            this.lblWeaponRangeLongLabel = new System.Windows.Forms.Label();
            this.lblWeaponRangeExtremeLabel = new System.Windows.Forms.Label();
            this.lblWeaponRangeMedium = new System.Windows.Forms.Label();
            this.lblWeaponRangeLong = new System.Windows.Forms.Label();
            this.lblWeaponRangeExtreme = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblWeaponFirewall = new System.Windows.Forms.Label();
            this.lblWeaponDataProcessing = new System.Windows.Forms.Label();
            this.lblWeaponFirewallLabel = new System.Windows.Forms.Label();
            this.lblWeaponSleaze = new System.Windows.Forms.Label();
            this.lblWeaponAttack = new System.Windows.Forms.Label();
            this.lblWeaponAttackLabel = new System.Windows.Forms.Label();
            this.lblWeaponDataProcessingLabel = new System.Windows.Forms.Label();
            this.lblWeaponSleazeLabel = new System.Windows.Forms.Label();
            this.lblWeaponDeviceRatingLabel = new System.Windows.Forms.Label();
            this.lblWeaponDeviceRating = new System.Windows.Forms.Label();
            this.tabDrugs = new System.Windows.Forms.TabPage();
            this.tblDrugInfo = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblDrugNameLabel = new System.Windows.Forms.Label();
            this.treCustomDrugs = new System.Windows.Forms.TreeView();
            this.lblDrugComponents = new System.Windows.Forms.Label();
            this.lblDrugComponentsLabel = new System.Windows.Forms.Label();
            this.lblDrugAddictionThresholdLabel = new System.Windows.Forms.Label();
            this.lblDrugAddictionRating = new System.Windows.Forms.Label();
            this.lblDrugAddictionRatingLabel = new System.Windows.Forms.Label();
            this.lblDrugGrade = new System.Windows.Forms.Label();
            this.lblDrugQtyLabel = new System.Windows.Forms.Label();
            this.lblDrugAddictionThreshold = new System.Windows.Forms.Label();
            this.lblDrugGradeLabel = new System.Windows.Forms.Label();
            this.nudDrugQty = new System.Windows.Forms.NumericUpDown();
            this.lblDrugName = new System.Windows.Forms.Label();
            this.lblDrugCategoryLabel = new System.Windows.Forms.Label();
            this.lblDrugCostLabel = new System.Windows.Forms.Label();
            this.lblDrugCost = new System.Windows.Forms.Label();
            this.lblDrugCategory = new System.Windows.Forms.Label();
            this.lblDrugAvailabel = new System.Windows.Forms.Label();
            this.lblDrugAvail = new System.Windows.Forms.Label();
            this.lblDrugEffectLabel = new System.Windows.Forms.Label();
            this.lblDrugEffect = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateCustomDrug = new System.Windows.Forms.Button();
            this.btnDeleteCustomDrug = new System.Windows.Forms.Button();
            this.tabLifestyle = new System.Windows.Forms.TabPage();
            this.tblLifestyleDetails = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblLifestyleCostLabel = new System.Windows.Forms.Label();
            this.treLifestyles = new System.Windows.Forms.TreeView();
            this.lblLifestyleCost = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new Chummer.BufferedTableLayoutPanel(this.components);
            this.nudLifestyleMonths = new System.Windows.Forms.NumericUpDown();
            this.lblLifestyleMonthsLabel = new System.Windows.Forms.Label();
            this.lblLifestyleTotalCost = new System.Windows.Forms.Label();
            this.lblLifestyleQualitiesLabel = new System.Windows.Forms.Label();
            this.lblLifestyleSourceLabel = new System.Windows.Forms.Label();
            this.lblLifestyleStartingNuyen = new System.Windows.Forms.Label();
            this.lblLifestyleStartingNuyenLabel = new System.Windows.Forms.Label();
            this.lblBaseLifestyle = new System.Windows.Forms.Label();
            this.lblLifestyleSource = new System.Windows.Forms.Label();
            this.lblLifestyleComfortsLabel = new System.Windows.Forms.Label();
            this.lblLifestyleQualities = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddLifestyle = new SplitButton();
            this.cmdDeleteLifestyle = new System.Windows.Forms.Button();
            this.tabVehicles = new System.Windows.Forms.TabPage();
            this.tlpVehicles = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblVehicleWeaponAccuracyLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddVehicle = new SplitButton();
            this.cmdDeleteVehicle = new System.Windows.Forms.Button();
            this.cmdAddVehicleLocation = new System.Windows.Forms.Button();
            this.lblVehicleWeaponAccuracy = new System.Windows.Forms.Label();
            this.lblVehicleNameLabel = new System.Windows.Forms.Label();
            this.cmdVehicleCyberwareChangeMount = new System.Windows.Forms.Button();
            this.chkVehicleActiveCommlink = new System.Windows.Forms.CheckBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.lblVehicleCategoryLabel = new System.Windows.Forms.Label();
            this.lblVehicleCategory = new System.Windows.Forms.Label();
            this.lblVehicleHandlingLabel = new System.Windows.Forms.Label();
            this.lblVehicleHandling = new System.Windows.Forms.Label();
            this.lblVehicleAccelLabel = new System.Windows.Forms.Label();
            this.lblVehicleAccel = new System.Windows.Forms.Label();
            this.lblVehicleSpeedLabel = new System.Windows.Forms.Label();
            this.lblVehicleSpeed = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAmmoLabel = new System.Windows.Forms.Label();
            this.lblVehicleCosmetic = new System.Windows.Forms.Label();
            this.treVehicles = new System.Windows.Forms.TreeView();
            this.lblVehicleWeaponMode = new System.Windows.Forms.Label();
            this.lblVehicleDroneModSlots = new System.Windows.Forms.Label();
            this.lblVehicleWeaponModeLabel = new System.Windows.Forms.Label();
            this.lblVehicleCosmeticLabel = new System.Windows.Forms.Label();
            this.lblVehicleElectromagnetic = new System.Windows.Forms.Label();
            this.lblVehicleSeats = new System.Windows.Forms.Label();
            this.lblVehicleBodymod = new System.Windows.Forms.Label();
            this.lblVehicleElectromagneticLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAP = new System.Windows.Forms.Label();
            this.lblVehicleDroneModSlotsLabel = new System.Windows.Forms.Label();
            this.lblVehiclePowertrain = new System.Windows.Forms.Label();
            this.lblVehicleWeaponDamage = new System.Windows.Forms.Label();
            this.lblVehicleWeaponDamageLabel = new System.Windows.Forms.Label();
            this.lblVehicleProtection = new System.Windows.Forms.Label();
            this.lblVehicleBodymodLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponsmod = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAmmo = new System.Windows.Forms.Label();
            this.lblVehicleSource = new System.Windows.Forms.Label();
            this.nudVehicleGearQty = new System.Windows.Forms.NumericUpDown();
            this.lblVehicleSourceLabel = new System.Windows.Forms.Label();
            this.lblVehicleSeatsLabel = new System.Windows.Forms.Label();
            this.lblVehicleGearQtyLabel = new System.Windows.Forms.Label();
            this.lblVehiclePowertrainLabel = new System.Windows.Forms.Label();
            this.chkVehicleHomeNode = new System.Windows.Forms.CheckBox();
            this.lblVehiclePilotLabel = new System.Windows.Forms.Label();
            this.lblVehiclePilot = new System.Windows.Forms.Label();
            this.lblVehicleProtectionLabel = new System.Windows.Forms.Label();
            this.chkVehicleIncludedInWeapon = new System.Windows.Forms.CheckBox();
            this.lblVehicleBodyLabel = new System.Windows.Forms.Label();
            this.lblVehicleBody = new System.Windows.Forms.Label();
            this.lblVehicleWeaponsmodLabel = new System.Windows.Forms.Label();
            this.lblVehicleArmorLabel = new System.Windows.Forms.Label();
            this.nudVehicleRating = new System.Windows.Forms.NumericUpDown();
            this.lblVehicleSlots = new System.Windows.Forms.Label();
            this.lblVehicleRatingLabel = new System.Windows.Forms.Label();
            this.lblVehicleArmor = new System.Windows.Forms.Label();
            this.lblVehicleSlotsLabel = new System.Windows.Forms.Label();
            this.lblVehicleSensorLabel = new System.Windows.Forms.Label();
            this.lblVehicleSensor = new System.Windows.Forms.Label();
            this.lblVehicleAttackLabel = new System.Windows.Forms.Label();
            this.cboVehicleGearAttack = new Chummer.ElasticComboBox();
            this.cboVehicleGearSleaze = new Chummer.ElasticComboBox();
            this.lblVehicleSleazeLabel = new System.Windows.Forms.Label();
            this.lblVehicleDataProcessingLabel = new System.Windows.Forms.Label();
            this.cboVehicleGearDataProcessing = new Chummer.ElasticComboBox();
            this.lblVehicleFirewallLabel = new System.Windows.Forms.Label();
            this.cboVehicleGearFirewall = new Chummer.ElasticComboBox();
            this.lblVehicleDeviceLabel = new System.Windows.Forms.Label();
            this.lblVehicleDevice = new System.Windows.Forms.Label();
            this.lblVehicleCostLabel = new System.Windows.Forms.Label();
            this.lblVehicleCost = new System.Windows.Forms.Label();
            this.lblVehicleAvailLabel = new System.Windows.Forms.Label();
            this.lblVehicleAvail = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAPLabel = new System.Windows.Forms.Label();
            this.tlpVehicleWeapon = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblVehicleWeaponAlternateRangeExtreme = new System.Windows.Forms.Label();
            this.lblVehicleWeaponDicePool = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeExtreme = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAlternateRangeLong = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeExtremeLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAlternateRangeMedium = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeLong = new System.Windows.Forms.Label();
            this.lblVehicleWeaponDicePoolLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponAlternateRangeShort = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeLongLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeShortLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeMedium = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeAlternate = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeMain = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeMediumLabel = new System.Windows.Forms.Label();
            this.lblVehicleWeaponRangeShort = new System.Windows.Forms.Label();
            this.tabCharacterInfo = new System.Windows.Forms.TabPage();
            this.tlpCharacterInfo = new Chummer.BufferedTableLayoutPanel(this.components);
            this.picMugshot = new System.Windows.Forms.PictureBox();
            this.chkIsMainMugshot = new System.Windows.Forms.CheckBox();
            this.cboPrimaryArm = new Chummer.ElasticComboBox();
            this.lblNumMugshots = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.nudMugshotIndex = new System.Windows.Forms.NumericUpDown();
            this.lblHandedness = new System.Windows.Forms.Label();
            this.btnCreateBackstory = new System.Windows.Forms.Button();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblPublicAwareTotal = new Chummer.LabelWithToolTip();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNotorietyTotal = new Chummer.LabelWithToolTip();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblStreetCredTotal = new Chummer.LabelWithToolTip();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.lblEyes = new System.Windows.Forms.Label();
            this.lblConcept = new System.Windows.Forms.Label();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.txtEyes = new System.Windows.Forms.TextBox();
            this.lblBackground = new System.Windows.Forms.Label();
            this.lblHair = new System.Windows.Forms.Label();
            this.txtHair = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblSkin = new System.Windows.Forms.Label();
            this.txtSkin = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMugshot = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddMugshot = new System.Windows.Forms.Button();
            this.cmdDeleteMugshot = new System.Windows.Forms.Button();
            this.tabRelationships = new System.Windows.Forms.TabPage();
            this.tabPeople = new System.Windows.Forms.TabControl();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.tlpContacts = new System.Windows.Forms.TableLayoutPanel();
            this.panContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblContactArchtypeLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddContact = new SplitButton();
            this.cmsAddContact = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdContactsExpansionToggle = new System.Windows.Forms.Button();
            this.cmdSwapContactOrder = new System.Windows.Forms.Button();
            this.lblContactPoints_Label = new System.Windows.Forms.Label();
            this.lblContactPoints = new System.Windows.Forms.Label();
            this.lblContactLocationLabel = new System.Windows.Forms.Label();
            this.lblContactNameLabel = new System.Windows.Forms.Label();
            this.tabEnemies = new System.Windows.Forms.TabPage();
            this.tlpEnemies = new System.Windows.Forms.TableLayoutPanel();
            this.panEnemies = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddEnemy = new SplitButton();
            this.tabPets = new System.Windows.Forms.TabPage();
            this.tlpPets = new System.Windows.Forms.TableLayoutPanel();
            this.panPets = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdAddPet = new SplitButton();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabBPSummary = new System.Windows.Forms.TabPage();
            this.tlpKarmaSummary = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblAINormalProgramsBP = new System.Windows.Forms.Label();
            this.lblAIAdvancedProgramsBP = new System.Windows.Forms.Label();
            this.lblBuildRitualsBP = new System.Windows.Forms.Label();
            this.lblBuildAINormalPrograms = new System.Windows.Forms.Label();
            this.lblPBuildSpecial = new System.Windows.Forms.Label();
            this.lblSummaryMetatype = new System.Windows.Forms.Label();
            this.lblInitiationBP = new System.Windows.Forms.Label();
            this.lblMartialArtsBP = new System.Windows.Forms.Label();
            this.lblBuildPrepsBP = new System.Windows.Forms.Label();
            this.lblBuildInitiation = new System.Windows.Forms.Label();
            this.lblFociBP = new System.Windows.Forms.Label();
            this.lblComplexFormsBP = new System.Windows.Forms.Label();
            this.lblPBuildSpecialLabel = new System.Windows.Forms.Label();
            this.lblKarmaMetatypeBP = new System.Windows.Forms.Label();
            this.lblSpritesBP = new System.Windows.Forms.Label();
            this.lblSpiritsBP = new System.Windows.Forms.Label();
            this.lblAttributesBP = new System.Windows.Forms.Label();
            this.lblPositiveQualitiesBP = new System.Windows.Forms.Label();
            this.lblNegativeQualitiesBP = new System.Windows.Forms.Label();
            this.lblContactsBP = new System.Windows.Forms.Label();
            this.lblEnemiesBP = new System.Windows.Forms.Label();
            this.lblNuyenBP = new System.Windows.Forms.Label();
            this.lblSkillGroupsBP = new System.Windows.Forms.Label();
            this.lblActiveSkillsBP = new System.Windows.Forms.Label();
            this.lblSpellsBP = new System.Windows.Forms.Label();
            this.lblKnowledgeSkillsBP = new System.Windows.Forms.Label();
            this.tabOtherInfo = new System.Windows.Forms.TabPage();
            this.tlpOtherInfo = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblFly = new System.Windows.Forms.Label();
            this.lblRiggingINI = new System.Windows.Forms.Label();
            this.lblFlyLabel = new System.Windows.Forms.Label();
            this.lblSwim = new System.Windows.Forms.Label();
            this.lblSwimLabel = new System.Windows.Forms.Label();
            this.lblCMPhysical = new System.Windows.Forms.Label();
            this.lblMovement = new System.Windows.Forms.Label();
            this.lblMemory = new Chummer.LabelWithToolTip();
            this.lblMovementLabel = new System.Windows.Forms.Label();
            this.lblMatrixINIHot = new System.Windows.Forms.Label();
            this.lblLiftCarry = new Chummer.LabelWithToolTip();
            this.lblMatrixINICold = new System.Windows.Forms.Label();
            this.lblJudgeIntentions = new Chummer.LabelWithToolTip();
            this.lblCMStun = new System.Windows.Forms.Label();
            this.lblComposure = new Chummer.LabelWithToolTip();
            this.lblINI = new System.Windows.Forms.Label();
            this.lblRemainingNuyen = new System.Windows.Forms.Label();
            this.lblAstralINI = new System.Windows.Forms.Label();
            this.lblMatrixINI = new System.Windows.Forms.Label();
            this.lblESSMax = new System.Windows.Forms.Label();
            this.lblArmor = new Chummer.LabelWithToolTip();
            this.tabDefences = new System.Windows.Forms.TabPage();
            this.tlpSpellDefense = new Chummer.BufferedTableLayoutPanel(this.components);
            this.lblSpellDefenceManipPhysical = new Chummer.LabelWithToolTip();
            this.nudCounterspellingDice = new System.Windows.Forms.NumericUpDown();
            this.lblSpellDefenceManipMental = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceIllusionPhysical = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceIndirectDodge = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceIllusionMana = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceIndirectSoak = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttWIL = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttLOG = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDirectSoakMana = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttINT = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDirectSoakPhysical = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttCHA = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDetection = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttSTR = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttBOD = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttAGI = new Chummer.LabelWithToolTip();
            this.lblSpellDefenceDecAttREA = new Chummer.LabelWithToolTip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmsInitiationNotes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsInitiationNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMetamagic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMetamagicAddArt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMetamagicAddEnchantment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMetamagicAddEnhancement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMetamagicAddMetamagic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMetamagicAddRitual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMetamagicNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTechnique = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddTechniqueNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAdvancedProgram = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsAddAdvancedProgramOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAIProgramNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsGearAllowRename = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGearAllowRenameExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip.SuspendLayout();
            this.cmsMartialArts.SuspendLayout();
            this.cmsSpellButton.SuspendLayout();
            this.cmsComplexForm.SuspendLayout();
            this.cmsCyberware.SuspendLayout();
            this.cmsVehicleCyberware.SuspendLayout();
            this.cmsLifestyle.SuspendLayout();
            this.cmsArmor.SuspendLayout();
            this.cmsWeapon.SuspendLayout();
            this.cmsGearButton.SuspendLayout();
            this.cmsVehicle.SuspendLayout();
            this.cmsWeaponMount.SuspendLayout();
            this.mnuCreateMenu.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.cmsGear.SuspendLayout();
            this.cmsVehicleWeapon.SuspendLayout();
            this.cmsVehicleGear.SuspendLayout();
            this.cmsArmorGear.SuspendLayout();
            this.cmsArmorMod.SuspendLayout();
            this.cmsQuality.SuspendLayout();
            this.cmsSpell.SuspendLayout();
            this.cmsCritterPowers.SuspendLayout();
            this.cmsLifestyleNotes.SuspendLayout();
            this.cmsWeaponAccessory.SuspendLayout();
            this.cmsGearPlugin.SuspendLayout();
            this.cmsComplexFormPlugin.SuspendLayout();
            this.cmsBioware.SuspendLayout();
            this.cmsAdvancedLifestyle.SuspendLayout();
            this.cmsGearLocation.SuspendLayout();
            this.cmsArmorLocation.SuspendLayout();
            this.cmsCyberwareGear.SuspendLayout();
            this.cmsVehicleCyberwareGear.SuspendLayout();
            this.cmsWeaponAccessoryGear.SuspendLayout();
            this.cmsVehicleLocation.SuspendLayout();
            this.cmsVehicleWeaponAccessory.SuspendLayout();
            this.cmsVehicleWeaponAccessoryGear.SuspendLayout();
            this.cmsWeaponLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabCharacterTabs.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tlpCommon.SuspendLayout();
            this.tlpCommonLeftSide.SuspendLayout();
            this.tlpCommonBottomLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQualityLevel)).BeginInit();
            this.flpNuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMysticAdeptMAGMagician)).BeginInit();
            this.tabSkills.SuspendLayout();
            this.tabLimits.SuspendLayout();
            this.tabMartialArts.SuspendLayout();
            this.tlpMartialArts.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabMagician.SuspendLayout();
            this.tlpMagician.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabAdept.SuspendLayout();
            this.tabTechnomancer.SuspendLayout();
            this.tlpTechnomancer.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabAdvancedPrograms.SuspendLayout();
            this.tlpAdvancedPrograms.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tabCritter.SuspendLayout();
            this.tlpCritter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabInitiation.SuspendLayout();
            this.tlpInitiation.SuspendLayout();
            this.flpInitiationCheckBoxes.SuspendLayout();
            this.flpInitiationButtons.SuspendLayout();
            this.tabCyberware.SuspendLayout();
            this.tlpCyberware.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flpCyberware.SuspendLayout();
            this.gpbEssenceConsumption.SuspendLayout();
            this.tlpCyberwareEssenceConsumption.SuspendLayout();
            this.tlpCyberwareCommon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCyberwareRating)).BeginInit();
            this.tlpCyberwareMatrix.SuspendLayout();
            this.tabStreetGear.SuspendLayout();
            this.tabStreetGearTabs.SuspendLayout();
            this.tabGear.SuspendLayout();
            this.tlpGear.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGearRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGearQty)).BeginInit();
            this.tabArmor.SuspendLayout();
            this.tlpArmor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorRating)).BeginInit();
            this.flowLayoutPanel14.SuspendLayout();
            this.tabWeapons.SuspendLayout();
            this.tlpWeapons.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabDrugs.SuspendLayout();
            this.tblDrugInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrugQty)).BeginInit();
            this.flowLayoutPanel12.SuspendLayout();
            this.tabLifestyle.SuspendLayout();
            this.tblLifestyleDetails.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLifestyleMonths)).BeginInit();
            this.flowLayoutPanel11.SuspendLayout();
            this.tabVehicles.SuspendLayout();
            this.tlpVehicles.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleGearQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleRating)).BeginInit();
            this.tlpVehicleWeapon.SuspendLayout();
            this.tabCharacterInfo.SuspendLayout();
            this.tlpCharacterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMugshotIndex)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            this.tabRelationships.SuspendLayout();
            this.tabPeople.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.tlpContacts.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.cmsAddContact.SuspendLayout();
            this.tabEnemies.SuspendLayout();
            this.tlpEnemies.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            this.tabPets.SuspendLayout();
            this.tlpPets.SuspendLayout();
            this.flowLayoutPanel17.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabBPSummary.SuspendLayout();
            this.tlpKarmaSummary.SuspendLayout();
            this.tabOtherInfo.SuspendLayout();
            this.tlpOtherInfo.SuspendLayout();
            this.tabDefences.SuspendLayout();
            this.tlpSpellDefense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounterspellingDice)).BeginInit();
            this.cmsInitiationNotes.SuspendLayout();
            this.cmsMetamagic.SuspendLayout();
            this.cmsTechnique.SuspendLayout();
            this.cmsAdvancedProgram.SuspendLayout();
            this.cmsGearAllowRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssBPLabel,
            this.tssBP,
            this.tssBPRemainLabel,
            this.tssBPRemain,
            this.toolStripStatusLabel3,
            this.tssEssence,
            this.toolStripStatusLabel4,
            this.tssNuyenRemaining,
            this.pgbProgress});
            this.StatusStrip.Location = new System.Drawing.Point(0, 657);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1085, 24);
            this.StatusStrip.TabIndex = 24;
            this.StatusStrip.Text = "StatusStrip1";
            // 
            // tssBPLabel
            // 
            this.tssBPLabel.Name = "tssBPLabel";
            this.tssBPLabel.Size = new System.Drawing.Size(44, 19);
            this.tssBPLabel.Tag = "Label_Karma";
            this.tssBPLabel.Text = "Karma:";
            // 
            // tssBP
            // 
            this.tssBP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssBP.Name = "tssBP";
            this.tssBP.Size = new System.Drawing.Size(29, 19);
            this.tssBP.Text = "400";
            // 
            // tssBPRemainLabel
            // 
            this.tssBPRemainLabel.Name = "tssBPRemainLabel";
            this.tssBPRemainLabel.Size = new System.Drawing.Size(104, 19);
            this.tssBPRemainLabel.Tag = "Label_KarmaRemaining";
            this.tssBPRemainLabel.Text = "Karma Remaining:";
            // 
            // tssBPRemain
            // 
            this.tssBPRemain.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssBPRemain.Name = "tssBPRemain";
            this.tssBPRemain.Size = new System.Drawing.Size(29, 19);
            this.tssBPRemain.Text = "400";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(51, 19);
            this.toolStripStatusLabel3.Tag = "Label_OtherEssence";
            this.toolStripStatusLabel3.Text = "Essence:";
            // 
            // tssEssence
            // 
            this.tssEssence.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssEssence.Name = "tssEssence";
            this.tssEssence.Size = new System.Drawing.Size(32, 19);
            this.tssEssence.Text = "6.00";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(105, 19);
            this.toolStripStatusLabel4.Tag = "Label_OtherNuyenRemain";
            this.toolStripStatusLabel4.Text = "Nuyen Remaining:";
            // 
            // tssNuyenRemaining
            // 
            this.tssNuyenRemaining.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssNuyenRemaining.Name = "tssNuyenRemaining";
            this.tssNuyenRemaining.Size = new System.Drawing.Size(23, 19);
            this.tssNuyenRemaining.Text = "0¥";
            // 
            // pgbProgress
            // 
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(400, 18);
            this.pgbProgress.Visible = false;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "sr5";
            this.dlgSaveFile.Filter = "Chummer Character|*.sr5";
            this.dlgSaveFile.Title = "Save Character";
            // 
            // lblAttributesAug
            // 
            this.lblAttributesAug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributesAug.AutoSize = true;
            this.lblAttributesAug.Location = new System.Drawing.Point(521, 32);
            this.lblAttributesAug.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAttributesAug.Name = "lblAttributesAug";
            this.lblAttributesAug.Size = new System.Drawing.Size(50, 13);
            this.lblAttributesAug.TabIndex = 55;
            this.lblAttributesAug.Tag = "Label_ValAugmented";
            this.lblAttributesAug.Text = "Val (Aug)";
            // 
            // lblAttributesBase
            // 
            this.lblAttributesBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributesBase.AutoSize = true;
            this.lblAttributesBase.Location = new System.Drawing.Point(423, 32);
            this.lblAttributesBase.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAttributesBase.Name = "lblAttributesBase";
            this.lblAttributesBase.Size = new System.Drawing.Size(36, 13);
            this.lblAttributesBase.TabIndex = 54;
            this.lblAttributesBase.Tag = "String_Points";
            this.lblAttributesBase.Text = "Points";
            // 
            // lblAttributesMetatype
            // 
            this.lblAttributesMetatype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributesMetatype.AutoSize = true;
            this.lblAttributesMetatype.Location = new System.Drawing.Point(577, 32);
            this.lblAttributesMetatype.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAttributesMetatype.Name = "lblAttributesMetatype";
            this.lblAttributesMetatype.Size = new System.Drawing.Size(80, 13);
            this.lblAttributesMetatype.TabIndex = 53;
            this.lblAttributesMetatype.Tag = "Label_MetatypeLimits";
            this.lblAttributesMetatype.Text = "Metatype Limits";
            // 
            // lblAttributes
            // 
            this.lblAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAttributes.AutoSize = true;
            this.lblAttributes.Location = new System.Drawing.Point(304, 32);
            this.lblAttributes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAttributes.Name = "lblAttributes";
            this.lblAttributes.Size = new System.Drawing.Size(57, 13);
            this.lblAttributes.TabIndex = 5;
            this.lblAttributes.Tag = "Label_Attributes";
            this.lblAttributes.Text = "Attributes";
            // 
            // lblNuyen
            // 
            this.lblNuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNuyen.AutoSize = true;
            this.lblNuyen.Location = new System.Drawing.Point(703, 57);
            this.lblNuyen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNuyen.Name = "lblNuyen";
            this.lblNuyen.Size = new System.Drawing.Size(41, 13);
            this.lblNuyen.TabIndex = 16;
            this.lblNuyen.Tag = "Label_Nuyen";
            this.lblNuyen.Text = "Nuyen:";
            // 
            // chkArmorEquipped
            // 
            this.chkArmorEquipped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkArmorEquipped.AutoSize = true;
            this.tlpArmor.SetColumnSpan(this.chkArmorEquipped, 2);
            this.chkArmorEquipped.Enabled = false;
            this.chkArmorEquipped.Location = new System.Drawing.Point(448, 138);
            this.chkArmorEquipped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkArmorEquipped.Name = "chkArmorEquipped";
            this.chkArmorEquipped.Size = new System.Drawing.Size(1, 17);
            this.chkArmorEquipped.TabIndex = 78;
            this.chkArmorEquipped.Tag = "Checkbox_Equipped";
            this.chkArmorEquipped.Text = "Equipped";
            this.chkArmorEquipped.UseVisualStyleBackColor = true;
            this.chkArmorEquipped.CheckedChanged += new System.EventHandler(this.chkArmorEquipped_CheckedChanged);
            // 
            // chkWeaponAccessoryInstalled
            // 
            this.chkWeaponAccessoryInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWeaponAccessoryInstalled.AutoSize = true;
            this.tlpWeapons.SetColumnSpan(this.chkWeaponAccessoryInstalled, 2);
            this.chkWeaponAccessoryInstalled.Enabled = false;
            this.chkWeaponAccessoryInstalled.Location = new System.Drawing.Point(564, 183);
            this.chkWeaponAccessoryInstalled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkWeaponAccessoryInstalled.Name = "chkWeaponAccessoryInstalled";
            this.chkWeaponAccessoryInstalled.Size = new System.Drawing.Size(248, 17);
            this.chkWeaponAccessoryInstalled.TabIndex = 72;
            this.chkWeaponAccessoryInstalled.Tag = "Checkbox_Installed";
            this.chkWeaponAccessoryInstalled.Text = "Installed";
            this.chkWeaponAccessoryInstalled.UseVisualStyleBackColor = true;
            this.chkWeaponAccessoryInstalled.CheckedChanged += new System.EventHandler(this.chkWeaponAccessoryInstalled_CheckedChanged);
            // 
            // chkVehicleWeaponAccessoryInstalled
            // 
            this.chkVehicleWeaponAccessoryInstalled.AutoSize = true;
            this.tlpVehicles.SetColumnSpan(this.chkVehicleWeaponAccessoryInstalled, 2);
            this.chkVehicleWeaponAccessoryInstalled.Enabled = false;
            this.chkVehicleWeaponAccessoryInstalled.Location = new System.Drawing.Point(703, 235);
            this.chkVehicleWeaponAccessoryInstalled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkVehicleWeaponAccessoryInstalled.Name = "chkVehicleWeaponAccessoryInstalled";
            this.chkVehicleWeaponAccessoryInstalled.Size = new System.Drawing.Size(65, 17);
            this.chkVehicleWeaponAccessoryInstalled.TabIndex = 74;
            this.chkVehicleWeaponAccessoryInstalled.Tag = "Checkbox_Installed";
            this.chkVehicleWeaponAccessoryInstalled.Text = "Installed";
            this.chkVehicleWeaponAccessoryInstalled.UseVisualStyleBackColor = true;
            this.chkVehicleWeaponAccessoryInstalled.CheckedChanged += new System.EventHandler(this.chkVehicleWeaponAccessoryInstalled_CheckedChanged);
            // 
            // lblNotoriety
            // 
            this.lblNotoriety.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotoriety.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblNotoriety, 3);
            this.lblNotoriety.Location = new System.Drawing.Point(717, 110);
            this.lblNotoriety.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotoriety.Name = "lblNotoriety";
            this.lblNotoriety.Size = new System.Drawing.Size(52, 13);
            this.lblNotoriety.TabIndex = 84;
            this.lblNotoriety.Tag = "Label_Notoriety";
            this.lblNotoriety.Text = "Notoriety:";
            // 
            // lblStreetCred
            // 
            this.lblStreetCred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreetCred.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblStreetCred, 3);
            this.lblStreetCred.Location = new System.Drawing.Point(706, 85);
            this.lblStreetCred.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblStreetCred.Name = "lblStreetCred";
            this.lblStreetCred.Size = new System.Drawing.Size(63, 13);
            this.lblStreetCred.TabIndex = 82;
            this.lblStreetCred.Tag = "Label_StreetCred";
            this.lblStreetCred.Text = "Street Cred:";
            // 
            // chkCharacterCreated
            // 
            this.chkCharacterCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCharacterCreated.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.chkCharacterCreated, 3);
            this.chkCharacterCreated.Location = new System.Drawing.Point(667, 4);
            this.chkCharacterCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCharacterCreated.Name = "chkCharacterCreated";
            this.chkCharacterCreated.Size = new System.Drawing.Size(165, 18);
            this.chkCharacterCreated.TabIndex = 62;
            this.chkCharacterCreated.Tag = "Checkbox_Created";
            this.chkCharacterCreated.Text = "Mark character as Created";
            this.chkCharacterCreated.UseVisualStyleBackColor = true;
            // 
            // lblBuildFoci
            // 
            this.lblBuildFoci.AutoSize = true;
            this.lblBuildFoci.Location = new System.Drawing.Point(3, 356);
            this.lblBuildFoci.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildFoci.Name = "lblBuildFoci";
            this.lblBuildFoci.Size = new System.Drawing.Size(27, 13);
            this.lblBuildFoci.TabIndex = 81;
            this.lblBuildFoci.Tag = "Label_SummaryFoci";
            this.lblBuildFoci.Text = "Foci";
            // 
            // lblBuildMartialArts
            // 
            this.lblBuildMartialArts.AutoSize = true;
            this.lblBuildMartialArts.Location = new System.Drawing.Point(3, 481);
            this.lblBuildMartialArts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildMartialArts.Name = "lblBuildMartialArts";
            this.lblBuildMartialArts.Size = new System.Drawing.Size(59, 13);
            this.lblBuildMartialArts.TabIndex = 79;
            this.lblBuildMartialArts.Tag = "Tab_MartialArts";
            this.lblBuildMartialArts.Text = "Martial Arts";
            // 
            // lblBuildNuyen
            // 
            this.lblBuildNuyen.AutoSize = true;
            this.lblBuildNuyen.Location = new System.Drawing.Point(3, 181);
            this.lblBuildNuyen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildNuyen.Name = "lblBuildNuyen";
            this.lblBuildNuyen.Size = new System.Drawing.Size(38, 13);
            this.lblBuildNuyen.TabIndex = 76;
            this.lblBuildNuyen.Tag = "Label_SummaryNuyen";
            this.lblBuildNuyen.Text = "Nuyen";
            // 
            // lblBuildEnemies
            // 
            this.lblBuildEnemies.AutoSize = true;
            this.lblBuildEnemies.Location = new System.Drawing.Point(3, 156);
            this.lblBuildEnemies.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildEnemies.Name = "lblBuildEnemies";
            this.lblBuildEnemies.Size = new System.Drawing.Size(47, 13);
            this.lblBuildEnemies.TabIndex = 75;
            this.lblBuildEnemies.Tag = "Label_SummaryEnemies";
            this.lblBuildEnemies.Text = "Enemies";
            // 
            // lblBuildComplexForms
            // 
            this.lblBuildComplexForms.AutoSize = true;
            this.lblBuildComplexForms.Location = new System.Drawing.Point(3, 431);
            this.lblBuildComplexForms.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildComplexForms.Name = "lblBuildComplexForms";
            this.lblBuildComplexForms.Size = new System.Drawing.Size(78, 13);
            this.lblBuildComplexForms.TabIndex = 72;
            this.lblBuildComplexForms.Tag = "Label_SummaryComplexForms";
            this.lblBuildComplexForms.Text = "Complex Forms";
            // 
            // lblBuildSprites
            // 
            this.lblBuildSprites.AutoSize = true;
            this.lblBuildSprites.Location = new System.Drawing.Point(3, 406);
            this.lblBuildSprites.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildSprites.Name = "lblBuildSprites";
            this.lblBuildSprites.Size = new System.Drawing.Size(39, 13);
            this.lblBuildSprites.TabIndex = 71;
            this.lblBuildSprites.Tag = "Label_SummarySprites";
            this.lblBuildSprites.Text = "Sprites";
            // 
            // lblBuildSpirits
            // 
            this.lblBuildSpirits.AutoSize = true;
            this.lblBuildSpirits.Location = new System.Drawing.Point(3, 381);
            this.lblBuildSpirits.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildSpirits.Name = "lblBuildSpirits";
            this.lblBuildSpirits.Size = new System.Drawing.Size(35, 13);
            this.lblBuildSpirits.TabIndex = 70;
            this.lblBuildSpirits.Tag = "Label_SummarySpirits";
            this.lblBuildSpirits.Text = "Spirits";
            // 
            // lblBuildSpells
            // 
            this.lblBuildSpells.AutoSize = true;
            this.lblBuildSpells.Location = new System.Drawing.Point(3, 281);
            this.lblBuildSpells.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildSpells.Name = "lblBuildSpells";
            this.lblBuildSpells.Size = new System.Drawing.Size(35, 13);
            this.lblBuildSpells.TabIndex = 69;
            this.lblBuildSpells.Tag = "Label_SummarySpells";
            this.lblBuildSpells.Text = "Spells";
            // 
            // lblBuildKnowledgeSkills
            // 
            this.lblBuildKnowledgeSkills.AutoSize = true;
            this.lblBuildKnowledgeSkills.Location = new System.Drawing.Point(3, 256);
            this.lblBuildKnowledgeSkills.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildKnowledgeSkills.Name = "lblBuildKnowledgeSkills";
            this.lblBuildKnowledgeSkills.Size = new System.Drawing.Size(87, 13);
            this.lblBuildKnowledgeSkills.TabIndex = 64;
            this.lblBuildKnowledgeSkills.Tag = "Label_SummaryKnowledgeSkills";
            this.lblBuildKnowledgeSkills.Text = "Knowledge Skills";
            // 
            // lblBuildActiveSkills
            // 
            this.lblBuildActiveSkills.AutoSize = true;
            this.lblBuildActiveSkills.Location = new System.Drawing.Point(3, 231);
            this.lblBuildActiveSkills.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildActiveSkills.Name = "lblBuildActiveSkills";
            this.lblBuildActiveSkills.Size = new System.Drawing.Size(64, 13);
            this.lblBuildActiveSkills.TabIndex = 63;
            this.lblBuildActiveSkills.Tag = "Label_SummaryActiveSkills";
            this.lblBuildActiveSkills.Text = "Active Skills";
            // 
            // lblBuildSkillGroups
            // 
            this.lblBuildSkillGroups.AutoSize = true;
            this.lblBuildSkillGroups.Location = new System.Drawing.Point(3, 206);
            this.lblBuildSkillGroups.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildSkillGroups.Name = "lblBuildSkillGroups";
            this.lblBuildSkillGroups.Size = new System.Drawing.Size(63, 13);
            this.lblBuildSkillGroups.TabIndex = 62;
            this.lblBuildSkillGroups.Tag = "Label_SummarySkillGroups";
            this.lblBuildSkillGroups.Text = "Skill Groups";
            // 
            // lblBuildContacts
            // 
            this.lblBuildContacts.AutoSize = true;
            this.lblBuildContacts.Location = new System.Drawing.Point(3, 131);
            this.lblBuildContacts.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildContacts.Name = "lblBuildContacts";
            this.lblBuildContacts.Size = new System.Drawing.Size(49, 13);
            this.lblBuildContacts.TabIndex = 59;
            this.lblBuildContacts.Tag = "Label_SummaryContacts";
            this.lblBuildContacts.Text = "Contacts";
            // 
            // lblBuildPrimaryAttributes
            // 
            this.lblBuildPrimaryAttributes.AutoSize = true;
            this.lblBuildPrimaryAttributes.Location = new System.Drawing.Point(3, 31);
            this.lblBuildPrimaryAttributes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildPrimaryAttributes.Name = "lblBuildPrimaryAttributes";
            this.lblBuildPrimaryAttributes.Size = new System.Drawing.Size(51, 13);
            this.lblBuildPrimaryAttributes.TabIndex = 57;
            this.lblBuildPrimaryAttributes.Tag = "Label_Attributes";
            this.lblBuildPrimaryAttributes.Text = "Attributes";
            // 
            // lblBuildNegativeQualities
            // 
            this.lblBuildNegativeQualities.AutoSize = true;
            this.lblBuildNegativeQualities.Location = new System.Drawing.Point(3, 106);
            this.lblBuildNegativeQualities.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildNegativeQualities.Name = "lblBuildNegativeQualities";
            this.lblBuildNegativeQualities.Size = new System.Drawing.Size(93, 13);
            this.lblBuildNegativeQualities.TabIndex = 54;
            this.lblBuildNegativeQualities.Tag = "Label_SummaryNegativeQualities";
            this.lblBuildNegativeQualities.Text = "Negative Qualities";
            // 
            // lblBuildPositiveQualities
            // 
            this.lblBuildPositiveQualities.AutoSize = true;
            this.lblBuildPositiveQualities.Location = new System.Drawing.Point(3, 81);
            this.lblBuildPositiveQualities.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildPositiveQualities.Name = "lblBuildPositiveQualities";
            this.lblBuildPositiveQualities.Size = new System.Drawing.Size(87, 13);
            this.lblBuildPositiveQualities.TabIndex = 50;
            this.lblBuildPositiveQualities.Tag = "Label_SummaryPositiveQualities";
            this.lblBuildPositiveQualities.Text = "Positive Qualities";
            // 
            // lblRiggingINILabel
            // 
            this.lblRiggingINILabel.AutoSize = true;
            this.lblRiggingINILabel.Location = new System.Drawing.Point(3, 181);
            this.lblRiggingINILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRiggingINILabel.Name = "lblRiggingINILabel";
            this.lblRiggingINILabel.Size = new System.Drawing.Size(112, 13);
            this.lblRiggingINILabel.TabIndex = 75;
            this.lblRiggingINILabel.Tag = "Label_OtherRiggingInit";
            this.lblRiggingINILabel.Text = "Rigging Initiative (AR):";
            // 
            // lblMatrixINIHotLabel
            // 
            this.lblMatrixINIHotLabel.AutoSize = true;
            this.lblMatrixINIHotLabel.Location = new System.Drawing.Point(3, 156);
            this.lblMatrixINIHotLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINIHotLabel.Name = "lblMatrixINIHotLabel";
            this.lblMatrixINIHotLabel.Size = new System.Drawing.Size(106, 13);
            this.lblMatrixINIHotLabel.TabIndex = 73;
            this.lblMatrixINIHotLabel.Tag = "Label_OtherMatrixInitVRHot";
            this.lblMatrixINIHotLabel.Text = "Matrix Initiative (Hot):";
            // 
            // lblMatrixINIColdLabel
            // 
            this.lblMatrixINIColdLabel.AutoSize = true;
            this.lblMatrixINIColdLabel.Location = new System.Drawing.Point(3, 131);
            this.lblMatrixINIColdLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINIColdLabel.Name = "lblMatrixINIColdLabel";
            this.lblMatrixINIColdLabel.Size = new System.Drawing.Size(110, 13);
            this.lblMatrixINIColdLabel.TabIndex = 71;
            this.lblMatrixINIColdLabel.Tag = "Label_OtherMatrixInitVRCold";
            this.lblMatrixINIColdLabel.Text = "Matrix Initiative (Cold):";
            // 
            // lblMemoryLabel
            // 
            this.lblMemoryLabel.AutoSize = true;
            this.lblMemoryLabel.Location = new System.Drawing.Point(3, 356);
            this.lblMemoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMemoryLabel.Name = "lblMemoryLabel";
            this.lblMemoryLabel.Size = new System.Drawing.Size(47, 13);
            this.lblMemoryLabel.TabIndex = 50;
            this.lblMemoryLabel.Tag = "Label_OtherMemory";
            this.lblMemoryLabel.Text = "Memory:";
            // 
            // lblLiftCarryLabel
            // 
            this.lblLiftCarryLabel.AutoSize = true;
            this.lblLiftCarryLabel.Location = new System.Drawing.Point(3, 331);
            this.lblLiftCarryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLiftCarryLabel.Name = "lblLiftCarryLabel";
            this.lblLiftCarryLabel.Size = new System.Drawing.Size(72, 13);
            this.lblLiftCarryLabel.TabIndex = 48;
            this.lblLiftCarryLabel.Tag = "Label_OtherLiftAndCarry";
            this.lblLiftCarryLabel.Text = "Lift and Carry:";
            // 
            // lblJudgeIntentionsLabel
            // 
            this.lblJudgeIntentionsLabel.AutoSize = true;
            this.lblJudgeIntentionsLabel.Location = new System.Drawing.Point(3, 306);
            this.lblJudgeIntentionsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblJudgeIntentionsLabel.Name = "lblJudgeIntentionsLabel";
            this.lblJudgeIntentionsLabel.Size = new System.Drawing.Size(88, 13);
            this.lblJudgeIntentionsLabel.TabIndex = 46;
            this.lblJudgeIntentionsLabel.Tag = "Label_OtherJudgeIntention";
            this.lblJudgeIntentionsLabel.Text = "Judge Intentions:";
            // 
            // lblComposureLabel
            // 
            this.lblComposureLabel.AutoSize = true;
            this.lblComposureLabel.Location = new System.Drawing.Point(3, 281);
            this.lblComposureLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComposureLabel.Name = "lblComposureLabel";
            this.lblComposureLabel.Size = new System.Drawing.Size(63, 13);
            this.lblComposureLabel.TabIndex = 44;
            this.lblComposureLabel.Tag = "Label_OtherCmposure";
            this.lblComposureLabel.Text = "Composure:";
            // 
            // lblRemainingNuyenLabel
            // 
            this.lblRemainingNuyenLabel.AutoSize = true;
            this.lblRemainingNuyenLabel.Location = new System.Drawing.Point(3, 256);
            this.lblRemainingNuyenLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRemainingNuyenLabel.Name = "lblRemainingNuyenLabel";
            this.lblRemainingNuyenLabel.Size = new System.Drawing.Size(94, 13);
            this.lblRemainingNuyenLabel.TabIndex = 36;
            this.lblRemainingNuyenLabel.Tag = "Label_OtherNuyenRemain";
            this.lblRemainingNuyenLabel.Text = "Nuyen Remaining:";
            // 
            // lblESS
            // 
            this.lblESS.AutoSize = true;
            this.lblESS.Location = new System.Drawing.Point(3, 231);
            this.lblESS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblESS.Name = "lblESS";
            this.lblESS.Size = new System.Drawing.Size(51, 13);
            this.lblESS.TabIndex = 34;
            this.lblESS.Tag = "Label_OtherEssence";
            this.lblESS.Text = "Essence:";
            // 
            // lblArmorLabel
            // 
            this.lblArmorLabel.AutoSize = true;
            this.lblArmorLabel.Location = new System.Drawing.Point(3, 206);
            this.lblArmorLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorLabel.Name = "lblArmorLabel";
            this.lblArmorLabel.Size = new System.Drawing.Size(37, 13);
            this.lblArmorLabel.TabIndex = 70;
            this.lblArmorLabel.Tag = "Label_ArmorValueShort";
            this.lblArmorLabel.Text = "Armor:";
            // 
            // lblAstralINILabel
            // 
            this.lblAstralINILabel.AutoSize = true;
            this.lblAstralINILabel.Location = new System.Drawing.Point(3, 81);
            this.lblAstralINILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAstralINILabel.Name = "lblAstralINILabel";
            this.lblAstralINILabel.Size = new System.Drawing.Size(78, 13);
            this.lblAstralINILabel.TabIndex = 23;
            this.lblAstralINILabel.Tag = "Label_OtherAstralInit";
            this.lblAstralINILabel.Text = "Astral Initiative:";
            // 
            // lblMatrixINILabel
            // 
            this.lblMatrixINILabel.AutoSize = true;
            this.lblMatrixINILabel.Location = new System.Drawing.Point(3, 106);
            this.lblMatrixINILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINILabel.Name = "lblMatrixINILabel";
            this.lblMatrixINILabel.Size = new System.Drawing.Size(104, 13);
            this.lblMatrixINILabel.TabIndex = 22;
            this.lblMatrixINILabel.Tag = "Label_OtherMatrixInit";
            this.lblMatrixINILabel.Text = "Matrix Initiative (AR):";
            // 
            // lblINILabel
            // 
            this.lblINILabel.AutoSize = true;
            this.lblINILabel.Location = new System.Drawing.Point(3, 56);
            this.lblINILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINILabel.Name = "lblINILabel";
            this.lblINILabel.Size = new System.Drawing.Size(49, 13);
            this.lblINILabel.TabIndex = 20;
            this.lblINILabel.Tag = "Label_OtherInit";
            this.lblINILabel.Text = "Initiative:";
            // 
            // lblCMStunLabel
            // 
            this.lblCMStunLabel.AutoSize = true;
            this.lblCMStunLabel.Location = new System.Drawing.Point(3, 31);
            this.lblCMStunLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCMStunLabel.Name = "lblCMStunLabel";
            this.lblCMStunLabel.Size = new System.Drawing.Size(110, 13);
            this.lblCMStunLabel.TabIndex = 19;
            this.lblCMStunLabel.Tag = "Label_OtherStunCM";
            this.lblCMStunLabel.Text = "Stun Condition Track:";
            // 
            // lblCMPhysicalLabel
            // 
            this.lblCMPhysicalLabel.AutoSize = true;
            this.lblCMPhysicalLabel.Location = new System.Drawing.Point(3, 6);
            this.lblCMPhysicalLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCMPhysicalLabel.Name = "lblCMPhysicalLabel";
            this.lblCMPhysicalLabel.Size = new System.Drawing.Size(127, 13);
            this.lblCMPhysicalLabel.TabIndex = 18;
            this.lblCMPhysicalLabel.Tag = "Label_OtherPhysicalCM";
            this.lblCMPhysicalLabel.Text = "Physical Condition Track:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 402);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 108;
            this.label33.Tag = "Label_Spirits";
            this.label33.Text = "Spirits";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 92;
            this.label7.Tag = "String_Karma";
            this.label7.Text = "Karma";
            // 
            // lblSpellDefenceIndirectDodgeLabel
            // 
            this.lblSpellDefenceIndirectDodgeLabel.AutoSize = true;
            this.lblSpellDefenceIndirectDodgeLabel.Location = new System.Drawing.Point(3, 32);
            this.lblSpellDefenceIndirectDodgeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIndirectDodgeLabel.Name = "lblSpellDefenceIndirectDodgeLabel";
            this.lblSpellDefenceIndirectDodgeLabel.Size = new System.Drawing.Size(77, 13);
            this.lblSpellDefenceIndirectDodgeLabel.TabIndex = 25;
            this.lblSpellDefenceIndirectDodgeLabel.Tag = "Label_SpellDefenceIndirectDodge";
            this.lblSpellDefenceIndirectDodgeLabel.Text = "Indirect Dodge";
            // 
            // lblSpellDefenceIndirectSoakLabel
            // 
            this.lblSpellDefenceIndirectSoakLabel.AutoSize = true;
            this.lblSpellDefenceIndirectSoakLabel.Location = new System.Drawing.Point(3, 57);
            this.lblSpellDefenceIndirectSoakLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIndirectSoakLabel.Name = "lblSpellDefenceIndirectSoakLabel";
            this.lblSpellDefenceIndirectSoakLabel.Size = new System.Drawing.Size(70, 13);
            this.lblSpellDefenceIndirectSoakLabel.TabIndex = 27;
            this.lblSpellDefenceIndirectSoakLabel.Tag = "Label_SpellDefenceIndirect";
            this.lblSpellDefenceIndirectSoakLabel.Text = "Indirect Soak";
            // 
            // lblSpellDefenceDirectSoakManaLabel
            // 
            this.lblSpellDefenceDirectSoakManaLabel.AutoSize = true;
            this.lblSpellDefenceDirectSoakManaLabel.Location = new System.Drawing.Point(3, 82);
            this.lblSpellDefenceDirectSoakManaLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDirectSoakManaLabel.Name = "lblSpellDefenceDirectSoakManaLabel";
            this.lblSpellDefenceDirectSoakManaLabel.Size = new System.Drawing.Size(99, 13);
            this.lblSpellDefenceDirectSoakManaLabel.TabIndex = 29;
            this.lblSpellDefenceDirectSoakManaLabel.Tag = "Label_SpellDefenceDirectSoakMana";
            this.lblSpellDefenceDirectSoakManaLabel.Text = "Direct Soak - Mana";
            // 
            // lblSpellDefenceDirectSoakPhysicalLabel
            // 
            this.lblSpellDefenceDirectSoakPhysicalLabel.AutoSize = true;
            this.lblSpellDefenceDirectSoakPhysicalLabel.Location = new System.Drawing.Point(3, 107);
            this.lblSpellDefenceDirectSoakPhysicalLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDirectSoakPhysicalLabel.Name = "lblSpellDefenceDirectSoakPhysicalLabel";
            this.lblSpellDefenceDirectSoakPhysicalLabel.Size = new System.Drawing.Size(111, 13);
            this.lblSpellDefenceDirectSoakPhysicalLabel.TabIndex = 31;
            this.lblSpellDefenceDirectSoakPhysicalLabel.Tag = "Label_SpellDefenceDirectSoakPhysical";
            this.lblSpellDefenceDirectSoakPhysicalLabel.Text = "Direct Soak - Physical";
            // 
            // lblSpellDefenceDecAttBODLabel
            // 
            this.lblSpellDefenceDecAttBODLabel.AutoSize = true;
            this.lblSpellDefenceDecAttBODLabel.Location = new System.Drawing.Point(3, 157);
            this.lblSpellDefenceDecAttBODLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttBODLabel.Name = "lblSpellDefenceDecAttBODLabel";
            this.lblSpellDefenceDecAttBODLabel.Size = new System.Drawing.Size(127, 13);
            this.lblSpellDefenceDecAttBODLabel.TabIndex = 35;
            this.lblSpellDefenceDecAttBODLabel.Tag = "Label_SpellDefenceDecAttBOD";
            this.lblSpellDefenceDecAttBODLabel.Text = "Decrease Attribute (BOD)";
            // 
            // lblSpellDefenceDetectionLabel
            // 
            this.lblSpellDefenceDetectionLabel.AutoSize = true;
            this.lblSpellDefenceDetectionLabel.Location = new System.Drawing.Point(3, 132);
            this.lblSpellDefenceDetectionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDetectionLabel.Name = "lblSpellDefenceDetectionLabel";
            this.lblSpellDefenceDetectionLabel.Size = new System.Drawing.Size(84, 13);
            this.lblSpellDefenceDetectionLabel.TabIndex = 33;
            this.lblSpellDefenceDetectionLabel.Tag = "Label_SpellDefenceDetection";
            this.lblSpellDefenceDetectionLabel.Text = "Detection Spells";
            // 
            // lblSpellDefenceDecAttAGILabel
            // 
            this.lblSpellDefenceDecAttAGILabel.AutoSize = true;
            this.lblSpellDefenceDecAttAGILabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpellDefenceDecAttAGILabel.Location = new System.Drawing.Point(3, 182);
            this.lblSpellDefenceDecAttAGILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttAGILabel.Name = "lblSpellDefenceDecAttAGILabel";
            this.lblSpellDefenceDecAttAGILabel.Size = new System.Drawing.Size(139, 13);
            this.lblSpellDefenceDecAttAGILabel.TabIndex = 41;
            this.lblSpellDefenceDecAttAGILabel.Tag = "Label_SpellDefenceDecAttAGI";
            this.lblSpellDefenceDecAttAGILabel.Text = "Decrease Attribute (AGI)";
            // 
            // lblSpellDefenceDecAttSTRLabel
            // 
            this.lblSpellDefenceDecAttSTRLabel.AutoSize = true;
            this.lblSpellDefenceDecAttSTRLabel.Location = new System.Drawing.Point(3, 232);
            this.lblSpellDefenceDecAttSTRLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttSTRLabel.Name = "lblSpellDefenceDecAttSTRLabel";
            this.lblSpellDefenceDecAttSTRLabel.Size = new System.Drawing.Size(126, 13);
            this.lblSpellDefenceDecAttSTRLabel.TabIndex = 43;
            this.lblSpellDefenceDecAttSTRLabel.Tag = "Label_SpellDefenceDecAttSTR";
            this.lblSpellDefenceDecAttSTRLabel.Text = "Decrease Attribute (STR)";
            // 
            // lblSpellDefenceDecAttREALabel
            // 
            this.lblSpellDefenceDecAttREALabel.AutoSize = true;
            this.lblSpellDefenceDecAttREALabel.Location = new System.Drawing.Point(3, 207);
            this.lblSpellDefenceDecAttREALabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttREALabel.Name = "lblSpellDefenceDecAttREALabel";
            this.lblSpellDefenceDecAttREALabel.Size = new System.Drawing.Size(126, 13);
            this.lblSpellDefenceDecAttREALabel.TabIndex = 42;
            this.lblSpellDefenceDecAttREALabel.Tag = "Label_SpellDefenceDecAttREA";
            this.lblSpellDefenceDecAttREALabel.Text = "Decrease Attribute (REA)";
            // 
            // lblSpellDefenceDecAttWILLabel
            // 
            this.lblSpellDefenceDecAttWILLabel.AutoSize = true;
            this.lblSpellDefenceDecAttWILLabel.Location = new System.Drawing.Point(3, 332);
            this.lblSpellDefenceDecAttWILLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttWILLabel.Name = "lblSpellDefenceDecAttWILLabel";
            this.lblSpellDefenceDecAttWILLabel.Size = new System.Drawing.Size(124, 13);
            this.lblSpellDefenceDecAttWILLabel.TabIndex = 47;
            this.lblSpellDefenceDecAttWILLabel.Tag = "Label_SpellDefenceDecAttWIL";
            this.lblSpellDefenceDecAttWILLabel.Text = "Decrease Attribute (WIL)";
            // 
            // lblSpellDefenceDecAttLOGLabel
            // 
            this.lblSpellDefenceDecAttLOGLabel.AutoSize = true;
            this.lblSpellDefenceDecAttLOGLabel.Location = new System.Drawing.Point(3, 307);
            this.lblSpellDefenceDecAttLOGLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttLOGLabel.Name = "lblSpellDefenceDecAttLOGLabel";
            this.lblSpellDefenceDecAttLOGLabel.Size = new System.Drawing.Size(126, 13);
            this.lblSpellDefenceDecAttLOGLabel.TabIndex = 46;
            this.lblSpellDefenceDecAttLOGLabel.Tag = "Label_SpellDefenceDecAttLOG";
            this.lblSpellDefenceDecAttLOGLabel.Text = "Decrease Attribute (LOG)";
            // 
            // lblSpellDefenceDecAttINTLabel
            // 
            this.lblSpellDefenceDecAttINTLabel.AutoSize = true;
            this.lblSpellDefenceDecAttINTLabel.Location = new System.Drawing.Point(3, 282);
            this.lblSpellDefenceDecAttINTLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttINTLabel.Name = "lblSpellDefenceDecAttINTLabel";
            this.lblSpellDefenceDecAttINTLabel.Size = new System.Drawing.Size(122, 13);
            this.lblSpellDefenceDecAttINTLabel.TabIndex = 45;
            this.lblSpellDefenceDecAttINTLabel.Tag = "Label_SpellDefenceDecAttINT";
            this.lblSpellDefenceDecAttINTLabel.Text = "Decrease Attribute (INT)";
            // 
            // lblSpellDefenceDecAttCHALabel
            // 
            this.lblSpellDefenceDecAttCHALabel.AutoSize = true;
            this.lblSpellDefenceDecAttCHALabel.Location = new System.Drawing.Point(3, 257);
            this.lblSpellDefenceDecAttCHALabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttCHALabel.Name = "lblSpellDefenceDecAttCHALabel";
            this.lblSpellDefenceDecAttCHALabel.Size = new System.Drawing.Size(126, 13);
            this.lblSpellDefenceDecAttCHALabel.TabIndex = 44;
            this.lblSpellDefenceDecAttCHALabel.Tag = "Label_SpellDefenceDecAttCHA";
            this.lblSpellDefenceDecAttCHALabel.Text = "Decrease Attribute (CHA)";
            // 
            // lblSpellDefenceManipPhysicalLabel
            // 
            this.lblSpellDefenceManipPhysicalLabel.AutoSize = true;
            this.lblSpellDefenceManipPhysicalLabel.Location = new System.Drawing.Point(3, 432);
            this.lblSpellDefenceManipPhysicalLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceManipPhysicalLabel.Name = "lblSpellDefenceManipPhysicalLabel";
            this.lblSpellDefenceManipPhysicalLabel.Size = new System.Drawing.Size(115, 13);
            this.lblSpellDefenceManipPhysicalLabel.TabIndex = 59;
            this.lblSpellDefenceManipPhysicalLabel.Tag = "Label_SpellDefenceManipPhysical";
            this.lblSpellDefenceManipPhysicalLabel.Text = "Manipulation - Physical";
            // 
            // lblSpellDefenceManipMentalLabel
            // 
            this.lblSpellDefenceManipMentalLabel.AutoSize = true;
            this.lblSpellDefenceManipMentalLabel.Location = new System.Drawing.Point(3, 407);
            this.lblSpellDefenceManipMentalLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceManipMentalLabel.Name = "lblSpellDefenceManipMentalLabel";
            this.lblSpellDefenceManipMentalLabel.Size = new System.Drawing.Size(108, 13);
            this.lblSpellDefenceManipMentalLabel.TabIndex = 57;
            this.lblSpellDefenceManipMentalLabel.Tag = "Label_SpellDefenceManipMental";
            this.lblSpellDefenceManipMentalLabel.Text = "Manipulation - Mental";
            // 
            // lblSpellDefenceIllusionPhysicalLabel
            // 
            this.lblSpellDefenceIllusionPhysicalLabel.AutoSize = true;
            this.lblSpellDefenceIllusionPhysicalLabel.Location = new System.Drawing.Point(3, 382);
            this.lblSpellDefenceIllusionPhysicalLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIllusionPhysicalLabel.Name = "lblSpellDefenceIllusionPhysicalLabel";
            this.lblSpellDefenceIllusionPhysicalLabel.Size = new System.Drawing.Size(87, 13);
            this.lblSpellDefenceIllusionPhysicalLabel.TabIndex = 55;
            this.lblSpellDefenceIllusionPhysicalLabel.Tag = "Label_SpellDefenceIllusionPhysical";
            this.lblSpellDefenceIllusionPhysicalLabel.Text = "Illusion - Physical";
            // 
            // lblSpellDefenceIllusionManaLabel
            // 
            this.lblSpellDefenceIllusionManaLabel.AutoSize = true;
            this.lblSpellDefenceIllusionManaLabel.Location = new System.Drawing.Point(3, 357);
            this.lblSpellDefenceIllusionManaLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIllusionManaLabel.Name = "lblSpellDefenceIllusionManaLabel";
            this.lblSpellDefenceIllusionManaLabel.Size = new System.Drawing.Size(75, 13);
            this.lblSpellDefenceIllusionManaLabel.TabIndex = 53;
            this.lblSpellDefenceIllusionManaLabel.Tag = "Label_SpellDefenceIllusionMana";
            this.lblSpellDefenceIllusionManaLabel.Text = "Illusion - Mana";
            // 
            // lblCounterspellingDiceLabel
            // 
            this.lblCounterspellingDiceLabel.AutoSize = true;
            this.lblCounterspellingDiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterspellingDiceLabel.Location = new System.Drawing.Point(3, 6);
            this.lblCounterspellingDiceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCounterspellingDiceLabel.Name = "lblCounterspellingDiceLabel";
            this.lblCounterspellingDiceLabel.Size = new System.Drawing.Size(104, 13);
            this.lblCounterspellingDiceLabel.TabIndex = 62;
            this.lblCounterspellingDiceLabel.Tag = "Label_CounterspellingDice";
            this.lblCounterspellingDiceLabel.Text = "Counterspelling Dice";
            // 
            // lblFoci
            // 
            this.lblFoci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFoci.AutoSize = true;
            this.lblFoci.Location = new System.Drawing.Point(304, 289);
            this.lblFoci.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFoci.Name = "lblFoci";
            this.lblFoci.Size = new System.Drawing.Size(67, 13);
            this.lblFoci.TabIndex = 92;
            this.lblFoci.Tag = "Label_BondedFoci";
            this.lblFoci.Text = "Bonded Foci";
            // 
            // lblBuildAIAdvancedPrograms
            // 
            this.lblBuildAIAdvancedPrograms.AutoSize = true;
            this.lblBuildAIAdvancedPrograms.Location = new System.Drawing.Point(3, 531);
            this.lblBuildAIAdvancedPrograms.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildAIAdvancedPrograms.Name = "lblBuildAIAdvancedPrograms";
            this.lblBuildAIAdvancedPrograms.Size = new System.Drawing.Size(103, 13);
            this.lblBuildAIAdvancedPrograms.TabIndex = 87;
            this.lblBuildAIAdvancedPrograms.Tag = "Label_SummaryAIAdvancedPrograms";
            this.lblBuildAIAdvancedPrograms.Text = "Advanced Programs";
            // 
            // lblBuildRitualsBPLabel
            // 
            this.lblBuildRitualsBPLabel.AutoSize = true;
            this.lblBuildRitualsBPLabel.Location = new System.Drawing.Point(3, 331);
            this.lblBuildRitualsBPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildRitualsBPLabel.Name = "lblBuildRitualsBPLabel";
            this.lblBuildRitualsBPLabel.Size = new System.Drawing.Size(39, 13);
            this.lblBuildRitualsBPLabel.TabIndex = 133;
            this.lblBuildRitualsBPLabel.Tag = "Label_SummaryRituals";
            this.lblBuildRitualsBPLabel.Text = "Rituals";
            // 
            // lblBuildPrepsBPLabel
            // 
            this.lblBuildPrepsBPLabel.AutoSize = true;
            this.lblBuildPrepsBPLabel.Location = new System.Drawing.Point(3, 306);
            this.lblBuildPrepsBPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildPrepsBPLabel.Name = "lblBuildPrepsBPLabel";
            this.lblBuildPrepsBPLabel.Size = new System.Drawing.Size(66, 13);
            this.lblBuildPrepsBPLabel.TabIndex = 131;
            this.lblBuildPrepsBPLabel.Tag = "Label_SummaryPreparations";
            this.lblBuildPrepsBPLabel.Text = "Preparations";
            // 
            // lblPublicAware
            // 
            this.lblPublicAware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublicAware.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblPublicAware, 3);
            this.lblPublicAware.Location = new System.Drawing.Point(675, 135);
            this.lblPublicAware.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPublicAware.Name = "lblPublicAware";
            this.lblPublicAware.Size = new System.Drawing.Size(94, 13);
            this.lblPublicAware.TabIndex = 86;
            this.lblPublicAware.Tag = "Label_PublicAwareness";
            this.lblPublicAware.Text = "Public Awareness:";
            // 
            // cmsMartialArts
            // 
            this.cmsMartialArts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMartialArtsAddAdvantage,
            this.tsMartialArtsNotes});
            this.cmsMartialArts.Name = "cmsWeapon";
            this.cmsMartialArts.Size = new System.Drawing.Size(155, 48);
            // 
            // tsMartialArtsAddAdvantage
            // 
            this.tsMartialArtsAddAdvantage.Image = global::Chummer.Properties.Resources.medal_gold_add;
            this.tsMartialArtsAddAdvantage.Name = "tsMartialArtsAddAdvantage";
            this.tsMartialArtsAddAdvantage.Size = new System.Drawing.Size(154, 22);
            this.tsMartialArtsAddAdvantage.Tag = "Menu_AddAdvantage";
            this.tsMartialArtsAddAdvantage.Text = "&Add Technique";
            this.tsMartialArtsAddAdvantage.Click += new System.EventHandler(this.tsMartialArtsAddAdvantage_Click);
            // 
            // tsMartialArtsNotes
            // 
            this.tsMartialArtsNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsMartialArtsNotes.Name = "tsMartialArtsNotes";
            this.tsMartialArtsNotes.Size = new System.Drawing.Size(154, 22);
            this.tsMartialArtsNotes.Tag = "Menu_Notes";
            this.tsMartialArtsNotes.Text = "&Notes";
            this.tsMartialArtsNotes.Click += new System.EventHandler(this.tsMartialArtsNotes_Click);
            // 
            // cmsSpellButton
            // 
            this.cmsSpellButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCreateSpell});
            this.cmsSpellButton.Name = "cmsSpellButton";
            this.cmsSpellButton.Size = new System.Drawing.Size(137, 26);
            // 
            // tsCreateSpell
            // 
            this.tsCreateSpell.Name = "tsCreateSpell";
            this.tsCreateSpell.Size = new System.Drawing.Size(136, 22);
            this.tsCreateSpell.Tag = "Menu_CreateSpell";
            this.tsCreateSpell.Text = "&Create Spell";
            this.tsCreateSpell.Visible = false;
            this.tsCreateSpell.Click += new System.EventHandler(this.tsCreateSpell_Click);
            // 
            // cmsComplexForm
            // 
            this.cmsComplexForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddComplexFormOption,
            this.tsComplexFormNotes});
            this.cmsComplexForm.Name = "cmsComplexForm";
            this.cmsComplexForm.Size = new System.Drawing.Size(137, 48);
            // 
            // tsAddComplexFormOption
            // 
            this.tsAddComplexFormOption.Enabled = false;
            this.tsAddComplexFormOption.Image = global::Chummer.Properties.Resources.plugin_add;
            this.tsAddComplexFormOption.Name = "tsAddComplexFormOption";
            this.tsAddComplexFormOption.Size = new System.Drawing.Size(136, 22);
            this.tsAddComplexFormOption.Tag = "Menu_AddOption";
            this.tsAddComplexFormOption.Text = "&Add Option";
            // 
            // tsComplexFormNotes
            // 
            this.tsComplexFormNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsComplexFormNotes.Name = "tsComplexFormNotes";
            this.tsComplexFormNotes.Size = new System.Drawing.Size(136, 22);
            this.tsComplexFormNotes.Tag = "Menu_Notes";
            this.tsComplexFormNotes.Text = "&Notes";
            this.tsComplexFormNotes.Click += new System.EventHandler(this.tsComplexFormNotes_Click);
            // 
            // cmsCyberware
            // 
            this.cmsCyberware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCyberwareAddAsPlugin,
            this.tsCyberwareAddGear,
            this.tsCyberwareNotes});
            this.cmsCyberware.Name = "cmsCyberware";
            this.cmsCyberware.Size = new System.Drawing.Size(148, 70);
            // 
            // tsCyberwareAddAsPlugin
            // 
            this.tsCyberwareAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsCyberwareAddAsPlugin.Name = "tsCyberwareAddAsPlugin";
            this.tsCyberwareAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsCyberwareAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsCyberwareAddAsPlugin.Text = "&Add as Plugin";
            this.tsCyberwareAddAsPlugin.Click += new System.EventHandler(this.tsCyberwareAddAsPlugin_Click);
            // 
            // tsCyberwareAddGear
            // 
            this.tsCyberwareAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsCyberwareAddGear.Name = "tsCyberwareAddGear";
            this.tsCyberwareAddGear.Size = new System.Drawing.Size(147, 22);
            this.tsCyberwareAddGear.Tag = "Menu_AddGear";
            this.tsCyberwareAddGear.Text = "Add &Gear";
            this.tsCyberwareAddGear.Click += new System.EventHandler(this.tsCyberwareAddGear_Click);
            // 
            // tsCyberwareNotes
            // 
            this.tsCyberwareNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsCyberwareNotes.Name = "tsCyberwareNotes";
            this.tsCyberwareNotes.Size = new System.Drawing.Size(147, 22);
            this.tsCyberwareNotes.Tag = "Menu_Notes";
            this.tsCyberwareNotes.Text = "&Notes";
            this.tsCyberwareNotes.Click += new System.EventHandler(this.tsCyberwareNotes_Click);
            // 
            // cmsVehicleCyberware
            // 
            this.cmsVehicleCyberware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleCyberwareAddAsPlugin,
            this.tsVehicleCyberwareAddGear,
            this.tsVehicleCyberwareNotes});
            this.cmsVehicleCyberware.Name = "cmsVehicleCyberware";
            this.cmsVehicleCyberware.Size = new System.Drawing.Size(148, 70);
            // 
            // tsVehicleCyberwareAddAsPlugin
            // 
            this.tsVehicleCyberwareAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleCyberwareAddAsPlugin.Name = "tsVehicleCyberwareAddAsPlugin";
            this.tsVehicleCyberwareAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleCyberwareAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsVehicleCyberwareAddAsPlugin.Text = "&Add as Plugin";
            this.tsVehicleCyberwareAddAsPlugin.Click += new System.EventHandler(this.tsVehicleCyberwareAddAsPlugin_Click);
            // 
            // tsVehicleCyberwareAddGear
            // 
            this.tsVehicleCyberwareAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsVehicleCyberwareAddGear.Name = "tsVehicleCyberwareAddGear";
            this.tsVehicleCyberwareAddGear.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleCyberwareAddGear.Tag = "Menu_AddGear";
            this.tsVehicleCyberwareAddGear.Text = "Add &Gear";
            this.tsVehicleCyberwareAddGear.Click += new System.EventHandler(this.tsVehicleCyberwareAddGear_Click);
            // 
            // tsVehicleCyberwareNotes
            // 
            this.tsVehicleCyberwareNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleCyberwareNotes.Name = "tsVehicleCyberwareNotes";
            this.tsVehicleCyberwareNotes.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleCyberwareNotes.Tag = "Menu_Notes";
            this.tsVehicleCyberwareNotes.Text = "&Notes";
            this.tsVehicleCyberwareNotes.Click += new System.EventHandler(this.tsVehicleNotes_Click);
            // 
            // cmsLifestyle
            // 
            this.cmsLifestyle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdvancedLifestyle});
            this.cmsLifestyle.Name = "cmsLifestyle";
            this.cmsLifestyle.Size = new System.Drawing.Size(174, 26);
            // 
            // tsAdvancedLifestyle
            // 
            this.tsAdvancedLifestyle.Image = global::Chummer.Properties.Resources.house;
            this.tsAdvancedLifestyle.Name = "tsAdvancedLifestyle";
            this.tsAdvancedLifestyle.Size = new System.Drawing.Size(173, 22);
            this.tsAdvancedLifestyle.Tag = "Menu_AdvancedLifestyle";
            this.tsAdvancedLifestyle.Text = "&Advanced Lifestyle";
            this.tsAdvancedLifestyle.Click += new System.EventHandler(this.tsAdvancedLifestyle_Click);
            // 
            // cmsArmor
            // 
            this.cmsArmor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddArmorMod,
            this.tsAddArmorGear,
            this.tsArmorName,
            this.tsArmorNotes});
            this.cmsArmor.Name = "cmsWeapon";
            this.cmsArmor.Size = new System.Drawing.Size(162, 92);
            // 
            // tsAddArmorMod
            // 
            this.tsAddArmorMod.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsAddArmorMod.Name = "tsAddArmorMod";
            this.tsAddArmorMod.Size = new System.Drawing.Size(161, 22);
            this.tsAddArmorMod.Tag = "Menu_AddArmorMod";
            this.tsAddArmorMod.Text = "&Add Armor Mod";
            this.tsAddArmorMod.Click += new System.EventHandler(this.tsAddArmorMod_Click);
            // 
            // tsAddArmorGear
            // 
            this.tsAddArmorGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsAddArmorGear.Name = "tsAddArmorGear";
            this.tsAddArmorGear.Size = new System.Drawing.Size(161, 22);
            this.tsAddArmorGear.Tag = "Menu_AddGear";
            this.tsAddArmorGear.Text = "A&dd Gear";
            this.tsAddArmorGear.Click += new System.EventHandler(this.tsAddArmorGear_Click);
            // 
            // tsArmorName
            // 
            this.tsArmorName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsArmorName.Name = "tsArmorName";
            this.tsArmorName.Size = new System.Drawing.Size(161, 22);
            this.tsArmorName.Tag = "Menu_NameArmor";
            this.tsArmorName.Text = "Name Armor";
            this.tsArmorName.Click += new System.EventHandler(this.tsArmorName_Click);
            // 
            // tsArmorNotes
            // 
            this.tsArmorNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsArmorNotes.Name = "tsArmorNotes";
            this.tsArmorNotes.Size = new System.Drawing.Size(161, 22);
            this.tsArmorNotes.Tag = "Menu_Notes";
            this.tsArmorNotes.Text = "&Notes";
            this.tsArmorNotes.Click += new System.EventHandler(this.tsArmorNotes_Click);
            // 
            // cmsWeapon
            // 
            this.cmsWeapon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCreateNaturalWeapon,
            this.tsWeaponAddAccessory,
            this.tsWeaponAddUnderbarrel,
            this.tsWeaponName,
            this.tsWeaponNotes});
            this.cmsWeapon.Name = "cmsWeapon";
            this.cmsWeapon.Size = new System.Drawing.Size(209, 114);
            // 
            // tsCreateNaturalWeapon
            // 
            this.tsCreateNaturalWeapon.Image = global::Chummer.Properties.Resources.bomb;
            this.tsCreateNaturalWeapon.Name = "tsCreateNaturalWeapon";
            this.tsCreateNaturalWeapon.Size = new System.Drawing.Size(208, 22);
            this.tsCreateNaturalWeapon.Tag = "Menu_AddNaturalWeapon";
            this.tsCreateNaturalWeapon.Text = "Create Natural Weapon";
            this.tsCreateNaturalWeapon.Click += new System.EventHandler(this.tsCreateNaturalWeapon_Click);
            // 
            // tsWeaponAddAccessory
            // 
            this.tsWeaponAddAccessory.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsWeaponAddAccessory.Name = "tsWeaponAddAccessory";
            this.tsWeaponAddAccessory.Size = new System.Drawing.Size(208, 22);
            this.tsWeaponAddAccessory.Tag = "Menu_AddAccessory";
            this.tsWeaponAddAccessory.Text = "&Add Accessory";
            this.tsWeaponAddAccessory.Click += new System.EventHandler(this.tsWeaponAddAccessory_Click);
            // 
            // tsWeaponAddUnderbarrel
            // 
            this.tsWeaponAddUnderbarrel.Image = global::Chummer.Properties.Resources.award_star2_add;
            this.tsWeaponAddUnderbarrel.Name = "tsWeaponAddUnderbarrel";
            this.tsWeaponAddUnderbarrel.Size = new System.Drawing.Size(208, 22);
            this.tsWeaponAddUnderbarrel.Tag = "Menu_AddUnderbarrelWeapon";
            this.tsWeaponAddUnderbarrel.Text = "Add Underbarrel Weapon";
            this.tsWeaponAddUnderbarrel.Click += new System.EventHandler(this.tsWeaponAddUnderbarrel_Click);
            // 
            // tsWeaponName
            // 
            this.tsWeaponName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsWeaponName.Name = "tsWeaponName";
            this.tsWeaponName.Size = new System.Drawing.Size(208, 22);
            this.tsWeaponName.Tag = "Menu_NameWeapon";
            this.tsWeaponName.Text = "Name &Weapon";
            this.tsWeaponName.Click += new System.EventHandler(this.tsWeaponName_Click);
            // 
            // tsWeaponNotes
            // 
            this.tsWeaponNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsWeaponNotes.Name = "tsWeaponNotes";
            this.tsWeaponNotes.Size = new System.Drawing.Size(208, 22);
            this.tsWeaponNotes.Tag = "Menu_Notes";
            this.tsWeaponNotes.Text = "&Notes";
            this.tsWeaponNotes.Click += new System.EventHandler(this.tsWeaponNotes_Click);
            // 
            // tsWeaponMountLocation
            // 
            this.tsWeaponMountLocation.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsWeaponMountLocation.Name = "tsWeaponMountLocation";
            this.tsWeaponMountLocation.Size = new System.Drawing.Size(180, 22);
            this.tsWeaponMountLocation.Tag = "Menu_RenameLocation";
            this.tsWeaponMountLocation.Text = "Rename &Location";
            this.tsWeaponMountLocation.Click += new System.EventHandler(this.tsWeaponMountLocation_Click);
            // 
            // lmtControl
            // 
            this.lmtControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lmtControl.Location = new System.Drawing.Point(3, 3);
            this.lmtControl.Name = "lmtControl";
            this.lmtControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lmtControl.Size = new System.Drawing.Size(835, 625);
            this.lmtControl.TabIndex = 0;
            // 
            // tsWeaponAddModification
            // 
            this.tsWeaponAddModification.Name = "tsWeaponAddModification";
            this.tsWeaponAddModification.Size = new System.Drawing.Size(32, 19);
            // 
            // cmsGearButton
            // 
            this.cmsGearButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGearButtonAddAccessory});
            this.cmsGearButton.Name = "cmsGearButton";
            this.cmsGearButton.Size = new System.Drawing.Size(153, 26);
            // 
            // tsGearButtonAddAccessory
            // 
            this.tsGearButtonAddAccessory.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsGearButtonAddAccessory.Name = "tsGearButtonAddAccessory";
            this.tsGearButtonAddAccessory.Size = new System.Drawing.Size(152, 22);
            this.tsGearButtonAddAccessory.Tag = "Menu_AddAccessory";
            this.tsGearButtonAddAccessory.Text = "&Add Accessory";
            this.tsGearButtonAddAccessory.Click += new System.EventHandler(this.tsGearButtonAddAccessory_Click);
            // 
            // cmsVehicle
            // 
            this.cmsVehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleAddWeapon,
            this.tsVehicleAddWeaponMount,
            this.tsVehicleAddMod,
            this.tsVehicleAddCyberware,
            this.tsVehicleAddSensor,
            this.tsVehicleName,
            this.tsVehicleNotes});
            this.cmsVehicle.Name = "cmsWeapon";
            this.cmsVehicle.Size = new System.Drawing.Size(193, 158);
            // 
            // tsVehicleAddWeapon
            // 
            this.tsVehicleAddWeapon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleAddWeaponWeapon,
            this.tsVehicleAddWeaponAccessory,
            this.tsVehicleAddUnderbarrelWeapon});
            this.tsVehicleAddWeapon.Image = global::Chummer.Properties.Resources.award_star_add;
            this.tsVehicleAddWeapon.Name = "tsVehicleAddWeapon";
            this.tsVehicleAddWeapon.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleAddWeapon.Tag = "Menu_Weapons";
            this.tsVehicleAddWeapon.Text = "&Weapons";
            // 
            // tsVehicleAddWeaponWeapon
            // 
            this.tsVehicleAddWeaponWeapon.Image = global::Chummer.Properties.Resources.award_star_add;
            this.tsVehicleAddWeaponWeapon.Name = "tsVehicleAddWeaponWeapon";
            this.tsVehicleAddWeaponWeapon.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleAddWeaponWeapon.Tag = "Menu_AddWeapon";
            this.tsVehicleAddWeaponWeapon.Text = "Add &Weapon";
            this.tsVehicleAddWeaponWeapon.Click += new System.EventHandler(this.tsVehicleAddWeaponWeapon_Click);
            // 
            // tsVehicleAddWeaponAccessory
            // 
            this.tsVehicleAddWeaponAccessory.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleAddWeaponAccessory.Name = "tsVehicleAddWeaponAccessory";
            this.tsVehicleAddWeaponAccessory.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleAddWeaponAccessory.Tag = "Menu_AddAccessory";
            this.tsVehicleAddWeaponAccessory.Text = "Add &Accessory";
            this.tsVehicleAddWeaponAccessory.Click += new System.EventHandler(this.tsVehicleAddWeaponAccessory_Click);
            // 
            // tsVehicleAddUnderbarrelWeapon
            // 
            this.tsVehicleAddUnderbarrelWeapon.Image = global::Chummer.Properties.Resources.award_star2_add;
            this.tsVehicleAddUnderbarrelWeapon.Name = "tsVehicleAddUnderbarrelWeapon";
            this.tsVehicleAddUnderbarrelWeapon.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleAddUnderbarrelWeapon.Tag = "Menu_AddUnderbarrelWeapon";
            this.tsVehicleAddUnderbarrelWeapon.Text = "Add Underbarrel Weapon";
            this.tsVehicleAddUnderbarrelWeapon.Click += new System.EventHandler(this.tsVehicleAddUnderbarrelWeapon_Click);
            // 
            // tsVehicleAddWeaponMount
            // 
            this.tsVehicleAddWeaponMount.Image = global::Chummer.Properties.Resources.car_add;
            this.tsVehicleAddWeaponMount.Name = "tsVehicleAddWeaponMount";
            this.tsVehicleAddWeaponMount.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleAddWeaponMount.Tag = "Menu_AddWeaponMount";
            this.tsVehicleAddWeaponMount.Text = "Add Weapon Mount";
            this.tsVehicleAddWeaponMount.Click += new System.EventHandler(this.tsVehicleAddWeaponMount_Click);
            // 
            // tsVehicleAddMod
            // 
            this.tsVehicleAddMod.Image = global::Chummer.Properties.Resources.car_add;
            this.tsVehicleAddMod.Name = "tsVehicleAddMod";
            this.tsVehicleAddMod.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleAddMod.Tag = "Menu_AddModification";
            this.tsVehicleAddMod.Text = "Add &Modification";
            this.tsVehicleAddMod.Click += new System.EventHandler(this.tsVehicleAddMod_Click);
            // 
            // tsVehicleAddCyberware
            // 
            this.tsVehicleAddCyberware.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleAddCyberware.Name = "tsVehicleAddCyberware";
            this.tsVehicleAddCyberware.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleAddCyberware.Tag = "Menu_AddCyberwarePlugin";
            this.tsVehicleAddCyberware.Text = "Add Cyberware Plugin";
            this.tsVehicleAddCyberware.Click += new System.EventHandler(this.tsVehicleAddCyberware_Click);
            // 
            // tsVehicleAddSensor
            // 
            this.tsVehicleAddSensor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleAddGear,
            this.tsVehicleSensorAddAsPlugin});
            this.tsVehicleAddSensor.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsVehicleAddSensor.Name = "tsVehicleAddSensor";
            this.tsVehicleAddSensor.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleAddSensor.Tag = "Menu_Gear";
            this.tsVehicleAddSensor.Text = "&Gear";
            // 
            // tsVehicleAddGear
            // 
            this.tsVehicleAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsVehicleAddGear.Name = "tsVehicleAddGear";
            this.tsVehicleAddGear.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleAddGear.Tag = "Menu_AddGear";
            this.tsVehicleAddGear.Text = "Add &Gear";
            this.tsVehicleAddGear.Click += new System.EventHandler(this.tsVehicleAddGear_Click);
            // 
            // tsVehicleSensorAddAsPlugin
            // 
            this.tsVehicleSensorAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleSensorAddAsPlugin.Name = "tsVehicleSensorAddAsPlugin";
            this.tsVehicleSensorAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleSensorAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsVehicleSensorAddAsPlugin.Text = "&Add as Plugin";
            this.tsVehicleSensorAddAsPlugin.Click += new System.EventHandler(this.tsVehicleSensorAddAsPlugin_Click);
            // 
            // tsVehicleName
            // 
            this.tsVehicleName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsVehicleName.Name = "tsVehicleName";
            this.tsVehicleName.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleName.Tag = "Menu_NameVehicle";
            this.tsVehicleName.Text = "Name Vehicle";
            this.tsVehicleName.Click += new System.EventHandler(this.tsVehicleName_Click);
            // 
            // tsVehicleNotes
            // 
            this.tsVehicleNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleNotes.Name = "tsVehicleNotes";
            this.tsVehicleNotes.Size = new System.Drawing.Size(192, 22);
            this.tsVehicleNotes.Tag = "Menu_Notes";
            this.tsVehicleNotes.Text = "&Notes";
            this.tsVehicleNotes.Click += new System.EventHandler(this.tsVehicleNotes_Click);
            // 
            // tsVehicleWeaponMountNotes
            // 
            this.tsVehicleWeaponMountNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleWeaponMountNotes.Name = "tsVehicleWeaponMountNotes";
            this.tsVehicleWeaponMountNotes.Size = new System.Drawing.Size(180, 22);
            this.tsVehicleWeaponMountNotes.Tag = "Menu_Notes";
            this.tsVehicleWeaponMountNotes.Text = "&Notes";
            this.tsVehicleWeaponMountNotes.Click += new System.EventHandler(this.tsVehicleNotes_Click);
            // 
            // cmsWeaponMount
            // 
            this.cmsWeaponMount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWeaponMountLocation,
            this.tsVehicleMountWeapon,
            this.tsVehicleWeaponMountNotes,
            this.tsEditWeaponMount});
            this.cmsWeaponMount.Name = "cmsWeaponMount";
            this.cmsWeaponMount.Size = new System.Drawing.Size(181, 92);
            // 
            // tsVehicleMountWeapon
            // 
            this.tsVehicleMountWeapon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleMountWeaponAdd,
            this.tsVehicleMountWeaponAccessory,
            this.tsVehicleMountWeaponUnderbarrel});
            this.tsVehicleMountWeapon.Image = global::Chummer.Properties.Resources.award_star_add;
            this.tsVehicleMountWeapon.Name = "tsVehicleMountWeapon";
            this.tsVehicleMountWeapon.Size = new System.Drawing.Size(180, 22);
            this.tsVehicleMountWeapon.Tag = "Menu_Weapons";
            this.tsVehicleMountWeapon.Text = "&Weapons";
            // 
            // tsVehicleMountWeaponAdd
            // 
            this.tsVehicleMountWeaponAdd.Image = global::Chummer.Properties.Resources.award_star_add;
            this.tsVehicleMountWeaponAdd.Name = "tsVehicleMountWeaponAdd";
            this.tsVehicleMountWeaponAdd.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleMountWeaponAdd.Tag = "Menu_AddWeapon";
            this.tsVehicleMountWeaponAdd.Text = "Add &Weapon";
            this.tsVehicleMountWeaponAdd.Click += new System.EventHandler(this.tsVehicleAddWeaponWeapon_Click);
            // 
            // tsVehicleMountWeaponAccessory
            // 
            this.tsVehicleMountWeaponAccessory.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleMountWeaponAccessory.Name = "tsVehicleMountWeaponAccessory";
            this.tsVehicleMountWeaponAccessory.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleMountWeaponAccessory.Tag = "Menu_AddAccessory";
            this.tsVehicleMountWeaponAccessory.Text = "Add &Accessory";
            this.tsVehicleMountWeaponAccessory.Click += new System.EventHandler(this.tsVehicleAddWeaponAccessory_Click);
            // 
            // tsVehicleMountWeaponUnderbarrel
            // 
            this.tsVehicleMountWeaponUnderbarrel.Image = global::Chummer.Properties.Resources.award_star2_add;
            this.tsVehicleMountWeaponUnderbarrel.Name = "tsVehicleMountWeaponUnderbarrel";
            this.tsVehicleMountWeaponUnderbarrel.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleMountWeaponUnderbarrel.Tag = "Menu_AddUnderbarrelWeapon";
            this.tsVehicleMountWeaponUnderbarrel.Text = "Add Underbarrel Weapon";
            this.tsVehicleMountWeaponUnderbarrel.Click += new System.EventHandler(this.tsVehicleAddUnderbarrelWeapon_Click);
            // 
            // tsEditWeaponMount
            // 
            this.tsEditWeaponMount.Image = global::Chummer.Properties.Resources.cog_edit;
            this.tsEditWeaponMount.Name = "tsEditWeaponMount";
            this.tsEditWeaponMount.Size = new System.Drawing.Size(180, 22);
            this.tsEditWeaponMount.Tag = "Menu_EditWeaponMount";
            this.tsEditWeaponMount.Text = "&Edit Weapon Mount";
            this.tsEditWeaponMount.Click += new System.EventHandler(this.tsEditWeaponMount_Click);
            // 
            // mnuCreateMenu
            // 
            this.mnuCreateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateFile,
            this.mnuCreateEdit,
            this.mnuCreateSpecial});
            this.mnuCreateMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateMenu.Name = "mnuCreateMenu";
            this.mnuCreateMenu.Size = new System.Drawing.Size(1085, 24);
            this.mnuCreateMenu.TabIndex = 51;
            this.mnuCreateMenu.Text = "Top Level Menu";
            this.mnuCreateMenu.Visible = false;
            // 
            // mnuCreateFile
            // 
            this.mnuCreateFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.mnuFileClose,
            this.toolStripSeparator2,
            this.mnuFilePrint});
            this.mnuCreateFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuCreateFile.Name = "mnuCreateFile";
            this.mnuCreateFile.Size = new System.Drawing.Size(37, 20);
            this.mnuCreateFile.Tag = "Menu_Main_File";
            this.mnuCreateFile.Text = "&File";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = global::Chummer.Properties.Resources.disk;
            this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFileSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileSave.MergeIndex = 3;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(148, 22);
            this.mnuFileSave.Tag = "Menu_FileSave";
            this.mnuFileSave.Text = "&Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Image = global::Chummer.Properties.Resources.disk;
            this.mnuFileSaveAs.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileSaveAs.MergeIndex = 4;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(148, 22);
            this.mnuFileSaveAs.Tag = "Menu_FileSaveAs";
            this.mnuFileSaveAs.Text = "Save &As";
            this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 5;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Image = global::Chummer.Properties.Resources.cancel;
            this.mnuFileClose.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileClose.MergeIndex = 6;
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuFileClose.Size = new System.Drawing.Size(148, 22);
            this.mnuFileClose.Tag = "Menu_FileClose";
            this.mnuFileClose.Text = "&Close";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.MergeIndex = 7;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Image = global::Chummer.Properties.Resources.printer;
            this.mnuFilePrint.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFilePrint.MergeIndex = 8;
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuFilePrint.Size = new System.Drawing.Size(148, 22);
            this.mnuFilePrint.Tag = "Menu_FilePrint";
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // mnuCreateEdit
            // 
            this.mnuCreateEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCopy,
            this.mnuEditPaste});
            this.mnuCreateEdit.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuCreateEdit.MergeIndex = 1;
            this.mnuCreateEdit.Name = "mnuCreateEdit";
            this.mnuCreateEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuCreateEdit.Tag = "Menu_Main_Edit";
            this.mnuCreateEdit.Text = "&Edit";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Image = global::Chummer.Properties.Resources.page_copy;
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEditCopy.Size = new System.Drawing.Size(144, 22);
            this.mnuEditCopy.Tag = "Menu_EditCopy";
            this.mnuEditCopy.Text = "&Copy";
            this.mnuEditCopy.Click += new System.EventHandler(this.mnuEditCopy_Click);
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Image = global::Chummer.Properties.Resources.page_paste;
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEditPaste.Size = new System.Drawing.Size(144, 22);
            this.mnuEditPaste.Tag = "Menu_EditPaste";
            this.mnuEditPaste.Text = "&Paste";
            this.mnuEditPaste.Click += new System.EventHandler(this.mnuEditPaste_Click);
            // 
            // mnuCreateSpecial
            // 
            this.mnuCreateSpecial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSpecialAddCyberwareSuite,
            this.mnuSpecialAddBiowareSuite,
            this.mnuSpecialCreateCyberwareSuite,
            this.mnuSpecialCreateBiowareSuite,
            this.mnuSpecialAddPACKSKit,
            this.mnuSpecialCreatePACKSKit,
            this.mnuSpecialChangeMetatype,
            this.mnuSpecialChangeOptions,
            this.mnuSpecialMutantCritter,
            this.mnuSpecialToxicCritter,
            this.mnuSpecialCyberzombie,
            this.mnuSpecialConvertToFreeSprite,
            this.mnuSpecialReapplyImprovements,
            this.mnuSpecialBPAvailLimit,
            this.mnuSpecialConfirmValidity,
            this.mnuSpecialKarmaValue});
            this.mnuCreateSpecial.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuCreateSpecial.MergeIndex = 3;
            this.mnuCreateSpecial.Name = "mnuCreateSpecial";
            this.mnuCreateSpecial.Size = new System.Drawing.Size(56, 20);
            this.mnuCreateSpecial.Tag = "Menu_Special";
            this.mnuCreateSpecial.Text = "&Special";
            // 
            // mnuSpecialAddCyberwareSuite
            // 
            this.mnuSpecialAddCyberwareSuite.Image = global::Chummer.Properties.Resources.briefcase_add;
            this.mnuSpecialAddCyberwareSuite.Name = "mnuSpecialAddCyberwareSuite";
            this.mnuSpecialAddCyberwareSuite.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialAddCyberwareSuite.Tag = "Menu_SpecialAddCyberwareSuite";
            this.mnuSpecialAddCyberwareSuite.Text = "Add &Cyberware Suite";
            this.mnuSpecialAddCyberwareSuite.Click += new System.EventHandler(this.mnuSpecialAddCyberwareSuite_Click);
            // 
            // mnuSpecialAddBiowareSuite
            // 
            this.mnuSpecialAddBiowareSuite.Image = global::Chummer.Properties.Resources.briefcase_add;
            this.mnuSpecialAddBiowareSuite.Name = "mnuSpecialAddBiowareSuite";
            this.mnuSpecialAddBiowareSuite.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialAddBiowareSuite.Tag = "Menu_SpecialAddBiowareSuite";
            this.mnuSpecialAddBiowareSuite.Text = "Add &Bioware Suite";
            this.mnuSpecialAddBiowareSuite.Click += new System.EventHandler(this.mnuSpecialAddBiowareSuite_Click);
            // 
            // mnuSpecialCreateCyberwareSuite
            // 
            this.mnuSpecialCreateCyberwareSuite.Image = global::Chummer.Properties.Resources.briefcase_edit;
            this.mnuSpecialCreateCyberwareSuite.Name = "mnuSpecialCreateCyberwareSuite";
            this.mnuSpecialCreateCyberwareSuite.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialCreateCyberwareSuite.Tag = "Menu_SpecialCreateCyberwareSuite";
            this.mnuSpecialCreateCyberwareSuite.Text = "Create Cyberware Suite";
            this.mnuSpecialCreateCyberwareSuite.Click += new System.EventHandler(this.mnuSpecialCreateCyberwareSuite_Click);
            // 
            // mnuSpecialCreateBiowareSuite
            // 
            this.mnuSpecialCreateBiowareSuite.Image = global::Chummer.Properties.Resources.briefcase_edit;
            this.mnuSpecialCreateBiowareSuite.Name = "mnuSpecialCreateBiowareSuite";
            this.mnuSpecialCreateBiowareSuite.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialCreateBiowareSuite.Tag = "Menu_SpecialCreateBiowareSuite";
            this.mnuSpecialCreateBiowareSuite.Text = "Create Bioware Suite";
            this.mnuSpecialCreateBiowareSuite.Click += new System.EventHandler(this.mnuSpecialCreateBiowareSuite_Click);
            // 
            // mnuSpecialAddPACKSKit
            // 
            this.mnuSpecialAddPACKSKit.Image = global::Chummer.Properties.Resources.basket_add;
            this.mnuSpecialAddPACKSKit.Name = "mnuSpecialAddPACKSKit";
            this.mnuSpecialAddPACKSKit.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialAddPACKSKit.Tag = "Menu_SpecialAddPACKSKit";
            this.mnuSpecialAddPACKSKit.Text = "Add &PACKS Kit";
            this.mnuSpecialAddPACKSKit.Click += new System.EventHandler(this.mnuSpecialAddPACKSKit_Click);
            // 
            // mnuSpecialCreatePACKSKit
            // 
            this.mnuSpecialCreatePACKSKit.Image = global::Chummer.Properties.Resources.basket_edit;
            this.mnuSpecialCreatePACKSKit.Name = "mnuSpecialCreatePACKSKit";
            this.mnuSpecialCreatePACKSKit.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialCreatePACKSKit.Tag = "Menu_SpecialCreatePACKSKit";
            this.mnuSpecialCreatePACKSKit.Text = "Create PACKS Kit";
            this.mnuSpecialCreatePACKSKit.Click += new System.EventHandler(this.mnuSpecialCreatePACKSKit_Click);
            // 
            // mnuSpecialChangeMetatype
            // 
            this.mnuSpecialChangeMetatype.Image = global::Chummer.Properties.Resources.user_go;
            this.mnuSpecialChangeMetatype.Name = "mnuSpecialChangeMetatype";
            this.mnuSpecialChangeMetatype.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialChangeMetatype.Tag = "Menu_SpecialChangeMetatype";
            this.mnuSpecialChangeMetatype.Text = "Change &Metatype";
            this.mnuSpecialChangeMetatype.Click += new System.EventHandler(this.mnuSpecialChangeMetatype_Click);
            // 
            // mnuSpecialChangeOptions
            // 
            this.mnuSpecialChangeOptions.Image = global::Chummer.Properties.Resources.user_go;
            this.mnuSpecialChangeOptions.Name = "mnuSpecialChangeOptions";
            this.mnuSpecialChangeOptions.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialChangeOptions.Tag = "Menu_SpecialChangeOptions";
            this.mnuSpecialChangeOptions.Text = "Change &Options File";
            this.mnuSpecialChangeOptions.Click += new System.EventHandler(this.mnuSpecialChangeOptions_Click);
            // 
            // mnuSpecialMutantCritter
            // 
            this.mnuSpecialMutantCritter.Name = "mnuSpecialMutantCritter";
            this.mnuSpecialMutantCritter.Size = new System.Drawing.Size(213, 22);
            // 
            // mnuSpecialToxicCritter
            // 
            this.mnuSpecialToxicCritter.Name = "mnuSpecialToxicCritter";
            this.mnuSpecialToxicCritter.Size = new System.Drawing.Size(213, 22);
            // 
            // mnuSpecialCyberzombie
            // 
            this.mnuSpecialCyberzombie.Image = global::Chummer.Properties.Resources.transmit_go;
            this.mnuSpecialCyberzombie.Name = "mnuSpecialCyberzombie";
            this.mnuSpecialCyberzombie.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialCyberzombie.Tag = "Menu_SpecialConverToCyberzombie";
            this.mnuSpecialCyberzombie.Text = "Convert to Cyberzombie";
            this.mnuSpecialCyberzombie.Click += new System.EventHandler(this.mnuSpecialCyberzombie_Click);
            // 
            // mnuSpecialConvertToFreeSprite
            // 
            this.mnuSpecialConvertToFreeSprite.Image = global::Chummer.Properties.Resources.emoticon_waii;
            this.mnuSpecialConvertToFreeSprite.Name = "mnuSpecialConvertToFreeSprite";
            this.mnuSpecialConvertToFreeSprite.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialConvertToFreeSprite.Tag = "Menu_SpecialConvertToFreeSprite";
            this.mnuSpecialConvertToFreeSprite.Text = "Convert to Free Sprite";
            this.mnuSpecialConvertToFreeSprite.Visible = false;
            this.mnuSpecialConvertToFreeSprite.Click += new System.EventHandler(this.mnuSpecialConvertToFreeSprite_Click);
            // 
            // mnuSpecialReapplyImprovements
            // 
            this.mnuSpecialReapplyImprovements.Image = global::Chummer.Properties.Resources.page_refresh;
            this.mnuSpecialReapplyImprovements.Name = "mnuSpecialReapplyImprovements";
            this.mnuSpecialReapplyImprovements.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialReapplyImprovements.Tag = "Menu_SpecialReapplyImprovements";
            this.mnuSpecialReapplyImprovements.Text = "Re-apply Improvements";
            this.mnuSpecialReapplyImprovements.Click += new System.EventHandler(this.mnuSpecialReapplyImprovements_Click);
            // 
            // mnuSpecialBPAvailLimit
            // 
            this.mnuSpecialBPAvailLimit.Image = global::Chummer.Properties.Resources.table_edit;
            this.mnuSpecialBPAvailLimit.Name = "mnuSpecialBPAvailLimit";
            this.mnuSpecialBPAvailLimit.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialBPAvailLimit.Tag = "Menu_SpecialBPAvailLimit";
            this.mnuSpecialBPAvailLimit.Text = "Change BP/Avail Limit";
            this.mnuSpecialBPAvailLimit.Visible = false;
            this.mnuSpecialBPAvailLimit.Click += new System.EventHandler(this.mnuSpecialBPAvailLimit_Click);
            // 
            // mnuSpecialConfirmValidity
            // 
            this.mnuSpecialConfirmValidity.Image = global::Chummer.Properties.Resources.accept;
            this.mnuSpecialConfirmValidity.Name = "mnuSpecialConfirmValidity";
            this.mnuSpecialConfirmValidity.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialConfirmValidity.Tag = "Menu_ValidCharacter";
            this.mnuSpecialConfirmValidity.Text = "Confirm Character Validity";
            this.mnuSpecialConfirmValidity.Click += new System.EventHandler(this.mnuSpecialConfirmValidity_Click);
            // 
            // mnuSpecialKarmaValue
            // 
            this.mnuSpecialKarmaValue.Image = global::Chummer.Properties.Resources.calculator;
            this.mnuSpecialKarmaValue.Name = "mnuSpecialKarmaValue";
            this.mnuSpecialKarmaValue.Size = new System.Drawing.Size(213, 22);
            this.mnuSpecialKarmaValue.Tag = "Menu_KarmaValue";
            this.mnuSpecialKarmaValue.Text = "Calculate Karma Value";
            this.mnuSpecialKarmaValue.Click += new System.EventHandler(this.mnuSpecialKarmaValue_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbPrint,
            this.tsbSeparator,
            this.tsbCopy,
            this.tsbPaste});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1085, 25);
            this.toolStrip.TabIndex = 53;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.Visible = false;
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Chummer.Properties.Resources.disk;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.tsbSave.MergeIndex = 2;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Tag = "Menu_FileSave";
            this.tsbSave.Text = "Save Character";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Chummer.Properties.Resources.printer;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsbPrint.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.tsbPrint.MergeIndex = 4;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Tag = "Menu_FilePrint";
            this.tsbPrint.Text = "Print Character";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // tsbSeparator
            // 
            this.tsbSeparator.MergeIndex = 5;
            this.tsbSeparator.Name = "tsbSeparator";
            this.tsbSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = global::Chummer.Properties.Resources.page_copy;
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.MergeIndex = 6;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Tag = "Menu_EditCopy";
            this.tsbCopy.Text = "Copy";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = global::Chummer.Properties.Resources.page_paste;
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.MergeIndex = 7;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Tag = "Menu_EditPaste";
            this.tsbPaste.Text = "Paste";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // cmsGear
            // 
            this.cmsGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGearAddAsPlugin,
            this.tsGearName,
            this.tsGearNotes});
            this.cmsGear.Name = "cmsGear";
            this.cmsGear.Size = new System.Drawing.Size(148, 70);
            // 
            // tsGearAddAsPlugin
            // 
            this.tsGearAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsGearAddAsPlugin.Name = "tsGearAddAsPlugin";
            this.tsGearAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsGearAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsGearAddAsPlugin.Text = "&Add as Plugin";
            this.tsGearAddAsPlugin.Click += new System.EventHandler(this.tsGearAddAsPlugin_Click);
            // 
            // tsGearName
            // 
            this.tsGearName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsGearName.Name = "tsGearName";
            this.tsGearName.Size = new System.Drawing.Size(147, 22);
            this.tsGearName.Tag = "Menu_NameGear";
            this.tsGearName.Text = "Name Gear";
            this.tsGearName.Click += new System.EventHandler(this.tsGearName_Click);
            // 
            // tsGearNotes
            // 
            this.tsGearNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsGearNotes.Name = "tsGearNotes";
            this.tsGearNotes.Size = new System.Drawing.Size(147, 22);
            this.tsGearNotes.Tag = "Menu_Notes";
            this.tsGearNotes.Text = "&Notes";
            this.tsGearNotes.Click += new System.EventHandler(this.tsGearNotes_Click);
            // 
            // tsGearAllowRenameAddAsPlugin
            // 
            this.tsGearAllowRenameAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsGearAllowRenameAddAsPlugin.Name = "tsGearAllowRenameAddAsPlugin";
            this.tsGearAllowRenameAddAsPlugin.Size = new System.Drawing.Size(169, 22);
            this.tsGearAllowRenameAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsGearAllowRenameAddAsPlugin.Text = "&Add as Plugin";
            this.tsGearAllowRenameAddAsPlugin.Click += new System.EventHandler(this.tsGearAddAsPlugin_Click);
            // 
            // tsGearAllowRenameName
            // 
            this.tsGearAllowRenameName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsGearAllowRenameName.Name = "tsGearAllowRenameName";
            this.tsGearAllowRenameName.Size = new System.Drawing.Size(169, 22);
            this.tsGearAllowRenameName.Tag = "Menu_NameGear";
            this.tsGearAllowRenameName.Text = "Name Gear";
            this.tsGearAllowRenameName.Click += new System.EventHandler(this.tsGearName_Click);
            // 
            // tsGearAllowRenameNotes
            // 
            this.tsGearAllowRenameNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsGearAllowRenameNotes.Name = "tsGearAllowRenameNotes";
            this.tsGearAllowRenameNotes.Size = new System.Drawing.Size(169, 22);
            this.tsGearAllowRenameNotes.Tag = "Menu_Notes";
            this.tsGearAllowRenameNotes.Text = "&Notes";
            this.tsGearAllowRenameNotes.Click += new System.EventHandler(this.tsGearNotes_Click);
            // 
            // cmsVehicleWeapon
            // 
            this.cmsVehicleWeapon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleAddWeaponAccessoryAlt,
            this.tsVehicleAddUnderbarrelWeaponAlt,
            this.tsVehicleWeaponNotes});
            this.cmsVehicleWeapon.Name = "cmsVehicleWeapon";
            this.cmsVehicleWeapon.Size = new System.Drawing.Size(209, 70);
            // 
            // tsVehicleAddWeaponAccessoryAlt
            // 
            this.tsVehicleAddWeaponAccessoryAlt.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleAddWeaponAccessoryAlt.Name = "tsVehicleAddWeaponAccessoryAlt";
            this.tsVehicleAddWeaponAccessoryAlt.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleAddWeaponAccessoryAlt.Tag = "Menu_AddAccessory";
            this.tsVehicleAddWeaponAccessoryAlt.Text = "Add &Accessory";
            this.tsVehicleAddWeaponAccessoryAlt.Click += new System.EventHandler(this.tsVehicleAddWeaponAccessoryAlt_Click);
            // 
            // tsVehicleAddUnderbarrelWeaponAlt
            // 
            this.tsVehicleAddUnderbarrelWeaponAlt.Image = global::Chummer.Properties.Resources.award_star2_add;
            this.tsVehicleAddUnderbarrelWeaponAlt.Name = "tsVehicleAddUnderbarrelWeaponAlt";
            this.tsVehicleAddUnderbarrelWeaponAlt.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleAddUnderbarrelWeaponAlt.Tag = "Menu_AddUnderbarrelWeapon";
            this.tsVehicleAddUnderbarrelWeaponAlt.Text = "Add Underbarrel Weapon";
            this.tsVehicleAddUnderbarrelWeaponAlt.Click += new System.EventHandler(this.tsVehicleAddUnderbarrelWeaponAlt_Click);
            // 
            // tsVehicleWeaponNotes
            // 
            this.tsVehicleWeaponNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleWeaponNotes.Name = "tsVehicleWeaponNotes";
            this.tsVehicleWeaponNotes.Size = new System.Drawing.Size(208, 22);
            this.tsVehicleWeaponNotes.Tag = "Menu_Notes";
            this.tsVehicleWeaponNotes.Text = "&Notes";
            this.tsVehicleWeaponNotes.Click += new System.EventHandler(this.tsVehicleNotes_Click);
            // 
            // cmsVehicleGear
            // 
            this.cmsVehicleGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleGearAddAsPlugin,
            this.tsVehicleGearNotes});
            this.cmsVehicleGear.Name = "cmsWeapon";
            this.cmsVehicleGear.Size = new System.Drawing.Size(148, 48);
            // 
            // tsVehicleGearAddAsPlugin
            // 
            this.tsVehicleGearAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleGearAddAsPlugin.Name = "tsVehicleGearAddAsPlugin";
            this.tsVehicleGearAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleGearAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsVehicleGearAddAsPlugin.Text = "&Add as Plugin";
            this.tsVehicleGearAddAsPlugin.Click += new System.EventHandler(this.tsVehicleGearAddAsPlugin_Click);
            // 
            // tsVehicleGearNotes
            // 
            this.tsVehicleGearNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleGearNotes.Name = "tsVehicleGearNotes";
            this.tsVehicleGearNotes.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleGearNotes.Tag = "Menu_Notes";
            this.tsVehicleGearNotes.Text = "&Notes";
            this.tsVehicleGearNotes.Click += new System.EventHandler(this.tsVehicleGearNotes_Click);
            // 
            // cmsArmorGear
            // 
            this.cmsArmorGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArmorGearAddAsPlugin,
            this.tsArmorGearNotes});
            this.cmsArmorGear.Name = "cmsWeapon";
            this.cmsArmorGear.Size = new System.Drawing.Size(148, 48);
            // 
            // tsArmorGearAddAsPlugin
            // 
            this.tsArmorGearAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsArmorGearAddAsPlugin.Name = "tsArmorGearAddAsPlugin";
            this.tsArmorGearAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsArmorGearAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsArmorGearAddAsPlugin.Text = "&Add as Plugin";
            this.tsArmorGearAddAsPlugin.Click += new System.EventHandler(this.tsArmorGearAddAsPlugin_Click);
            // 
            // tsArmorGearNotes
            // 
            this.tsArmorGearNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsArmorGearNotes.Name = "tsArmorGearNotes";
            this.tsArmorGearNotes.Size = new System.Drawing.Size(147, 22);
            this.tsArmorGearNotes.Tag = "Menu_Notes";
            this.tsArmorGearNotes.Text = "&Notes";
            this.tsArmorGearNotes.Click += new System.EventHandler(this.tsArmorNotes_Click);
            // 
            // cmsArmorMod
            // 
            this.cmsArmorMod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArmorModNotes});
            this.cmsArmorMod.Name = "cmsArmorMod";
            this.cmsArmorMod.Size = new System.Drawing.Size(106, 26);
            // 
            // tsArmorModNotes
            // 
            this.tsArmorModNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsArmorModNotes.Name = "tsArmorModNotes";
            this.tsArmorModNotes.Size = new System.Drawing.Size(105, 22);
            this.tsArmorModNotes.Tag = "Menu_Notes";
            this.tsArmorModNotes.Text = "&Notes";
            this.tsArmorModNotes.Click += new System.EventHandler(this.tsArmorNotes_Click);
            // 
            // cmsQuality
            // 
            this.cmsQuality.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQualityNotes});
            this.cmsQuality.Name = "cmsQuality";
            this.cmsQuality.Size = new System.Drawing.Size(106, 26);
            // 
            // tsQualityNotes
            // 
            this.tsQualityNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsQualityNotes.Name = "tsQualityNotes";
            this.tsQualityNotes.Size = new System.Drawing.Size(105, 22);
            this.tsQualityNotes.Tag = "Menu_Notes";
            this.tsQualityNotes.Text = "&Notes";
            this.tsQualityNotes.Click += new System.EventHandler(this.tsQualityNotes_Click);
            // 
            // cmsSpell
            // 
            this.cmsSpell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSpellNotes});
            this.cmsSpell.Name = "cmsSpell";
            this.cmsSpell.Size = new System.Drawing.Size(106, 26);
            // 
            // tsSpellNotes
            // 
            this.tsSpellNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsSpellNotes.Name = "tsSpellNotes";
            this.tsSpellNotes.Size = new System.Drawing.Size(105, 22);
            this.tsSpellNotes.Tag = "Menu_Notes";
            this.tsSpellNotes.Text = "&Notes";
            this.tsSpellNotes.Click += new System.EventHandler(this.tsSpellNotes_Click);
            // 
            // cmsCritterPowers
            // 
            this.cmsCritterPowers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCritterPowersNotes});
            this.cmsCritterPowers.Name = "cmsCritterPowers";
            this.cmsCritterPowers.Size = new System.Drawing.Size(106, 26);
            // 
            // tsCritterPowersNotes
            // 
            this.tsCritterPowersNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsCritterPowersNotes.Name = "tsCritterPowersNotes";
            this.tsCritterPowersNotes.Size = new System.Drawing.Size(105, 22);
            this.tsCritterPowersNotes.Tag = "Menu_Notes";
            this.tsCritterPowersNotes.Text = "&Notes";
            this.tsCritterPowersNotes.Click += new System.EventHandler(this.tsCritterPowersNotes_Click);
            // 
            // cmsLifestyleNotes
            // 
            this.cmsLifestyleNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditLifestyle,
            this.tsLifestyleName,
            this.tsLifestyleNotes});
            this.cmsLifestyleNotes.Name = "cmsLifestyleNotes";
            this.cmsLifestyleNotes.Size = new System.Drawing.Size(153, 70);
            // 
            // tsEditLifestyle
            // 
            this.tsEditLifestyle.Image = global::Chummer.Properties.Resources.house_edit;
            this.tsEditLifestyle.Name = "tsEditLifestyle";
            this.tsEditLifestyle.Size = new System.Drawing.Size(152, 22);
            this.tsEditLifestyle.Tag = "Menu_EditLifestyle";
            this.tsEditLifestyle.Text = "&Edit Lifestyle";
            this.tsEditLifestyle.Click += new System.EventHandler(this.tsEditLifestyle_Click);
            // 
            // tsLifestyleName
            // 
            this.tsLifestyleName.Image = global::Chummer.Properties.Resources.tag_red;
            this.tsLifestyleName.Name = "tsLifestyleName";
            this.tsLifestyleName.Size = new System.Drawing.Size(152, 22);
            this.tsLifestyleName.Tag = "Menu_NameLifestyle";
            this.tsLifestyleName.Text = "Name Lifestyle";
            this.tsLifestyleName.Click += new System.EventHandler(this.tsLifestyleName_Click);
            // 
            // tsLifestyleNotes
            // 
            this.tsLifestyleNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsLifestyleNotes.Name = "tsLifestyleNotes";
            this.tsLifestyleNotes.Size = new System.Drawing.Size(152, 22);
            this.tsLifestyleNotes.Tag = "Menu_Notes";
            this.tsLifestyleNotes.Text = "&Notes";
            this.tsLifestyleNotes.Click += new System.EventHandler(this.tsLifestyleNotes_Click);
            // 
            // cmsWeaponAccessory
            // 
            this.cmsWeaponAccessory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWeaponAccessoryAddGear,
            this.tsWeaponAccessoryNotes});
            this.cmsWeaponAccessory.Name = "cmsWeaponAccessory";
            this.cmsWeaponAccessory.Size = new System.Drawing.Size(124, 48);
            // 
            // tsWeaponAccessoryAddGear
            // 
            this.tsWeaponAccessoryAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsWeaponAccessoryAddGear.Name = "tsWeaponAccessoryAddGear";
            this.tsWeaponAccessoryAddGear.Size = new System.Drawing.Size(123, 22);
            this.tsWeaponAccessoryAddGear.Tag = "Menu_AddGear";
            this.tsWeaponAccessoryAddGear.Text = "Add &Gear";
            this.tsWeaponAccessoryAddGear.Click += new System.EventHandler(this.tsWeaponAccessoryAddGear_Click);
            // 
            // tsWeaponAccessoryNotes
            // 
            this.tsWeaponAccessoryNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsWeaponAccessoryNotes.Name = "tsWeaponAccessoryNotes";
            this.tsWeaponAccessoryNotes.Size = new System.Drawing.Size(123, 22);
            this.tsWeaponAccessoryNotes.Tag = "Menu_Notes";
            this.tsWeaponAccessoryNotes.Text = "&Notes";
            this.tsWeaponAccessoryNotes.Click += new System.EventHandler(this.tsWeaponNotes_Click);
            // 
            // cmsGearPlugin
            // 
            this.cmsGearPlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGearPluginNotes});
            this.cmsGearPlugin.Name = "cmsGearPlugin";
            this.cmsGearPlugin.Size = new System.Drawing.Size(106, 26);
            // 
            // tsGearPluginNotes
            // 
            this.tsGearPluginNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsGearPluginNotes.Name = "tsGearPluginNotes";
            this.tsGearPluginNotes.Size = new System.Drawing.Size(105, 22);
            this.tsGearPluginNotes.Tag = "Menu_Notes";
            this.tsGearPluginNotes.Text = "&Notes";
            this.tsGearPluginNotes.Click += new System.EventHandler(this.tsGearNotes_Click);
            // 
            // cmsComplexFormPlugin
            // 
            this.cmsComplexFormPlugin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsComplexFormPluginNotes});
            this.cmsComplexFormPlugin.Name = "cmsComplexFormPlugin";
            this.cmsComplexFormPlugin.Size = new System.Drawing.Size(106, 26);
            // 
            // tsComplexFormPluginNotes
            // 
            this.tsComplexFormPluginNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsComplexFormPluginNotes.Name = "tsComplexFormPluginNotes";
            this.tsComplexFormPluginNotes.Size = new System.Drawing.Size(105, 22);
            this.tsComplexFormPluginNotes.Tag = "Menu_Notes";
            this.tsComplexFormPluginNotes.Text = "&Notes";
            // 
            // cmsBioware
            // 
            this.cmsBioware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBiowareNotes});
            this.cmsBioware.Name = "cmsBioware";
            this.cmsBioware.Size = new System.Drawing.Size(106, 26);
            // 
            // tsBiowareNotes
            // 
            this.tsBiowareNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsBiowareNotes.Name = "tsBiowareNotes";
            this.tsBiowareNotes.Size = new System.Drawing.Size(105, 22);
            this.tsBiowareNotes.Tag = "Menu_Notes";
            this.tsBiowareNotes.Text = "&Notes";
            this.tsBiowareNotes.Click += new System.EventHandler(this.tsCyberwareNotes_Click);
            // 
            // cmsAdvancedLifestyle
            // 
            this.cmsAdvancedLifestyle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditAdvancedLifestyle,
            this.tsAdvancedLifestyleNotes});
            this.cmsAdvancedLifestyle.Name = "cmsAdvancedLifestyle";
            this.cmsAdvancedLifestyle.Size = new System.Drawing.Size(197, 48);
            // 
            // tsEditAdvancedLifestyle
            // 
            this.tsEditAdvancedLifestyle.Image = global::Chummer.Properties.Resources.house_edit;
            this.tsEditAdvancedLifestyle.Name = "tsEditAdvancedLifestyle";
            this.tsEditAdvancedLifestyle.Size = new System.Drawing.Size(196, 22);
            this.tsEditAdvancedLifestyle.Tag = "Menu_EditAdvancedLifestyle";
            this.tsEditAdvancedLifestyle.Text = "&Edit Advanced Lifestyle";
            this.tsEditAdvancedLifestyle.Click += new System.EventHandler(this.tsEditAdvancedLifestyle_Click);
            // 
            // tsAdvancedLifestyleNotes
            // 
            this.tsAdvancedLifestyleNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsAdvancedLifestyleNotes.Name = "tsAdvancedLifestyleNotes";
            this.tsAdvancedLifestyleNotes.Size = new System.Drawing.Size(196, 22);
            this.tsAdvancedLifestyleNotes.Tag = "Menu_Notes";
            this.tsAdvancedLifestyleNotes.Text = "&Notes";
            this.tsAdvancedLifestyleNotes.Click += new System.EventHandler(this.tsAdvancedLifestyleNotes_Click);
            // 
            // cmsGearLocation
            // 
            this.cmsGearLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGearRenameLocation,
            this.tsGearLocationAddGear});
            this.cmsGearLocation.Name = "cmsGearLocation";
            this.cmsGearLocation.Size = new System.Drawing.Size(167, 48);
            // 
            // tsGearRenameLocation
            // 
            this.tsGearRenameLocation.Image = global::Chummer.Properties.Resources.building_edit;
            this.tsGearRenameLocation.Name = "tsGearRenameLocation";
            this.tsGearRenameLocation.Size = new System.Drawing.Size(166, 22);
            this.tsGearRenameLocation.Tag = "Menu_RenameLocation";
            this.tsGearRenameLocation.Text = "&Rename Location";
            this.tsGearRenameLocation.Click += new System.EventHandler(this.tsGearRenameLocation_Click);
            // 
            // tsGearLocationAddGear
            // 
            this.tsGearLocationAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsGearLocationAddGear.Name = "tsGearLocationAddGear";
            this.tsGearLocationAddGear.Size = new System.Drawing.Size(166, 22);
            this.tsGearLocationAddGear.Tag = "Menu_AddGear";
            this.tsGearLocationAddGear.Text = "Add &Gear";
            this.tsGearLocationAddGear.Click += new System.EventHandler(this.cmdAddGear_Click);
            // 
            // cmsArmorLocation
            // 
            this.cmsArmorLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsArmorLocationAddArmor,
            this.tsArmorRenameLocation});
            this.cmsArmorLocation.Name = "cmsGearLocation";
            this.cmsArmorLocation.Size = new System.Drawing.Size(167, 48);
            // 
            // tsArmorLocationAddArmor
            // 
            this.tsArmorLocationAddArmor.Image = global::Chummer.Properties.Resources.building_edit;
            this.tsArmorLocationAddArmor.Name = "tsArmorLocationAddArmor";
            this.tsArmorLocationAddArmor.Size = new System.Drawing.Size(166, 22);
            this.tsArmorLocationAddArmor.Tag = "Button_AddArmor";
            this.tsArmorLocationAddArmor.Text = "&Add Armor";
            this.tsArmorLocationAddArmor.Click += new System.EventHandler(this.tsArmorLocationAddArmor_Click);
            // 
            // tsArmorRenameLocation
            // 
            this.tsArmorRenameLocation.Image = global::Chummer.Properties.Resources.building_edit;
            this.tsArmorRenameLocation.Name = "tsArmorRenameLocation";
            this.tsArmorRenameLocation.Size = new System.Drawing.Size(166, 22);
            this.tsArmorRenameLocation.Tag = "Menu_RenameLocation";
            this.tsArmorRenameLocation.Text = "&Rename Location";
            this.tsArmorRenameLocation.Click += new System.EventHandler(this.tsArmorRenameLocation_Click);
            // 
            // cmsCyberwareGear
            // 
            this.cmsCyberwareGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCyberwareGearMenuAddAsPlugin});
            this.cmsCyberwareGear.Name = "cmsCyberwareGear";
            this.cmsCyberwareGear.Size = new System.Drawing.Size(148, 26);
            // 
            // tsCyberwareGearMenuAddAsPlugin
            // 
            this.tsCyberwareGearMenuAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsCyberwareGearMenuAddAsPlugin.Name = "tsCyberwareGearMenuAddAsPlugin";
            this.tsCyberwareGearMenuAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsCyberwareGearMenuAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsCyberwareGearMenuAddAsPlugin.Text = "&Add as Plugin";
            this.tsCyberwareGearMenuAddAsPlugin.Click += new System.EventHandler(this.tsCyberwareGearMenuAddAsPlugin_Click);
            // 
            // cmsVehicleCyberwareGear
            // 
            this.cmsVehicleCyberwareGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleCyberwareGearMenuAddAsPlugin});
            this.cmsVehicleCyberwareGear.Name = "cmsVehicleCyberwareGear";
            this.cmsVehicleCyberwareGear.Size = new System.Drawing.Size(148, 26);
            // 
            // tsVehicleCyberwareGearMenuAddAsPlugin
            // 
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Name = "tsVehicleCyberwareGearMenuAddAsPlugin";
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Text = "&Add as Plugin";
            this.tsVehicleCyberwareGearMenuAddAsPlugin.Click += new System.EventHandler(this.tsVehicleCyberwareGearMenuAddAsPlugin_Click);
            // 
            // cmsWeaponAccessoryGear
            // 
            this.cmsWeaponAccessoryGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWeaponAccessoryGearMenuAddAsPlugin});
            this.cmsWeaponAccessoryGear.Name = "cmsWeaponAccessoryGear";
            this.cmsWeaponAccessoryGear.Size = new System.Drawing.Size(148, 26);
            // 
            // tsWeaponAccessoryGearMenuAddAsPlugin
            // 
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Name = "tsWeaponAccessoryGearMenuAddAsPlugin";
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Text = "&Add as Plugin";
            this.tsWeaponAccessoryGearMenuAddAsPlugin.Click += new System.EventHandler(this.tsWeaponAccessoryGearMenuAddAsPlugin_Click);
            // 
            // cmsVehicleLocation
            // 
            this.cmsVehicleLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleRenameLocation,
            this.tsVehicleLocationAddVehicle});
            this.cmsVehicleLocation.Name = "cmsGearLocation";
            this.cmsVehicleLocation.Size = new System.Drawing.Size(167, 48);
            // 
            // tsVehicleRenameLocation
            // 
            this.tsVehicleRenameLocation.Image = global::Chummer.Properties.Resources.building_edit;
            this.tsVehicleRenameLocation.Name = "tsVehicleRenameLocation";
            this.tsVehicleRenameLocation.Size = new System.Drawing.Size(166, 22);
            this.tsVehicleRenameLocation.Tag = "Menu_RenameLocation";
            this.tsVehicleRenameLocation.Text = "&Rename Location";
            this.tsVehicleRenameLocation.Click += new System.EventHandler(this.tsVehicleRenameLocation_Click);
            // 
            // tsVehicleLocationAddVehicle
            // 
            this.tsVehicleLocationAddVehicle.Image = global::Chummer.Properties.Resources.car_add;
            this.tsVehicleLocationAddVehicle.Name = "tsVehicleLocationAddVehicle";
            this.tsVehicleLocationAddVehicle.Size = new System.Drawing.Size(166, 22);
            this.tsVehicleLocationAddVehicle.Tag = "Menu_AddVehicle";
            this.tsVehicleLocationAddVehicle.Text = "Add &Vehicle";
            this.tsVehicleLocationAddVehicle.Click += new System.EventHandler(this.tsVehicleLocationAddVehicle_Click);
            // 
            // cmsVehicleWeaponAccessory
            // 
            this.cmsVehicleWeaponAccessory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleWeaponAccessoryAddGear,
            this.tsVehicleWeaponAccessoryNotes});
            this.cmsVehicleWeaponAccessory.Name = "cmsWeaponAccessory";
            this.cmsVehicleWeaponAccessory.Size = new System.Drawing.Size(124, 48);
            // 
            // tsVehicleWeaponAccessoryAddGear
            // 
            this.tsVehicleWeaponAccessoryAddGear.Image = global::Chummer.Properties.Resources.camera_add;
            this.tsVehicleWeaponAccessoryAddGear.Name = "tsVehicleWeaponAccessoryAddGear";
            this.tsVehicleWeaponAccessoryAddGear.Size = new System.Drawing.Size(123, 22);
            this.tsVehicleWeaponAccessoryAddGear.Tag = "Menu_AddGear";
            this.tsVehicleWeaponAccessoryAddGear.Text = "Add &Gear";
            this.tsVehicleWeaponAccessoryAddGear.Click += new System.EventHandler(this.tsVehicleWeaponAccessoryAddGear_Click);
            // 
            // tsVehicleWeaponAccessoryNotes
            // 
            this.tsVehicleWeaponAccessoryNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsVehicleWeaponAccessoryNotes.Name = "tsVehicleWeaponAccessoryNotes";
            this.tsVehicleWeaponAccessoryNotes.Size = new System.Drawing.Size(123, 22);
            this.tsVehicleWeaponAccessoryNotes.Tag = "Menu_Notes";
            this.tsVehicleWeaponAccessoryNotes.Text = "&Notes";
            this.tsVehicleWeaponAccessoryNotes.Click += new System.EventHandler(this.tsVehicleNotes_Click);
            // 
            // cmsVehicleWeaponAccessoryGear
            // 
            this.cmsVehicleWeaponAccessoryGear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin});
            this.cmsVehicleWeaponAccessoryGear.Name = "cmsVehicleWeaponAccessoryGear";
            this.cmsVehicleWeaponAccessoryGear.Size = new System.Drawing.Size(148, 26);
            // 
            // tsVehicleWeaponAccessoryGearMenuAddAsPlugin
            // 
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Image = global::Chummer.Properties.Resources.brick_add;
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Name = "tsVehicleWeaponAccessoryGearMenuAddAsPlugin";
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Size = new System.Drawing.Size(147, 22);
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Tag = "Menu_AddAsPlugin";
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Text = "&Add as Plugin";
            this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin.Click += new System.EventHandler(this.tsVehicleWeaponAccessoryGearMenuAddAsPlugin_Click);
            // 
            // cmsWeaponLocation
            // 
            this.cmsWeaponLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsWeaponRenameLocation,
            this.tsWeaponLocationAddWeapon});
            this.cmsWeaponLocation.Name = "cmsGearLocation";
            this.cmsWeaponLocation.Size = new System.Drawing.Size(167, 48);
            // 
            // tsWeaponRenameLocation
            // 
            this.tsWeaponRenameLocation.Image = global::Chummer.Properties.Resources.building_edit;
            this.tsWeaponRenameLocation.Name = "tsWeaponRenameLocation";
            this.tsWeaponRenameLocation.Size = new System.Drawing.Size(166, 22);
            this.tsWeaponRenameLocation.Tag = "Menu_RenameLocation";
            this.tsWeaponRenameLocation.Text = "&Rename Location";
            this.tsWeaponRenameLocation.Click += new System.EventHandler(this.tsWeaponRenameLocation_Click);
            // 
            // tsWeaponLocationAddWeapon
            // 
            this.tsWeaponLocationAddWeapon.Image = global::Chummer.Properties.Resources.award_star_add;
            this.tsWeaponLocationAddWeapon.Name = "tsWeaponLocationAddWeapon";
            this.tsWeaponLocationAddWeapon.Size = new System.Drawing.Size(166, 22);
            this.tsWeaponLocationAddWeapon.Tag = "Menu_AddWeapon";
            this.tsWeaponLocationAddWeapon.Text = "Add &Weapon";
            this.tsWeaponLocationAddWeapon.Click += new System.EventHandler(this.tsWeaponLocationAddWeapon_Click);
            // 
            // splitMain
            // 
            this.splitMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitMain.Panel1.Controls.Add(this.tabCharacterTabs);
            this.splitMain.Panel1MinSize = 849;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitMain.Panel2.Controls.Add(this.tabInfo);
            this.splitMain.Size = new System.Drawing.Size(1085, 657);
            this.splitMain.SplitterDistance = 849;
            this.splitMain.TabIndex = 54;
            // 
            // tabCharacterTabs
            // 
            this.tabCharacterTabs.Controls.Add(this.tabCommon);
            this.tabCharacterTabs.Controls.Add(this.tabSkills);
            this.tabCharacterTabs.Controls.Add(this.tabLimits);
            this.tabCharacterTabs.Controls.Add(this.tabMartialArts);
            this.tabCharacterTabs.Controls.Add(this.tabMagician);
            this.tabCharacterTabs.Controls.Add(this.tabAdept);
            this.tabCharacterTabs.Controls.Add(this.tabTechnomancer);
            this.tabCharacterTabs.Controls.Add(this.tabAdvancedPrograms);
            this.tabCharacterTabs.Controls.Add(this.tabCritter);
            this.tabCharacterTabs.Controls.Add(this.tabInitiation);
            this.tabCharacterTabs.Controls.Add(this.tabCyberware);
            this.tabCharacterTabs.Controls.Add(this.tabStreetGear);
            this.tabCharacterTabs.Controls.Add(this.tabVehicles);
            this.tabCharacterTabs.Controls.Add(this.tabCharacterInfo);
            this.tabCharacterTabs.Controls.Add(this.tabRelationships);
            this.tabCharacterTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacterTabs.Location = new System.Drawing.Point(0, 0);
            this.tabCharacterTabs.Name = "tabCharacterTabs";
            this.tabCharacterTabs.SelectedIndex = 0;
            this.tabCharacterTabs.Size = new System.Drawing.Size(849, 657);
            this.tabCharacterTabs.TabIndex = 33;
            this.tabCharacterTabs.SelectedIndexChanged += new System.EventHandler(this.tabCharacterTabs_SelectedIndexChanged);
            // 
            // tabCommon
            // 
            this.tabCommon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabCommon.Controls.Add(this.tlpCommon);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(841, 631);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Tag = "Tab_Common";
            this.tabCommon.Text = "Common";
            // 
            // tlpCommon
            // 
            this.tlpCommon.AutoSize = true;
            this.tlpCommon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCommon.ColumnCount = 9;
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tlpCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tlpCommon.Controls.Add(this.tlpCommonLeftSide, 0, 0);
            this.tlpCommon.Controls.Add(this.lblAlias, 1, 0);
            this.tlpCommon.Controls.Add(this.pnlAttributes, 1, 2);
            this.tlpCommon.Controls.Add(this.txtAlias, 2, 0);
            this.tlpCommon.Controls.Add(this.lblMetatypeLabel, 7, 0);
            this.tlpCommon.Controls.Add(this.lblMetatype, 8, 0);
            this.tlpCommon.Controls.Add(this.lblMetatypeSource, 8, 1);
            this.tlpCommon.Controls.Add(this.lblMetatypeSourceLabel, 7, 1);
            this.tlpCommon.Controls.Add(this.lblNuyen, 7, 2);
            this.tlpCommon.Controls.Add(this.lblMysticAdeptAssignment, 7, 4);
            this.tlpCommon.Controls.Add(this.lblAttributes, 1, 1);
            this.tlpCommon.Controls.Add(this.lblAttributesMetatype, 6, 1);
            this.tlpCommon.Controls.Add(this.lblAttributesAug, 5, 1);
            this.tlpCommon.Controls.Add(this.label7, 4, 1);
            this.tlpCommon.Controls.Add(this.lblAttributesBase, 3, 1);
            this.tlpCommon.Controls.Add(this.flpNuyen, 8, 2);
            this.tlpCommon.Controls.Add(this.nudMysticAdeptMAGMagician, 8, 4);
            this.tlpCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommon.Location = new System.Drawing.Point(3, 3);
            this.tlpCommon.Name = "tlpCommon";
            this.tlpCommon.RowCount = 1;
            this.tlpCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommon.Size = new System.Drawing.Size(835, 625);
            this.tlpCommon.TabIndex = 99;
            // 
            // tlpCommonLeftSide
            // 
            this.tlpCommonLeftSide.AutoSize = true;
            this.tlpCommonLeftSide.ColumnCount = 4;
            this.tlpCommonLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCommonLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCommonLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCommonLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpCommonLeftSide.Controls.Add(this.treQualities, 0, 2);
            this.tlpCommonLeftSide.Controls.Add(this.cmdLifeModule, 3, 0);
            this.tlpCommonLeftSide.Controls.Add(this.tlpCommonBottomLeftSide, 0, 3);
            this.tlpCommonLeftSide.Controls.Add(this.nudQualityLevel, 1, 1);
            this.tlpCommonLeftSide.Controls.Add(this.lblQualityLevelLabel, 0, 1);
            this.tlpCommonLeftSide.Controls.Add(this.cmdAddQuality, 0, 0);
            this.tlpCommonLeftSide.Controls.Add(this.cmdDeleteQuality, 1, 0);
            this.tlpCommonLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommonLeftSide.Location = new System.Drawing.Point(0, 0);
            this.tlpCommonLeftSide.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCommonLeftSide.Name = "tlpCommonLeftSide";
            this.tlpCommonLeftSide.RowCount = 4;
            this.tlpCommon.SetRowSpan(this.tlpCommonLeftSide, 5);
            this.tlpCommonLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommonLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommonLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommonLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommonLeftSide.Size = new System.Drawing.Size(301, 625);
            this.tlpCommonLeftSide.TabIndex = 100;
            // 
            // treQualities
            // 
            this.treQualities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCommonLeftSide.SetColumnSpan(this.treQualities, 4);
            this.treQualities.HideSelection = false;
            this.treQualities.Indent = 15;
            this.treQualities.Location = new System.Drawing.Point(3, 58);
            this.treQualities.Name = "treQualities";
            treeNode4.Name = "nodPositiveQualityRoot";
            treeNode4.Tag = "Node_SelectedPositiveQualities";
            treeNode4.Text = "Selected Positive Qualities";
            treeNode5.Name = "nodNegativeQualityRoot";
            treeNode5.Tag = "Node_SelectedNegativeQualities";
            treeNode5.Text = "Selected Negative Qualities";
            this.treQualities.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treQualities.ShowNodeToolTips = true;
            this.treQualities.ShowPlusMinus = false;
            this.treQualities.ShowRootLines = false;
            this.treQualities.Size = new System.Drawing.Size(295, 539);
            this.treQualities.TabIndex = 33;
            this.treQualities.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treQualities_AfterSelect);
            this.treQualities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treQualities_KeyDown);
            this.treQualities.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // cmdLifeModule
            // 
            this.cmdLifeModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdLifeModule.Location = new System.Drawing.Point(203, 3);
            this.cmdLifeModule.Name = "cmdLifeModule";
            this.cmdLifeModule.Size = new System.Drawing.Size(95, 23);
            this.cmdLifeModule.TabIndex = 95;
            this.cmdLifeModule.Tag = "String_Life_Module";
            this.cmdLifeModule.Text = "Life Module";
            this.cmdLifeModule.UseVisualStyleBackColor = true;
            this.cmdLifeModule.Visible = false;
            this.cmdLifeModule.Click += new System.EventHandler(this.cmdLifeModule_Click);
            // 
            // tlpCommonBottomLeftSide
            // 
            this.tlpCommonBottomLeftSide.AutoSize = true;
            this.tlpCommonBottomLeftSide.ColumnCount = 4;
            this.tlpCommonLeftSide.SetColumnSpan(this.tlpCommonBottomLeftSide, 4);
            this.tlpCommonBottomLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCommonBottomLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCommonBottomLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCommonBottomLeftSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCommonBottomLeftSide.Controls.Add(this.lblQualitySource, 3, 0);
            this.tlpCommonBottomLeftSide.Controls.Add(this.lblQualityBP, 1, 0);
            this.tlpCommonBottomLeftSide.Controls.Add(this.lblQualitySourceLabel, 2, 0);
            this.tlpCommonBottomLeftSide.Controls.Add(this.lblQualityBPLabel, 0, 0);
            this.tlpCommonBottomLeftSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCommonBottomLeftSide.Location = new System.Drawing.Point(0, 600);
            this.tlpCommonBottomLeftSide.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCommonBottomLeftSide.Name = "tlpCommonBottomLeftSide";
            this.tlpCommonBottomLeftSide.RowCount = 1;
            this.tlpCommonBottomLeftSide.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCommonBottomLeftSide.Size = new System.Drawing.Size(301, 25);
            this.tlpCommonBottomLeftSide.TabIndex = 101;
            // 
            // lblQualitySource
            // 
            this.lblQualitySource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualitySource.AutoSize = true;
            this.lblQualitySource.Location = new System.Drawing.Point(213, 6);
            this.lblQualitySource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualitySource.Name = "lblQualitySource";
            this.lblQualitySource.Size = new System.Drawing.Size(47, 13);
            this.lblQualitySource.TabIndex = 65;
            this.lblQualitySource.Text = "[Source]";
            this.lblQualitySource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblQualityBP
            // 
            this.lblQualityBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityBP.AutoSize = true;
            this.lblQualityBP.Location = new System.Drawing.Point(63, 6);
            this.lblQualityBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityBP.Name = "lblQualityBP";
            this.lblQualityBP.Size = new System.Drawing.Size(27, 13);
            this.lblQualityBP.TabIndex = 67;
            this.lblQualityBP.Text = "[BP]";
            // 
            // lblQualitySourceLabel
            // 
            this.lblQualitySourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQualitySourceLabel.AutoSize = true;
            this.lblQualitySourceLabel.Location = new System.Drawing.Point(163, 6);
            this.lblQualitySourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualitySourceLabel.Name = "lblQualitySourceLabel";
            this.lblQualitySourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblQualitySourceLabel.TabIndex = 64;
            this.lblQualitySourceLabel.Tag = "Label_Source";
            this.lblQualitySourceLabel.Text = "Source:";
            this.lblQualitySourceLabel.Visible = false;
            // 
            // lblQualityBPLabel
            // 
            this.lblQualityBPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQualityBPLabel.AutoSize = true;
            this.lblQualityBPLabel.Location = new System.Drawing.Point(17, 6);
            this.lblQualityBPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityBPLabel.Name = "lblQualityBPLabel";
            this.lblQualityBPLabel.Size = new System.Drawing.Size(40, 13);
            this.lblQualityBPLabel.TabIndex = 66;
            this.lblQualityBPLabel.Tag = "Label_Karma";
            this.lblQualityBPLabel.Text = "Karma:";
            this.lblQualityBPLabel.Visible = false;
            // 
            // nudQualityLevel
            // 
            this.nudQualityLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudQualityLevel.Location = new System.Drawing.Point(103, 32);
            this.nudQualityLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQualityLevel.Name = "nudQualityLevel";
            this.nudQualityLevel.Size = new System.Drawing.Size(44, 20);
            this.nudQualityLevel.TabIndex = 97;
            this.nudQualityLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQualityLevel.ValueChanged += new System.EventHandler(this.nudQualityLevel_ValueChanged);
            // 
            // lblQualityLevelLabel
            // 
            this.lblQualityLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQualityLevelLabel.AutoSize = true;
            this.lblQualityLevelLabel.Location = new System.Drawing.Point(26, 35);
            this.lblQualityLevelLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQualityLevelLabel.Name = "lblQualityLevelLabel";
            this.lblQualityLevelLabel.Size = new System.Drawing.Size(71, 13);
            this.lblQualityLevelLabel.TabIndex = 98;
            this.lblQualityLevelLabel.Tag = "Label_QualityLevel";
            this.lblQualityLevelLabel.Text = "Quality Level:";
            // 
            // cmdAddQuality
            // 
            this.cmdAddQuality.AutoSize = true;
            this.cmdAddQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdAddQuality.Location = new System.Drawing.Point(3, 3);
            this.cmdAddQuality.Name = "cmdAddQuality";
            this.cmdAddQuality.Size = new System.Drawing.Size(94, 23);
            this.cmdAddQuality.TabIndex = 62;
            this.cmdAddQuality.Tag = "Button_AddQuality";
            this.cmdAddQuality.Text = "Add &Quality";
            this.cmdAddQuality.UseVisualStyleBackColor = true;
            this.cmdAddQuality.Click += new System.EventHandler(this.cmdAddQuality_Click);
            // 
            // cmdDeleteQuality
            // 
            this.cmdDeleteQuality.AutoSize = true;
            this.tlpCommonLeftSide.SetColumnSpan(this.cmdDeleteQuality, 2);
            this.cmdDeleteQuality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDeleteQuality.Location = new System.Drawing.Point(103, 3);
            this.cmdDeleteQuality.Name = "cmdDeleteQuality";
            this.cmdDeleteQuality.Size = new System.Drawing.Size(94, 23);
            this.cmdDeleteQuality.TabIndex = 63;
            this.cmdDeleteQuality.Tag = "String_Delete";
            this.cmdDeleteQuality.Text = "Delete";
            this.cmdDeleteQuality.UseVisualStyleBackColor = true;
            this.cmdDeleteQuality.Click += new System.EventHandler(this.cmdDeleteQuality_Click);
            // 
            // lblAlias
            // 
            this.lblAlias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAlias.AutoSize = true;
            this.lblAlias.Location = new System.Drawing.Point(329, 6);
            this.lblAlias.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(32, 13);
            this.lblAlias.TabIndex = 90;
            this.lblAlias.Tag = "Label_Alias";
            this.lblAlias.Text = "Alias:";
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAttributes.AutoSize = true;
            this.tlpCommon.SetColumnSpan(this.pnlAttributes, 6);
            this.pnlAttributes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlAttributes.Location = new System.Drawing.Point(304, 54);
            this.pnlAttributes.Name = "pnlAttributes";
            this.tlpCommon.SetRowSpan(this.pnlAttributes, 3);
            this.pnlAttributes.Size = new System.Drawing.Size(353, 568);
            this.pnlAttributes.TabIndex = 96;
            this.pnlAttributes.WrapContents = false;
            this.pnlAttributes.Layout += new System.Windows.Forms.LayoutEventHandler(this.pnlAttributes_Layout);
            // 
            // txtAlias
            // 
            this.tlpCommon.SetColumnSpan(this.txtAlias, 5);
            this.txtAlias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAlias.Location = new System.Drawing.Point(367, 3);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(290, 20);
            this.txtAlias.TabIndex = 91;
            // 
            // lblMetatypeLabel
            // 
            this.lblMetatypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetatypeLabel.AutoSize = true;
            this.lblMetatypeLabel.Location = new System.Drawing.Point(690, 6);
            this.lblMetatypeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetatypeLabel.Name = "lblMetatypeLabel";
            this.lblMetatypeLabel.Size = new System.Drawing.Size(54, 13);
            this.lblMetatypeLabel.TabIndex = 19;
            this.lblMetatypeLabel.Tag = "Label_Metatype";
            this.lblMetatypeLabel.Text = "Metatype:";
            // 
            // lblMetatype
            // 
            this.lblMetatype.AutoSize = true;
            this.lblMetatype.Location = new System.Drawing.Point(750, 6);
            this.lblMetatype.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetatype.Name = "lblMetatype";
            this.lblMetatype.Size = new System.Drawing.Size(39, 13);
            this.lblMetatype.TabIndex = 20;
            this.lblMetatype.Text = "[None]";
            // 
            // lblMetatypeSource
            // 
            this.lblMetatypeSource.AutoSize = true;
            this.lblMetatypeSource.Location = new System.Drawing.Point(750, 32);
            this.lblMetatypeSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetatypeSource.Name = "lblMetatypeSource";
            this.lblMetatypeSource.Size = new System.Drawing.Size(47, 13);
            this.lblMetatypeSource.TabIndex = 89;
            this.lblMetatypeSource.Text = "[Source]";
            this.lblMetatypeSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblMetatypeSourceLabel
            // 
            this.lblMetatypeSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetatypeSourceLabel.AutoSize = true;
            this.lblMetatypeSourceLabel.Location = new System.Drawing.Point(700, 32);
            this.lblMetatypeSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetatypeSourceLabel.Name = "lblMetatypeSourceLabel";
            this.lblMetatypeSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblMetatypeSourceLabel.TabIndex = 88;
            this.lblMetatypeSourceLabel.Tag = "Label_Source";
            this.lblMetatypeSourceLabel.Text = "Source:";
            // 
            // lblMysticAdeptAssignment
            // 
            this.lblMysticAdeptAssignment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMysticAdeptAssignment.AutoSize = true;
            this.lblMysticAdeptAssignment.Location = new System.Drawing.Point(673, 208);
            this.lblMysticAdeptAssignment.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMysticAdeptAssignment.Name = "lblMysticAdeptAssignment";
            this.lblMysticAdeptAssignment.Size = new System.Drawing.Size(71, 26);
            this.lblMysticAdeptAssignment.TabIndex = 56;
            this.lblMysticAdeptAssignment.Tag = "Label_MysticAdeptAssignment";
            this.lblMysticAdeptAssignment.Text = "Mystic Adept Power Points";
            // 
            // flpNuyen
            // 
            this.flpNuyen.AutoSize = true;
            this.flpNuyen.Controls.Add(this.nudNuyen);
            this.flpNuyen.Controls.Add(this.lblNuyenTotal);
            this.flpNuyen.Location = new System.Drawing.Point(747, 51);
            this.flpNuyen.Margin = new System.Windows.Forms.Padding(0);
            this.flpNuyen.Name = "flpNuyen";
            this.flpNuyen.Size = new System.Drawing.Size(79, 26);
            this.flpNuyen.TabIndex = 101;
            // 
            // nudNuyen
            // 
            this.nudNuyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNuyen.Location = new System.Drawing.Point(3, 3);
            this.nudNuyen.Maximum = new decimal(new int[] {
            1073704,
            0,
            0,
            0});
            this.nudNuyen.Name = "nudNuyen";
            this.nudNuyen.Size = new System.Drawing.Size(39, 20);
            this.nudNuyen.TabIndex = 17;
            this.nudNuyen.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblNuyenTotal
            // 
            this.lblNuyenTotal.AutoSize = true;
            this.lblNuyenTotal.Location = new System.Drawing.Point(48, 6);
            this.lblNuyenTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNuyenTotal.Name = "lblNuyenTotal";
            this.lblNuyenTotal.Size = new System.Drawing.Size(28, 13);
            this.lblNuyenTotal.TabIndex = 18;
            this.lblNuyenTotal.Text = "= 0¥";
            // 
            // nudMysticAdeptMAGMagician
            // 
            this.nudMysticAdeptMAGMagician.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMysticAdeptMAGMagician.Location = new System.Drawing.Point(750, 205);
            this.nudMysticAdeptMAGMagician.Name = "nudMysticAdeptMAGMagician";
            this.nudMysticAdeptMAGMagician.Size = new System.Drawing.Size(82, 20);
            this.nudMysticAdeptMAGMagician.TabIndex = 60;
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.tabSkillUc);
            this.tabSkills.Location = new System.Drawing.Point(4, 22);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Size = new System.Drawing.Size(841, 631);
            this.tabSkills.TabIndex = 14;
            this.tabSkills.Tag = "Tab_Skills";
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tabSkillUc
            // 
            this.tabSkillUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSkillUc.Location = new System.Drawing.Point(0, 0);
            this.tabSkillUc.Name = "tabSkillUc";
            this.tabSkillUc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabSkillUc.Size = new System.Drawing.Size(841, 631);
            this.tabSkillUc.TabIndex = 0;
            this.tabSkillUc.Tag = "";
            // 
            // tabLimits
            // 
            this.tabLimits.Controls.Add(this.lmtControl);
            this.tabLimits.Location = new System.Drawing.Point(4, 22);
            this.tabLimits.Name = "tabLimits";
            this.tabLimits.Padding = new System.Windows.Forms.Padding(3);
            this.tabLimits.Size = new System.Drawing.Size(841, 631);
            this.tabLimits.TabIndex = 13;
            this.tabLimits.Tag = "Tab_Limits";
            this.tabLimits.Text = "Limits";
            // 
            // tabMartialArts
            // 
            this.tabMartialArts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabMartialArts.Controls.Add(this.tlpMartialArts);
            this.tabMartialArts.Location = new System.Drawing.Point(4, 22);
            this.tabMartialArts.Name = "tabMartialArts";
            this.tabMartialArts.Padding = new System.Windows.Forms.Padding(3);
            this.tabMartialArts.Size = new System.Drawing.Size(841, 631);
            this.tabMartialArts.TabIndex = 8;
            this.tabMartialArts.Tag = "Tab_MartialArts";
            this.tabMartialArts.Text = "Martial Arts";
            // 
            // tlpMartialArts
            // 
            this.tlpMartialArts.AutoSize = true;
            this.tlpMartialArts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMartialArts.ColumnCount = 3;
            this.tlpMartialArts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpMartialArts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMartialArts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMartialArts.Controls.Add(this.treMartialArts, 0, 1);
            this.tlpMartialArts.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tlpMartialArts.Controls.Add(this.lblMartialArtSource, 2, 1);
            this.tlpMartialArts.Controls.Add(this.lblMartialArtSourceLabel, 1, 1);
            this.tlpMartialArts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMartialArts.Location = new System.Drawing.Point(3, 3);
            this.tlpMartialArts.Name = "tlpMartialArts";
            this.tlpMartialArts.RowCount = 2;
            this.tlpMartialArts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMartialArts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMartialArts.Size = new System.Drawing.Size(835, 625);
            this.tlpMartialArts.TabIndex = 58;
            // 
            // treMartialArts
            // 
            this.treMartialArts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treMartialArts.HideSelection = false;
            this.treMartialArts.Location = new System.Drawing.Point(3, 32);
            this.treMartialArts.Name = "treMartialArts";
            treeNode6.Name = "treMartialArtsRoot";
            treeNode6.Tag = "Node_SelectedMartialArts";
            treeNode6.Text = "Selected Martial Arts";
            treeNode7.Name = "treQualitiesRoot";
            treeNode7.Text = "Selected Qualities";
            this.treMartialArts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            this.treMartialArts.ShowNodeToolTips = true;
            this.treMartialArts.ShowPlusMinus = false;
            this.treMartialArts.ShowRootLines = false;
            this.treMartialArts.Size = new System.Drawing.Size(295, 590);
            this.treMartialArts.TabIndex = 2;
            this.treMartialArts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treMartialArts_AfterSelect);
            this.treMartialArts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treMartialArts_KeyDown);
            this.treMartialArts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMartialArts.SetColumnSpan(this.flowLayoutPanel2, 3);
            this.flowLayoutPanel2.Controls.Add(this.cmdAddMartialArt);
            this.flowLayoutPanel2.Controls.Add(this.cmdDeleteMartialArt);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(196, 29);
            this.flowLayoutPanel2.TabIndex = 56;
            // 
            // cmdAddMartialArt
            // 
            this.cmdAddMartialArt.AutoSize = true;
            this.cmdAddMartialArt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddMartialArt.ContextMenuStrip = this.cmsMartialArts;
            this.cmdAddMartialArt.Location = new System.Drawing.Point(3, 3);
            this.cmdAddMartialArt.Name = "cmdAddMartialArt";
            this.cmdAddMartialArt.Size = new System.Drawing.Size(104, 23);
            this.cmdAddMartialArt.SplitMenuStrip = this.cmsMartialArts;
            this.cmdAddMartialArt.TabIndex = 55;
            this.cmdAddMartialArt.Tag = "Button_AddMartialArt";
            this.cmdAddMartialArt.Text = "&Add Martial Art";
            this.cmdAddMartialArt.UseVisualStyleBackColor = true;
            this.cmdAddMartialArt.Click += new System.EventHandler(this.cmdAddMartialArt_Click);
            // 
            // cmdDeleteMartialArt
            // 
            this.cmdDeleteMartialArt.AutoSize = true;
            this.cmdDeleteMartialArt.Location = new System.Drawing.Point(113, 3);
            this.cmdDeleteMartialArt.Name = "cmdDeleteMartialArt";
            this.cmdDeleteMartialArt.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteMartialArt.TabIndex = 1;
            this.cmdDeleteMartialArt.Tag = "String_Delete";
            this.cmdDeleteMartialArt.Text = "Delete";
            this.cmdDeleteMartialArt.UseVisualStyleBackColor = true;
            this.cmdDeleteMartialArt.Click += new System.EventHandler(this.cmdDeleteMartialArt_Click);
            // 
            // lblMartialArtSource
            // 
            this.lblMartialArtSource.AutoSize = true;
            this.lblMartialArtSource.Location = new System.Drawing.Point(354, 35);
            this.lblMartialArtSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMartialArtSource.Name = "lblMartialArtSource";
            this.lblMartialArtSource.Size = new System.Drawing.Size(47, 13);
            this.lblMartialArtSource.TabIndex = 25;
            this.lblMartialArtSource.Text = "[Source]";
            this.lblMartialArtSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblMartialArtSourceLabel
            // 
            this.lblMartialArtSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMartialArtSourceLabel.AutoSize = true;
            this.lblMartialArtSourceLabel.Location = new System.Drawing.Point(304, 35);
            this.lblMartialArtSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMartialArtSourceLabel.Name = "lblMartialArtSourceLabel";
            this.lblMartialArtSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblMartialArtSourceLabel.TabIndex = 24;
            this.lblMartialArtSourceLabel.Tag = "Label_Source";
            this.lblMartialArtSourceLabel.Text = "Source:";
            // 
            // tabMagician
            // 
            this.tabMagician.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabMagician.Controls.Add(this.tlpMagician);
            this.tabMagician.Location = new System.Drawing.Point(4, 22);
            this.tabMagician.Name = "tabMagician";
            this.tabMagician.Padding = new System.Windows.Forms.Padding(3);
            this.tabMagician.Size = new System.Drawing.Size(841, 631);
            this.tabMagician.TabIndex = 1;
            this.tabMagician.Tag = "Tab_Magician";
            this.tabMagician.Text = "Spells and Spirits";
            // 
            // tlpMagician
            // 
            this.tlpMagician.ColumnCount = 6;
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMagician.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMagician.Controls.Add(this.cmdAddSpirit, 0, 14);
            this.tlpMagician.Controls.Add(this.panSpirits, 0, 15);
            this.tlpMagician.Controls.Add(this.treSpells, 0, 1);
            this.tlpMagician.Controls.Add(this.lblSpellDV, 4, 4);
            this.tlpMagician.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tlpMagician.Controls.Add(this.lblSpellType, 4, 2);
            this.tlpMagician.Controls.Add(this.cboSpiritManipulation, 5, 12);
            this.tlpMagician.Controls.Add(this.lblSpellDamage, 4, 3);
            this.tlpMagician.Controls.Add(this.lblTraditionSource, 2, 9);
            this.tlpMagician.Controls.Add(this.lblSpiritManipulation, 4, 12);
            this.tlpMagician.Controls.Add(this.lblSpellDescriptorsLabel, 1, 1);
            this.tlpMagician.Controls.Add(this.cboSpiritIllusion, 5, 11);
            this.tlpMagician.Controls.Add(this.lblTraditionSourceLabel, 1, 9);
            this.tlpMagician.Controls.Add(this.cboSpiritHealth, 5, 10);
            this.tlpMagician.Controls.Add(this.lblSpiritIllusion, 4, 11);
            this.tlpMagician.Controls.Add(this.lblSpellDescriptors, 2, 1);
            this.tlpMagician.Controls.Add(this.lblSpellCategoryLabel, 1, 2);
            this.tlpMagician.Controls.Add(this.lblSpiritHealth, 4, 10);
            this.tlpMagician.Controls.Add(this.lblSpellCategory, 2, 2);
            this.tlpMagician.Controls.Add(this.lblSpellRangeLabel, 1, 3);
            this.tlpMagician.Controls.Add(this.lblSpellRange, 2, 3);
            this.tlpMagician.Controls.Add(this.lblSpellDurationLabel, 1, 4);
            this.tlpMagician.Controls.Add(this.lblSpellDuration, 2, 4);
            this.tlpMagician.Controls.Add(this.lblSpellSourceLabel, 1, 5);
            this.tlpMagician.Controls.Add(this.lblSpellSource, 2, 5);
            this.tlpMagician.Controls.Add(this.lblSpellDicePoolLabel, 1, 6);
            this.tlpMagician.Controls.Add(this.lblSpellDicePool, 2, 6);
            this.tlpMagician.Controls.Add(this.lblTraditionLabel, 1, 7);
            this.tlpMagician.Controls.Add(this.lblDrainAttributesLabel, 1, 8);
            this.tlpMagician.Controls.Add(this.cboTradition, 2, 7);
            this.tlpMagician.Controls.Add(this.flowLayoutPanel4, 2, 8);
            this.tlpMagician.Controls.Add(this.lblTraditionName, 4, 7);
            this.tlpMagician.Controls.Add(this.txtTraditionName, 5, 7);
            this.tlpMagician.Controls.Add(this.lblSpiritCombat, 4, 8);
            this.tlpMagician.Controls.Add(this.cboSpiritCombat, 5, 8);
            this.tlpMagician.Controls.Add(this.lblSpiritDetection, 4, 9);
            this.tlpMagician.Controls.Add(this.cboSpiritDetection, 5, 9);
            this.tlpMagician.Controls.Add(this.lblDrainAttributesValue, 3, 8);
            this.tlpMagician.Controls.Add(this.lblSpellTypeLabel, 3, 2);
            this.tlpMagician.Controls.Add(this.lblSpellDamageLabel, 3, 3);
            this.tlpMagician.Controls.Add(this.lblSpellDVLabel, 3, 4);
            this.tlpMagician.Controls.Add(this.lblMentorSpiritLabel, 1, 11);
            this.tlpMagician.Controls.Add(this.lblMentorSpirit, 2, 11);
            this.tlpMagician.Controls.Add(this.lblMentorSpiritInformation, 1, 12);
            this.tlpMagician.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMagician.Location = new System.Drawing.Point(3, 3);
            this.tlpMagician.Name = "tlpMagician";
            this.tlpMagician.RowCount = 16;
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMagician.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMagician.Size = new System.Drawing.Size(835, 625);
            this.tlpMagician.TabIndex = 157;
            // 
            // cmdAddSpirit
            // 
            this.cmdAddSpirit.Location = new System.Drawing.Point(3, 417);
            this.cmdAddSpirit.Name = "cmdAddSpirit";
            this.cmdAddSpirit.Size = new System.Drawing.Size(105, 23);
            this.cmdAddSpirit.TabIndex = 68;
            this.cmdAddSpirit.Tag = "Button_AddSpirit";
            this.cmdAddSpirit.Text = "A&dd Spirit";
            this.cmdAddSpirit.UseVisualStyleBackColor = true;
            this.cmdAddSpirit.Click += new System.EventHandler(this.cmdAddSpirit_Click);
            // 
            // panSpirits
            // 
            this.panSpirits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSpirits.AutoScroll = true;
            this.panSpirits.AutoSize = true;
            this.tlpMagician.SetColumnSpan(this.panSpirits, 6);
            this.panSpirits.Location = new System.Drawing.Point(3, 446);
            this.panSpirits.Name = "panSpirits";
            this.panSpirits.Size = new System.Drawing.Size(829, 176);
            this.panSpirits.TabIndex = 4;
            // 
            // treSpells
            // 
            this.treSpells.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treSpells.HideSelection = false;
            this.treSpells.Location = new System.Drawing.Point(3, 32);
            this.treSpells.Name = "treSpells";
            treeNode8.Name = "nodSpellCombatRoot";
            treeNode8.Tag = "Node_SelectedCombatSpells";
            treeNode8.Text = "Selected Combat Spells";
            treeNode9.Name = "nodSpellDetectionRoot";
            treeNode9.Tag = "Node_SelectedDetectionSpells";
            treeNode9.Text = "Selected Detection Spells";
            treeNode10.Name = "nodSpellHealthRoot";
            treeNode10.Tag = "Node_SelectedHealthSpells";
            treeNode10.Text = "Selected Health Spells";
            treeNode11.Name = "nodSpellIllusionRoot";
            treeNode11.Tag = "Node_SelectedIllusionSpells";
            treeNode11.Text = "Selected Illusion Spells";
            treeNode12.Name = "nodSpellManipulationRoot";
            treeNode12.Tag = "Node_SelectedManipulationSpells";
            treeNode12.Text = "Selected Manipulation Spells";
            treeNode13.Name = "nodSpellGeomancyRoot";
            treeNode13.Tag = "Node_SelectedGeomancyRituals";
            treeNode13.Text = "Selected Rituals";
            treeNode14.Name = "nodSpellEnchantmentRoot";
            treeNode14.Tag = "Node_SelectedEnchantments";
            treeNode14.Text = "Selected Enchantments";
            this.treSpells.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            this.tlpMagician.SetRowSpan(this.treSpells, 12);
            this.treSpells.ShowNodeToolTips = true;
            this.treSpells.ShowRootLines = false;
            this.treSpells.Size = new System.Drawing.Size(295, 379);
            this.treSpells.TabIndex = 70;
            this.treSpells.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treSpells_AfterSelect);
            this.treSpells.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treSpells_KeyDown);
            this.treSpells.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblSpellDV
            // 
            this.lblSpellDV.AutoSize = true;
            this.lblSpellDV.Location = new System.Drawing.Point(622, 110);
            this.lblSpellDV.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDV.Name = "lblSpellDV";
            this.lblSpellDV.Size = new System.Drawing.Size(28, 13);
            this.lblSpellDV.TabIndex = 82;
            this.lblSpellDV.Text = "[DV]";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMagician.SetColumnSpan(this.flowLayoutPanel3, 6);
            this.flowLayoutPanel3.Controls.Add(this.cmdAddSpell);
            this.flowLayoutPanel3.Controls.Add(this.cmdDeleteSpell);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(172, 29);
            this.flowLayoutPanel3.TabIndex = 156;
            // 
            // cmdAddSpell
            // 
            this.cmdAddSpell.AutoSize = true;
            this.cmdAddSpell.Location = new System.Drawing.Point(3, 3);
            this.cmdAddSpell.Name = "cmdAddSpell";
            this.cmdAddSpell.Size = new System.Drawing.Size(80, 23);
            this.cmdAddSpell.TabIndex = 140;
            this.cmdAddSpell.Tag = "Button_AddSpell";
            this.cmdAddSpell.Text = "&Add Spell";
            this.cmdAddSpell.UseVisualStyleBackColor = true;
            this.cmdAddSpell.Click += new System.EventHandler(this.cmdAddSpell_Click);
            // 
            // cmdDeleteSpell
            // 
            this.cmdDeleteSpell.AutoSize = true;
            this.cmdDeleteSpell.Location = new System.Drawing.Point(89, 3);
            this.cmdDeleteSpell.Name = "cmdDeleteSpell";
            this.cmdDeleteSpell.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteSpell.TabIndex = 69;
            this.cmdDeleteSpell.Tag = "String_Delete";
            this.cmdDeleteSpell.Text = "Delete";
            this.cmdDeleteSpell.UseVisualStyleBackColor = true;
            this.cmdDeleteSpell.Click += new System.EventHandler(this.cmdDeleteSpell_Click);
            // 
            // lblSpellType
            // 
            this.lblSpellType.AutoSize = true;
            this.lblSpellType.Location = new System.Drawing.Point(622, 60);
            this.lblSpellType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellType.Name = "lblSpellType";
            this.lblSpellType.Size = new System.Drawing.Size(37, 13);
            this.lblSpellType.TabIndex = 84;
            this.lblSpellType.Text = "[Type]";
            // 
            // cboSpiritManipulation
            // 
            this.cboSpiritManipulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpiritManipulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpiritManipulation.FormattingEnabled = true;
            this.cboSpiritManipulation.Location = new System.Drawing.Point(728, 317);
            this.cboSpiritManipulation.Name = "cboSpiritManipulation";
            this.cboSpiritManipulation.Size = new System.Drawing.Size(104, 21);
            this.cboSpiritManipulation.TabIndex = 153;
            this.cboSpiritManipulation.TooltipText = "";
            this.cboSpiritManipulation.Visible = false;
            // 
            // lblSpellDamage
            // 
            this.lblSpellDamage.AutoSize = true;
            this.lblSpellDamage.Location = new System.Drawing.Point(622, 85);
            this.lblSpellDamage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDamage.Name = "lblSpellDamage";
            this.lblSpellDamage.Size = new System.Drawing.Size(53, 13);
            this.lblSpellDamage.TabIndex = 78;
            this.lblSpellDamage.Text = "[Damage]";
            // 
            // lblTraditionSource
            // 
            this.lblTraditionSource.AutoSize = true;
            this.lblTraditionSource.Location = new System.Drawing.Point(410, 239);
            this.lblTraditionSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTraditionSource.Name = "lblTraditionSource";
            this.lblTraditionSource.Size = new System.Drawing.Size(47, 13);
            this.lblTraditionSource.TabIndex = 155;
            this.lblTraditionSource.Text = "[Source]";
            this.lblTraditionSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblSpiritManipulation
            // 
            this.lblSpiritManipulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpiritManipulation.AutoSize = true;
            this.lblSpiritManipulation.Location = new System.Drawing.Point(652, 320);
            this.lblSpiritManipulation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritManipulation.Name = "lblSpiritManipulation";
            this.lblSpiritManipulation.Size = new System.Drawing.Size(70, 13);
            this.lblSpiritManipulation.TabIndex = 152;
            this.lblSpiritManipulation.Tag = "Label_SpiritManipulation";
            this.lblSpiritManipulation.Text = "Manipulation:";
            this.lblSpiritManipulation.Visible = false;
            // 
            // lblSpellDescriptorsLabel
            // 
            this.lblSpellDescriptorsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellDescriptorsLabel.AutoSize = true;
            this.lblSpellDescriptorsLabel.Location = new System.Drawing.Point(341, 35);
            this.lblSpellDescriptorsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDescriptorsLabel.Name = "lblSpellDescriptorsLabel";
            this.lblSpellDescriptorsLabel.Size = new System.Drawing.Size(63, 13);
            this.lblSpellDescriptorsLabel.TabIndex = 71;
            this.lblSpellDescriptorsLabel.Tag = "Label_Descriptors";
            this.lblSpellDescriptorsLabel.Text = "Descriptors:";
            // 
            // cboSpiritIllusion
            // 
            this.cboSpiritIllusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpiritIllusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpiritIllusion.FormattingEnabled = true;
            this.cboSpiritIllusion.Location = new System.Drawing.Point(728, 290);
            this.cboSpiritIllusion.Name = "cboSpiritIllusion";
            this.cboSpiritIllusion.Size = new System.Drawing.Size(104, 21);
            this.cboSpiritIllusion.TabIndex = 151;
            this.cboSpiritIllusion.TooltipText = "";
            this.cboSpiritIllusion.Visible = false;
            // 
            // lblTraditionSourceLabel
            // 
            this.lblTraditionSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraditionSourceLabel.AutoSize = true;
            this.lblTraditionSourceLabel.Location = new System.Drawing.Point(360, 239);
            this.lblTraditionSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTraditionSourceLabel.Name = "lblTraditionSourceLabel";
            this.lblTraditionSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblTraditionSourceLabel.TabIndex = 154;
            this.lblTraditionSourceLabel.Tag = "Label_Source";
            this.lblTraditionSourceLabel.Text = "Source:";
            // 
            // cboSpiritHealth
            // 
            this.cboSpiritHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpiritHealth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpiritHealth.FormattingEnabled = true;
            this.cboSpiritHealth.Location = new System.Drawing.Point(728, 263);
            this.cboSpiritHealth.Name = "cboSpiritHealth";
            this.cboSpiritHealth.Size = new System.Drawing.Size(104, 21);
            this.cboSpiritHealth.TabIndex = 149;
            this.cboSpiritHealth.TooltipText = "";
            this.cboSpiritHealth.Visible = false;
            // 
            // lblSpiritIllusion
            // 
            this.lblSpiritIllusion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpiritIllusion.AutoSize = true;
            this.lblSpiritIllusion.Location = new System.Drawing.Point(680, 293);
            this.lblSpiritIllusion.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritIllusion.Name = "lblSpiritIllusion";
            this.lblSpiritIllusion.Size = new System.Drawing.Size(42, 13);
            this.lblSpiritIllusion.TabIndex = 150;
            this.lblSpiritIllusion.Tag = "Label_SpiritIllusion";
            this.lblSpiritIllusion.Text = "Illusion:";
            this.lblSpiritIllusion.Visible = false;
            // 
            // lblSpellDescriptors
            // 
            this.lblSpellDescriptors.AutoSize = true;
            this.tlpMagician.SetColumnSpan(this.lblSpellDescriptors, 2);
            this.lblSpellDescriptors.Location = new System.Drawing.Point(410, 35);
            this.lblSpellDescriptors.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDescriptors.Name = "lblSpellDescriptors";
            this.lblSpellDescriptors.Size = new System.Drawing.Size(66, 13);
            this.lblSpellDescriptors.TabIndex = 72;
            this.lblSpellDescriptors.Text = "[Descriptors]";
            // 
            // lblSpellCategoryLabel
            // 
            this.lblSpellCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellCategoryLabel.AutoSize = true;
            this.lblSpellCategoryLabel.Location = new System.Drawing.Point(352, 60);
            this.lblSpellCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellCategoryLabel.Name = "lblSpellCategoryLabel";
            this.lblSpellCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblSpellCategoryLabel.TabIndex = 73;
            this.lblSpellCategoryLabel.Tag = "Label_Category";
            this.lblSpellCategoryLabel.Text = "Category:";
            // 
            // lblSpiritHealth
            // 
            this.lblSpiritHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpiritHealth.AutoSize = true;
            this.lblSpiritHealth.Location = new System.Drawing.Point(681, 266);
            this.lblSpiritHealth.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritHealth.Name = "lblSpiritHealth";
            this.lblSpiritHealth.Size = new System.Drawing.Size(41, 13);
            this.lblSpiritHealth.TabIndex = 148;
            this.lblSpiritHealth.Tag = "Label_SpiritHealth";
            this.lblSpiritHealth.Text = "Health:";
            this.lblSpiritHealth.Visible = false;
            // 
            // lblSpellCategory
            // 
            this.lblSpellCategory.AutoSize = true;
            this.lblSpellCategory.Location = new System.Drawing.Point(410, 60);
            this.lblSpellCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellCategory.Name = "lblSpellCategory";
            this.lblSpellCategory.Size = new System.Drawing.Size(55, 13);
            this.lblSpellCategory.TabIndex = 74;
            this.lblSpellCategory.Text = "[Category]";
            // 
            // lblSpellRangeLabel
            // 
            this.lblSpellRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellRangeLabel.AutoSize = true;
            this.lblSpellRangeLabel.Location = new System.Drawing.Point(362, 85);
            this.lblSpellRangeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellRangeLabel.Name = "lblSpellRangeLabel";
            this.lblSpellRangeLabel.Size = new System.Drawing.Size(42, 13);
            this.lblSpellRangeLabel.TabIndex = 75;
            this.lblSpellRangeLabel.Tag = "Label_Range";
            this.lblSpellRangeLabel.Text = "Range:";
            // 
            // lblSpellRange
            // 
            this.lblSpellRange.AutoSize = true;
            this.lblSpellRange.Location = new System.Drawing.Point(410, 85);
            this.lblSpellRange.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellRange.Name = "lblSpellRange";
            this.lblSpellRange.Size = new System.Drawing.Size(45, 13);
            this.lblSpellRange.TabIndex = 76;
            this.lblSpellRange.Text = "[Range]";
            // 
            // lblSpellDurationLabel
            // 
            this.lblSpellDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellDurationLabel.AutoSize = true;
            this.lblSpellDurationLabel.Location = new System.Drawing.Point(354, 110);
            this.lblSpellDurationLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDurationLabel.Name = "lblSpellDurationLabel";
            this.lblSpellDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.lblSpellDurationLabel.TabIndex = 79;
            this.lblSpellDurationLabel.Tag = "Label_Duration";
            this.lblSpellDurationLabel.Text = "Duration:";
            // 
            // lblSpellDuration
            // 
            this.lblSpellDuration.AutoSize = true;
            this.lblSpellDuration.Location = new System.Drawing.Point(410, 110);
            this.lblSpellDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDuration.Name = "lblSpellDuration";
            this.lblSpellDuration.Size = new System.Drawing.Size(53, 13);
            this.lblSpellDuration.TabIndex = 80;
            this.lblSpellDuration.Text = "[Duration]";
            // 
            // lblSpellSourceLabel
            // 
            this.lblSpellSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellSourceLabel.AutoSize = true;
            this.lblSpellSourceLabel.Location = new System.Drawing.Point(360, 135);
            this.lblSpellSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellSourceLabel.Name = "lblSpellSourceLabel";
            this.lblSpellSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblSpellSourceLabel.TabIndex = 87;
            this.lblSpellSourceLabel.Tag = "Label_Source";
            this.lblSpellSourceLabel.Text = "Source:";
            // 
            // lblSpellSource
            // 
            this.lblSpellSource.AutoSize = true;
            this.lblSpellSource.Location = new System.Drawing.Point(410, 135);
            this.lblSpellSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellSource.Name = "lblSpellSource";
            this.lblSpellSource.Size = new System.Drawing.Size(47, 13);
            this.lblSpellSource.TabIndex = 88;
            this.lblSpellSource.Text = "[Source]";
            this.lblSpellSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblSpellDicePoolLabel
            // 
            this.lblSpellDicePoolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellDicePoolLabel.AutoSize = true;
            this.lblSpellDicePoolLabel.Location = new System.Drawing.Point(348, 160);
            this.lblSpellDicePoolLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDicePoolLabel.Name = "lblSpellDicePoolLabel";
            this.lblSpellDicePoolLabel.Size = new System.Drawing.Size(56, 13);
            this.lblSpellDicePoolLabel.TabIndex = 106;
            this.lblSpellDicePoolLabel.Tag = "Label_DicePool";
            this.lblSpellDicePoolLabel.Text = "Dice Pool:";
            // 
            // lblSpellDicePool
            // 
            this.lblSpellDicePool.AutoSize = true;
            this.lblSpellDicePool.Location = new System.Drawing.Point(410, 160);
            this.lblSpellDicePool.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDicePool.Name = "lblSpellDicePool";
            this.lblSpellDicePool.Size = new System.Drawing.Size(59, 13);
            this.lblSpellDicePool.TabIndex = 107;
            this.lblSpellDicePool.Text = "[Dice Pool]";
            // 
            // lblTraditionLabel
            // 
            this.lblTraditionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraditionLabel.AutoSize = true;
            this.lblTraditionLabel.Location = new System.Drawing.Point(353, 185);
            this.lblTraditionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTraditionLabel.Name = "lblTraditionLabel";
            this.lblTraditionLabel.Size = new System.Drawing.Size(51, 13);
            this.lblTraditionLabel.TabIndex = 89;
            this.lblTraditionLabel.Tag = "Label_Tradition";
            this.lblTraditionLabel.Text = "Tradition:";
            // 
            // lblDrainAttributesLabel
            // 
            this.lblDrainAttributesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrainAttributesLabel.AutoSize = true;
            this.lblDrainAttributesLabel.Location = new System.Drawing.Point(315, 212);
            this.lblDrainAttributesLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrainAttributesLabel.Name = "lblDrainAttributesLabel";
            this.lblDrainAttributesLabel.Size = new System.Drawing.Size(89, 13);
            this.lblDrainAttributesLabel.TabIndex = 91;
            this.lblDrainAttributesLabel.Tag = "Label_ResistDrain";
            this.lblDrainAttributesLabel.Text = "Resist Drain with:";
            // 
            // cboTradition
            // 
            this.cboTradition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMagician.SetColumnSpan(this.cboTradition, 2);
            this.cboTradition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTradition.FormattingEnabled = true;
            this.cboTradition.Location = new System.Drawing.Point(410, 182);
            this.cboTradition.Name = "cboTradition";
            this.cboTradition.Size = new System.Drawing.Size(206, 21);
            this.cboTradition.TabIndex = 90;
            this.cboTradition.TooltipText = "";
            this.cboTradition.SelectedIndexChanged += new System.EventHandler(this.cboTradition_SelectedIndexChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.cboDrain);
            this.flowLayoutPanel4.Controls.Add(this.lblDrainAttributes);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(407, 206);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(106, 27);
            this.flowLayoutPanel4.TabIndex = 144;
            this.flowLayoutPanel4.WrapContents = false;
            // 
            // cboDrain
            // 
            this.cboDrain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrain.FormattingEnabled = true;
            this.cboDrain.Location = new System.Drawing.Point(3, 3);
            this.cboDrain.Name = "cboDrain";
            this.cboDrain.Size = new System.Drawing.Size(98, 21);
            this.cboDrain.TabIndex = 143;
            this.cboDrain.TooltipText = "";
            this.cboDrain.Visible = false;
            // 
            // lblDrainAttributes
            // 
            this.lblDrainAttributes.AutoSize = true;
            this.lblDrainAttributes.Location = new System.Drawing.Point(107, 6);
            this.lblDrainAttributes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrainAttributes.Name = "lblDrainAttributes";
            this.lblDrainAttributes.Size = new System.Drawing.Size(57, 13);
            this.lblDrainAttributes.TabIndex = 92;
            this.lblDrainAttributes.Text = "[Attributes]";
            // 
            // lblTraditionName
            // 
            this.lblTraditionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraditionName.AutoSize = true;
            this.lblTraditionName.Location = new System.Drawing.Point(684, 185);
            this.lblTraditionName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTraditionName.Name = "lblTraditionName";
            this.lblTraditionName.Size = new System.Drawing.Size(38, 13);
            this.lblTraditionName.TabIndex = 141;
            this.lblTraditionName.Tag = "Label_TraditionName";
            this.lblTraditionName.Text = "Name:";
            this.lblTraditionName.Visible = false;
            // 
            // txtTraditionName
            // 
            this.txtTraditionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraditionName.Location = new System.Drawing.Point(728, 182);
            this.txtTraditionName.Name = "txtTraditionName";
            this.txtTraditionName.Size = new System.Drawing.Size(104, 20);
            this.txtTraditionName.TabIndex = 142;
            this.txtTraditionName.Visible = false;
            // 
            // lblSpiritCombat
            // 
            this.lblSpiritCombat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpiritCombat.AutoSize = true;
            this.lblSpiritCombat.Location = new System.Drawing.Point(676, 212);
            this.lblSpiritCombat.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritCombat.Name = "lblSpiritCombat";
            this.lblSpiritCombat.Size = new System.Drawing.Size(46, 13);
            this.lblSpiritCombat.TabIndex = 144;
            this.lblSpiritCombat.Tag = "Label_SpiritCombat";
            this.lblSpiritCombat.Text = "Combat:";
            this.lblSpiritCombat.Visible = false;
            // 
            // cboSpiritCombat
            // 
            this.cboSpiritCombat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpiritCombat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpiritCombat.FormattingEnabled = true;
            this.cboSpiritCombat.Location = new System.Drawing.Point(728, 209);
            this.cboSpiritCombat.Name = "cboSpiritCombat";
            this.cboSpiritCombat.Size = new System.Drawing.Size(104, 21);
            this.cboSpiritCombat.TabIndex = 145;
            this.cboSpiritCombat.TooltipText = "";
            this.cboSpiritCombat.Visible = false;
            // 
            // lblSpiritDetection
            // 
            this.lblSpiritDetection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpiritDetection.AutoSize = true;
            this.lblSpiritDetection.Location = new System.Drawing.Point(666, 239);
            this.lblSpiritDetection.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritDetection.Name = "lblSpiritDetection";
            this.lblSpiritDetection.Size = new System.Drawing.Size(56, 13);
            this.lblSpiritDetection.TabIndex = 146;
            this.lblSpiritDetection.Tag = "Label_SpiritDetection";
            this.lblSpiritDetection.Text = "Detection:";
            this.lblSpiritDetection.Visible = false;
            // 
            // cboSpiritDetection
            // 
            this.cboSpiritDetection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSpiritDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpiritDetection.FormattingEnabled = true;
            this.cboSpiritDetection.Location = new System.Drawing.Point(728, 236);
            this.cboSpiritDetection.Name = "cboSpiritDetection";
            this.cboSpiritDetection.Size = new System.Drawing.Size(104, 21);
            this.cboSpiritDetection.TabIndex = 147;
            this.cboSpiritDetection.TooltipText = "";
            this.cboSpiritDetection.Visible = false;
            // 
            // lblDrainAttributesValue
            // 
            this.lblDrainAttributesValue.AutoSize = true;
            this.lblDrainAttributesValue.Location = new System.Drawing.Point(516, 212);
            this.lblDrainAttributesValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrainAttributesValue.Name = "lblDrainAttributesValue";
            this.lblDrainAttributesValue.Size = new System.Drawing.Size(37, 13);
            this.lblDrainAttributesValue.TabIndex = 93;
            this.lblDrainAttributesValue.Text = "[Total]";
            this.lblDrainAttributesValue.ToolTipText = "";
            // 
            // lblSpellTypeLabel
            // 
            this.lblSpellTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellTypeLabel.AutoSize = true;
            this.lblSpellTypeLabel.Location = new System.Drawing.Point(582, 60);
            this.lblSpellTypeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellTypeLabel.Name = "lblSpellTypeLabel";
            this.lblSpellTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.lblSpellTypeLabel.TabIndex = 83;
            this.lblSpellTypeLabel.Tag = "Label_Type";
            this.lblSpellTypeLabel.Text = "Type:";
            // 
            // lblSpellDamageLabel
            // 
            this.lblSpellDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellDamageLabel.AutoSize = true;
            this.lblSpellDamageLabel.Location = new System.Drawing.Point(566, 85);
            this.lblSpellDamageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDamageLabel.Name = "lblSpellDamageLabel";
            this.lblSpellDamageLabel.Size = new System.Drawing.Size(50, 13);
            this.lblSpellDamageLabel.TabIndex = 77;
            this.lblSpellDamageLabel.Tag = "Label_Damage";
            this.lblSpellDamageLabel.Text = "Damage:";
            // 
            // lblSpellDVLabel
            // 
            this.lblSpellDVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpellDVLabel.AutoSize = true;
            this.lblSpellDVLabel.Location = new System.Drawing.Point(591, 110);
            this.lblSpellDVLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDVLabel.Name = "lblSpellDVLabel";
            this.lblSpellDVLabel.Size = new System.Drawing.Size(25, 13);
            this.lblSpellDVLabel.TabIndex = 81;
            this.lblSpellDVLabel.Tag = "Label_DV";
            this.lblSpellDVLabel.Text = "DV:";
            // 
            // lblMentorSpiritLabel
            // 
            this.lblMentorSpiritLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMentorSpiritLabel.AutoSize = true;
            this.lblMentorSpiritLabel.Location = new System.Drawing.Point(335, 293);
            this.lblMentorSpiritLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMentorSpiritLabel.Name = "lblMentorSpiritLabel";
            this.lblMentorSpiritLabel.Size = new System.Drawing.Size(69, 13);
            this.lblMentorSpiritLabel.TabIndex = 95;
            this.lblMentorSpiritLabel.Tag = "Label_MentorSpirit";
            this.lblMentorSpiritLabel.Text = "Mentor Spirit:";
            this.lblMentorSpiritLabel.Visible = false;
            // 
            // lblMentorSpirit
            // 
            this.lblMentorSpirit.AutoSize = true;
            this.tlpMagician.SetColumnSpan(this.lblMentorSpirit, 2);
            this.lblMentorSpirit.Location = new System.Drawing.Point(410, 293);
            this.lblMentorSpirit.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMentorSpirit.Name = "lblMentorSpirit";
            this.lblMentorSpirit.Size = new System.Drawing.Size(72, 13);
            this.lblMentorSpirit.TabIndex = 96;
            this.lblMentorSpirit.Text = "[Mentor Spirit]";
            this.lblMentorSpirit.Visible = false;
            // 
            // lblMentorSpiritInformation
            // 
            this.lblMentorSpiritInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMentorSpiritInformation.AutoSize = true;
            this.tlpMagician.SetColumnSpan(this.lblMentorSpiritInformation, 3);
            this.lblMentorSpiritInformation.Location = new System.Drawing.Point(304, 320);
            this.lblMentorSpiritInformation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMentorSpiritInformation.Name = "lblMentorSpiritInformation";
            this.tlpMagician.SetRowSpan(this.lblMentorSpiritInformation, 2);
            this.lblMentorSpiritInformation.Size = new System.Drawing.Size(312, 88);
            this.lblMentorSpiritInformation.TabIndex = 94;
            this.lblMentorSpiritInformation.Text = "[Mentor Spirit Information]";
            this.lblMentorSpiritInformation.Visible = false;
            // 
            // tabAdept
            // 
            this.tabAdept.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdept.Controls.Add(this.tabPowerUc);
            this.tabAdept.Location = new System.Drawing.Point(4, 22);
            this.tabAdept.Name = "tabAdept";
            this.tabAdept.Size = new System.Drawing.Size(841, 631);
            this.tabAdept.TabIndex = 2;
            this.tabAdept.Tag = "Tab_Adept";
            this.tabAdept.Text = "Adept Powers";
            // 
            // tabPowerUc
            // 
            this.tabPowerUc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPowerUc.Location = new System.Drawing.Point(0, 0);
            this.tabPowerUc.Name = "tabPowerUc";
            this.tabPowerUc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPowerUc.Size = new System.Drawing.Size(841, 631);
            this.tabPowerUc.TabIndex = 0;
            // 
            // tabTechnomancer
            // 
            this.tabTechnomancer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabTechnomancer.Controls.Add(this.tlpTechnomancer);
            this.tabTechnomancer.Location = new System.Drawing.Point(4, 22);
            this.tabTechnomancer.Name = "tabTechnomancer";
            this.tabTechnomancer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTechnomancer.Size = new System.Drawing.Size(841, 631);
            this.tabTechnomancer.TabIndex = 3;
            this.tabTechnomancer.Tag = "Tab_Technomancer";
            this.tabTechnomancer.Text = "Sprites and Complex Forms";
            // 
            // tlpTechnomancer
            // 
            this.tlpTechnomancer.ColumnCount = 5;
            this.tlpTechnomancer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpTechnomancer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTechnomancer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTechnomancer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTechnomancer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTechnomancer.Controls.Add(this.cmdAddSprite, 0, 10);
            this.tlpTechnomancer.Controls.Add(this.panSprites, 0, 11);
            this.tlpTechnomancer.Controls.Add(this.treComplexForms, 0, 1);
            this.tlpTechnomancer.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tlpTechnomancer.Controls.Add(this.lblTargetLabel, 1, 1);
            this.tlpTechnomancer.Controls.Add(this.lblFadingAttributesValue, 3, 7);
            this.tlpTechnomancer.Controls.Add(this.cboStream, 2, 6);
            this.tlpTechnomancer.Controls.Add(this.lblFadingAttributes, 2, 7);
            this.tlpTechnomancer.Controls.Add(this.lblFV, 2, 3);
            this.tlpTechnomancer.Controls.Add(this.lblFadingAttributesLabel, 1, 7);
            this.tlpTechnomancer.Controls.Add(this.lblTarget, 2, 1);
            this.tlpTechnomancer.Controls.Add(this.lblFVLabel, 1, 3);
            this.tlpTechnomancer.Controls.Add(this.lblDurationLabel, 1, 2);
            this.tlpTechnomancer.Controls.Add(this.lblStreamLabel, 1, 6);
            this.tlpTechnomancer.Controls.Add(this.lblDuration, 2, 2);
            this.tlpTechnomancer.Controls.Add(this.lblComplexFormSource, 2, 4);
            this.tlpTechnomancer.Controls.Add(this.lblComplexFormSourceLabel, 1, 4);
            this.tlpTechnomancer.Controls.Add(this.lblParagonInformation, 1, 9);
            this.tlpTechnomancer.Controls.Add(this.lblParagonLabel, 1, 8);
            this.tlpTechnomancer.Controls.Add(this.lblParagon, 2, 8);
            this.tlpTechnomancer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTechnomancer.Location = new System.Drawing.Point(3, 3);
            this.tlpTechnomancer.Name = "tlpTechnomancer";
            this.tlpTechnomancer.RowCount = 12;
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTechnomancer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTechnomancer.Size = new System.Drawing.Size(835, 625);
            this.tlpTechnomancer.TabIndex = 155;
            // 
            // cmdAddSprite
            // 
            this.cmdAddSprite.Location = new System.Drawing.Point(3, 417);
            this.cmdAddSprite.Name = "cmdAddSprite";
            this.cmdAddSprite.Size = new System.Drawing.Size(105, 23);
            this.cmdAddSprite.TabIndex = 26;
            this.cmdAddSprite.Tag = "Button_AddSprite";
            this.cmdAddSprite.Text = "&Add Sprite";
            this.cmdAddSprite.UseVisualStyleBackColor = true;
            this.cmdAddSprite.Click += new System.EventHandler(this.cmdAddSprite_Click);
            // 
            // panSprites
            // 
            this.panSprites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSprites.AutoScroll = true;
            this.panSprites.AutoSize = true;
            this.tlpTechnomancer.SetColumnSpan(this.panSprites, 5);
            this.panSprites.Location = new System.Drawing.Point(3, 446);
            this.panSprites.Name = "panSprites";
            this.panSprites.Size = new System.Drawing.Size(829, 176);
            this.panSprites.TabIndex = 25;
            // 
            // treComplexForms
            // 
            this.treComplexForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treComplexForms.HideSelection = false;
            this.treComplexForms.Location = new System.Drawing.Point(3, 32);
            this.treComplexForms.Name = "treComplexForms";
            treeNode15.Name = "nodProgramAdvancedRoot";
            treeNode15.Tag = "Node_SelectedAdvancedComplexForms";
            treeNode15.Text = "Selected Complex Forms";
            this.treComplexForms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.tlpTechnomancer.SetRowSpan(this.treComplexForms, 9);
            this.treComplexForms.ShowNodeToolTips = true;
            this.treComplexForms.ShowRootLines = false;
            this.treComplexForms.Size = new System.Drawing.Size(295, 379);
            this.treComplexForms.TabIndex = 71;
            this.treComplexForms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treComplexForms_AfterSelect);
            this.treComplexForms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treComplexForms_KeyDown);
            this.treComplexForms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTechnomancer.SetColumnSpan(this.flowLayoutPanel5, 5);
            this.flowLayoutPanel5.Controls.Add(this.cmdAddComplexForm);
            this.flowLayoutPanel5.Controls.Add(this.cmdDeleteComplexForm);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(197, 29);
            this.flowLayoutPanel5.TabIndex = 154;
            // 
            // cmdAddComplexForm
            // 
            this.cmdAddComplexForm.AutoSize = true;
            this.cmdAddComplexForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddComplexForm.ContextMenuStrip = this.cmsComplexForm;
            this.cmdAddComplexForm.Location = new System.Drawing.Point(3, 3);
            this.cmdAddComplexForm.Name = "cmdAddComplexForm";
            this.cmdAddComplexForm.Size = new System.Drawing.Size(105, 23);
            this.cmdAddComplexForm.TabIndex = 147;
            this.cmdAddComplexForm.Tag = "Button_AddComplexForm";
            this.cmdAddComplexForm.Text = "Add Complex Form";
            this.cmdAddComplexForm.UseVisualStyleBackColor = true;
            this.cmdAddComplexForm.Click += new System.EventHandler(this.cmdAddComplexForm_Click);
            // 
            // cmdDeleteComplexForm
            // 
            this.cmdDeleteComplexForm.AutoSize = true;
            this.cmdDeleteComplexForm.Location = new System.Drawing.Point(114, 3);
            this.cmdDeleteComplexForm.Name = "cmdDeleteComplexForm";
            this.cmdDeleteComplexForm.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteComplexForm.TabIndex = 31;
            this.cmdDeleteComplexForm.Tag = "String_Delete";
            this.cmdDeleteComplexForm.Text = "Delete";
            this.cmdDeleteComplexForm.UseVisualStyleBackColor = true;
            this.cmdDeleteComplexForm.Click += new System.EventHandler(this.cmdDeleteComplexForm_Click);
            // 
            // lblTargetLabel
            // 
            this.lblTargetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTargetLabel.AutoSize = true;
            this.lblTargetLabel.Location = new System.Drawing.Point(363, 35);
            this.lblTargetLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTargetLabel.Name = "lblTargetLabel";
            this.lblTargetLabel.Size = new System.Drawing.Size(41, 13);
            this.lblTargetLabel.TabIndex = 148;
            this.lblTargetLabel.Tag = "Label_SelectComplexForm_Target";
            this.lblTargetLabel.Text = "Target:";
            // 
            // lblFadingAttributesValue
            // 
            this.lblFadingAttributesValue.AutoSize = true;
            this.lblFadingAttributesValue.Location = new System.Drawing.Point(516, 187);
            this.lblFadingAttributesValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFadingAttributesValue.Name = "lblFadingAttributesValue";
            this.lblFadingAttributesValue.Size = new System.Drawing.Size(37, 13);
            this.lblFadingAttributesValue.TabIndex = 98;
            this.lblFadingAttributesValue.Text = "[Total]";
            this.lblFadingAttributesValue.ToolTipText = "";
            // 
            // cboStream
            // 
            this.cboStream.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTechnomancer.SetColumnSpan(this.cboStream, 2);
            this.cboStream.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStream.FormattingEnabled = true;
            this.cboStream.Location = new System.Drawing.Point(410, 157);
            this.cboStream.Name = "cboStream";
            this.cboStream.Size = new System.Drawing.Size(206, 21);
            this.cboStream.TabIndex = 101;
            this.cboStream.TooltipText = "";
            this.cboStream.SelectedIndexChanged += new System.EventHandler(this.cboStream_SelectedIndexChanged);
            // 
            // lblFadingAttributes
            // 
            this.lblFadingAttributes.AutoSize = true;
            this.lblFadingAttributes.Location = new System.Drawing.Point(410, 187);
            this.lblFadingAttributes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFadingAttributes.Name = "lblFadingAttributes";
            this.lblFadingAttributes.Size = new System.Drawing.Size(57, 13);
            this.lblFadingAttributes.TabIndex = 97;
            this.lblFadingAttributes.Text = "[Attributes]";
            // 
            // lblFV
            // 
            this.lblFV.AutoSize = true;
            this.lblFV.Location = new System.Drawing.Point(410, 85);
            this.lblFV.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFV.Name = "lblFV";
            this.lblFV.Size = new System.Drawing.Size(39, 13);
            this.lblFV.TabIndex = 153;
            this.lblFV.Text = "[None]";
            // 
            // lblFadingAttributesLabel
            // 
            this.lblFadingAttributesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFadingAttributesLabel.AutoSize = true;
            this.lblFadingAttributesLabel.Location = new System.Drawing.Point(308, 187);
            this.lblFadingAttributesLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFadingAttributesLabel.Name = "lblFadingAttributesLabel";
            this.lblFadingAttributesLabel.Size = new System.Drawing.Size(96, 13);
            this.lblFadingAttributesLabel.TabIndex = 96;
            this.lblFadingAttributesLabel.Tag = "Label_ResistFading";
            this.lblFadingAttributesLabel.Text = "Resist Fading with:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(410, 35);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(39, 13);
            this.lblTarget.TabIndex = 149;
            this.lblTarget.Text = "[None]";
            // 
            // lblFVLabel
            // 
            this.lblFVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFVLabel.AutoSize = true;
            this.lblFVLabel.Location = new System.Drawing.Point(381, 85);
            this.lblFVLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFVLabel.Name = "lblFVLabel";
            this.lblFVLabel.Size = new System.Drawing.Size(23, 13);
            this.lblFVLabel.TabIndex = 152;
            this.lblFVLabel.Tag = "Label_SelectComplexForm_FV";
            this.lblFVLabel.Text = "FV:";
            // 
            // lblDurationLabel
            // 
            this.lblDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDurationLabel.AutoSize = true;
            this.lblDurationLabel.Location = new System.Drawing.Point(354, 60);
            this.lblDurationLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDurationLabel.Name = "lblDurationLabel";
            this.lblDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.lblDurationLabel.TabIndex = 150;
            this.lblDurationLabel.Tag = "Label_SelectComplexForm_Duration";
            this.lblDurationLabel.Text = "Duration:";
            // 
            // lblStreamLabel
            // 
            this.lblStreamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreamLabel.AutoSize = true;
            this.lblStreamLabel.Location = new System.Drawing.Point(361, 160);
            this.lblStreamLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblStreamLabel.Name = "lblStreamLabel";
            this.lblStreamLabel.Size = new System.Drawing.Size(43, 13);
            this.lblStreamLabel.TabIndex = 100;
            this.lblStreamLabel.Tag = "Label_Stream";
            this.lblStreamLabel.Text = "Stream:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(410, 60);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(39, 13);
            this.lblDuration.TabIndex = 151;
            this.lblDuration.Text = "[None]";
            // 
            // lblComplexFormSource
            // 
            this.lblComplexFormSource.AutoSize = true;
            this.lblComplexFormSource.Location = new System.Drawing.Point(410, 110);
            this.lblComplexFormSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComplexFormSource.Name = "lblComplexFormSource";
            this.lblComplexFormSource.Size = new System.Drawing.Size(47, 13);
            this.lblComplexFormSource.TabIndex = 90;
            this.lblComplexFormSource.Text = "[Source]";
            this.lblComplexFormSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblComplexFormSourceLabel
            // 
            this.lblComplexFormSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplexFormSourceLabel.AutoSize = true;
            this.lblComplexFormSourceLabel.Location = new System.Drawing.Point(360, 110);
            this.lblComplexFormSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComplexFormSourceLabel.Name = "lblComplexFormSourceLabel";
            this.lblComplexFormSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblComplexFormSourceLabel.TabIndex = 89;
            this.lblComplexFormSourceLabel.Tag = "Label_Source";
            this.lblComplexFormSourceLabel.Text = "Source:";
            // 
            // lblParagonInformation
            // 
            this.lblParagonInformation.AutoSize = true;
            this.tlpTechnomancer.SetColumnSpan(this.lblParagonInformation, 3);
            this.lblParagonInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParagonInformation.Location = new System.Drawing.Point(304, 237);
            this.lblParagonInformation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblParagonInformation.Name = "lblParagonInformation";
            this.lblParagonInformation.Size = new System.Drawing.Size(312, 171);
            this.lblParagonInformation.TabIndex = 184;
            this.lblParagonInformation.Text = "[Paragon Information]";
            this.lblParagonInformation.Visible = false;
            // 
            // lblParagonLabel
            // 
            this.lblParagonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParagonLabel.AutoSize = true;
            this.lblParagonLabel.Location = new System.Drawing.Point(354, 212);
            this.lblParagonLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblParagonLabel.Name = "lblParagonLabel";
            this.lblParagonLabel.Size = new System.Drawing.Size(50, 13);
            this.lblParagonLabel.TabIndex = 185;
            this.lblParagonLabel.Tag = "Label_Paragon";
            this.lblParagonLabel.Text = "Paragon:";
            // 
            // lblParagon
            // 
            this.lblParagon.AutoSize = true;
            this.tlpTechnomancer.SetColumnSpan(this.lblParagon, 2);
            this.lblParagon.Location = new System.Drawing.Point(410, 212);
            this.lblParagon.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblParagon.Name = "lblParagon";
            this.lblParagon.Size = new System.Drawing.Size(53, 13);
            this.lblParagon.TabIndex = 186;
            this.lblParagon.Text = "[Paragon]";
            // 
            // tabAdvancedPrograms
            // 
            this.tabAdvancedPrograms.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabAdvancedPrograms.Controls.Add(this.tlpAdvancedPrograms);
            this.tabAdvancedPrograms.Location = new System.Drawing.Point(4, 22);
            this.tabAdvancedPrograms.Name = "tabAdvancedPrograms";
            this.tabAdvancedPrograms.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvancedPrograms.Size = new System.Drawing.Size(841, 631);
            this.tabAdvancedPrograms.TabIndex = 15;
            this.tabAdvancedPrograms.Tag = "Tab_AdvancedPrograms";
            this.tabAdvancedPrograms.Text = "Advanced Programs";
            // 
            // tlpAdvancedPrograms
            // 
            this.tlpAdvancedPrograms.AutoSize = true;
            this.tlpAdvancedPrograms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAdvancedPrograms.ColumnCount = 3;
            this.tlpAdvancedPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpAdvancedPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAdvancedPrograms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAdvancedPrograms.Controls.Add(this.treAIPrograms, 0, 1);
            this.tlpAdvancedPrograms.Controls.Add(this.lblAIProgramsSource, 2, 2);
            this.tlpAdvancedPrograms.Controls.Add(this.flowLayoutPanel6, 0, 0);
            this.tlpAdvancedPrograms.Controls.Add(this.lblAIProgramsRequires, 2, 1);
            this.tlpAdvancedPrograms.Controls.Add(this.lblAIProgramsRequiresLabel, 1, 1);
            this.tlpAdvancedPrograms.Controls.Add(this.lblAIProgramsSourceLabel, 1, 2);
            this.tlpAdvancedPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAdvancedPrograms.Location = new System.Drawing.Point(3, 3);
            this.tlpAdvancedPrograms.Name = "tlpAdvancedPrograms";
            this.tlpAdvancedPrograms.RowCount = 3;
            this.tlpAdvancedPrograms.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvancedPrograms.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvancedPrograms.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAdvancedPrograms.Size = new System.Drawing.Size(835, 625);
            this.tlpAdvancedPrograms.TabIndex = 152;
            // 
            // treAIPrograms
            // 
            this.treAIPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treAIPrograms.HideSelection = false;
            this.treAIPrograms.Location = new System.Drawing.Point(3, 32);
            this.treAIPrograms.Name = "treAIPrograms";
            treeNode16.Name = "nodAIProgramsRoot";
            treeNode16.Tag = "Node_SelectedAIPrograms";
            treeNode16.Text = "Selected AI Programs and Advanced Programs";
            this.treAIPrograms.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.tlpAdvancedPrograms.SetRowSpan(this.treAIPrograms, 2);
            this.treAIPrograms.ShowNodeToolTips = true;
            this.treAIPrograms.ShowRootLines = false;
            this.treAIPrograms.Size = new System.Drawing.Size(295, 590);
            this.treAIPrograms.TabIndex = 71;
            this.treAIPrograms.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treAIPrograms_AfterSelect);
            this.treAIPrograms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treAIPrograms_KeyDown);
            // 
            // lblAIProgramsSource
            // 
            this.lblAIProgramsSource.AutoSize = true;
            this.lblAIProgramsSource.Location = new System.Drawing.Point(362, 60);
            this.lblAIProgramsSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAIProgramsSource.Name = "lblAIProgramsSource";
            this.lblAIProgramsSource.Size = new System.Drawing.Size(47, 13);
            this.lblAIProgramsSource.TabIndex = 90;
            this.lblAIProgramsSource.Text = "[Source]";
            this.lblAIProgramsSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAdvancedPrograms.SetColumnSpan(this.flowLayoutPanel6, 3);
            this.flowLayoutPanel6.Controls.Add(this.cmdAddAIProgram);
            this.flowLayoutPanel6.Controls.Add(this.cmdDeleteAIProgram);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(196, 29);
            this.flowLayoutPanel6.TabIndex = 151;
            // 
            // cmdAddAIProgram
            // 
            this.cmdAddAIProgram.AutoSize = true;
            this.cmdAddAIProgram.Location = new System.Drawing.Point(3, 3);
            this.cmdAddAIProgram.Name = "cmdAddAIProgram";
            this.cmdAddAIProgram.Size = new System.Drawing.Size(104, 23);
            this.cmdAddAIProgram.TabIndex = 150;
            this.cmdAddAIProgram.Tag = "Button_AddProgram";
            this.cmdAddAIProgram.Text = "Add Program";
            this.cmdAddAIProgram.UseVisualStyleBackColor = true;
            this.cmdAddAIProgram.Click += new System.EventHandler(this.cmdAddAIProgram_Click);
            // 
            // cmdDeleteAIProgram
            // 
            this.cmdDeleteAIProgram.AutoSize = true;
            this.cmdDeleteAIProgram.Location = new System.Drawing.Point(113, 3);
            this.cmdDeleteAIProgram.Name = "cmdDeleteAIProgram";
            this.cmdDeleteAIProgram.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteAIProgram.TabIndex = 31;
            this.cmdDeleteAIProgram.Tag = "String_Delete";
            this.cmdDeleteAIProgram.Text = "Delete";
            this.cmdDeleteAIProgram.UseVisualStyleBackColor = true;
            this.cmdDeleteAIProgram.Click += new System.EventHandler(this.cmdDeleteAIProgram_Click);
            // 
            // lblAIProgramsRequires
            // 
            this.lblAIProgramsRequires.AutoSize = true;
            this.lblAIProgramsRequires.Location = new System.Drawing.Point(362, 35);
            this.lblAIProgramsRequires.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAIProgramsRequires.Name = "lblAIProgramsRequires";
            this.lblAIProgramsRequires.Size = new System.Drawing.Size(39, 13);
            this.lblAIProgramsRequires.TabIndex = 149;
            this.lblAIProgramsRequires.Tag = "";
            this.lblAIProgramsRequires.Text = "[None]";
            // 
            // lblAIProgramsRequiresLabel
            // 
            this.lblAIProgramsRequiresLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAIProgramsRequiresLabel.AutoSize = true;
            this.lblAIProgramsRequiresLabel.Location = new System.Drawing.Point(304, 35);
            this.lblAIProgramsRequiresLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAIProgramsRequiresLabel.Name = "lblAIProgramsRequiresLabel";
            this.lblAIProgramsRequiresLabel.Size = new System.Drawing.Size(52, 13);
            this.lblAIProgramsRequiresLabel.TabIndex = 148;
            this.lblAIProgramsRequiresLabel.Tag = "String_Requires";
            this.lblAIProgramsRequiresLabel.Text = "Requires:";
            // 
            // lblAIProgramsSourceLabel
            // 
            this.lblAIProgramsSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAIProgramsSourceLabel.AutoSize = true;
            this.lblAIProgramsSourceLabel.Location = new System.Drawing.Point(312, 60);
            this.lblAIProgramsSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAIProgramsSourceLabel.Name = "lblAIProgramsSourceLabel";
            this.lblAIProgramsSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblAIProgramsSourceLabel.TabIndex = 89;
            this.lblAIProgramsSourceLabel.Tag = "Label_Source";
            this.lblAIProgramsSourceLabel.Text = "Source:";
            // 
            // tabCritter
            // 
            this.tabCritter.BackColor = System.Drawing.SystemColors.Control;
            this.tabCritter.Controls.Add(this.tlpCritter);
            this.tabCritter.Location = new System.Drawing.Point(4, 22);
            this.tabCritter.Name = "tabCritter";
            this.tabCritter.Padding = new System.Windows.Forms.Padding(3);
            this.tabCritter.Size = new System.Drawing.Size(841, 631);
            this.tabCritter.TabIndex = 11;
            this.tabCritter.Tag = "Tab_Critter";
            this.tabCritter.Text = "Critter Powers";
            // 
            // tlpCritter
            // 
            this.tlpCritter.ColumnCount = 3;
            this.tlpCritter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpCritter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCritter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCritter.Controls.Add(this.treCritterPowers, 0, 1);
            this.tlpCritter.Controls.Add(this.chkCritterPowerCount, 1, 9);
            this.tlpCritter.Controls.Add(this.lblCritterPowerPointsLabel, 1, 0);
            this.tlpCritter.Controls.Add(this.lblCritterPowerPointCost, 2, 8);
            this.tlpCritter.Controls.Add(this.lblCritterPowerPoints, 2, 0);
            this.tlpCritter.Controls.Add(this.lblCritterPowerPointCostLabel, 1, 8);
            this.tlpCritter.Controls.Add(this.lblCritterPowerNameLabel, 1, 1);
            this.tlpCritter.Controls.Add(this.lblCritterPowerName, 2, 1);
            this.tlpCritter.Controls.Add(this.lblCritterPowerCategoryLabel, 1, 2);
            this.tlpCritter.Controls.Add(this.lblCritterPowerSource, 2, 7);
            this.tlpCritter.Controls.Add(this.lblCritterPowerCategory, 2, 2);
            this.tlpCritter.Controls.Add(this.lblCritterPowerSourceLabel, 1, 7);
            this.tlpCritter.Controls.Add(this.lblCritterPowerTypeLabel, 1, 3);
            this.tlpCritter.Controls.Add(this.lblCritterPowerDurationLabel, 1, 6);
            this.tlpCritter.Controls.Add(this.lblCritterPowerDuration, 2, 6);
            this.tlpCritter.Controls.Add(this.lblCritterPowerType, 2, 3);
            this.tlpCritter.Controls.Add(this.lblCritterPowerActionLabel, 1, 4);
            this.tlpCritter.Controls.Add(this.lblCritterPowerRange, 2, 5);
            this.tlpCritter.Controls.Add(this.lblCritterPowerAction, 2, 4);
            this.tlpCritter.Controls.Add(this.lblCritterPowerRangeLabel, 1, 5);
            this.tlpCritter.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tlpCritter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCritter.Location = new System.Drawing.Point(3, 3);
            this.tlpCritter.Name = "tlpCritter";
            this.tlpCritter.RowCount = 10;
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCritter.Size = new System.Drawing.Size(835, 625);
            this.tlpCritter.TabIndex = 22;
            // 
            // treCritterPowers
            // 
            this.treCritterPowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treCritterPowers.HideSelection = false;
            this.treCritterPowers.Location = new System.Drawing.Point(3, 32);
            this.treCritterPowers.Name = "treCritterPowers";
            treeNode17.Name = "nodCritterPowerRoot";
            treeNode17.Tag = "Node_CritterPowers";
            treeNode17.Text = "Critter Powers";
            treeNode18.Name = "nodCritterWeaknessRoot";
            treeNode18.Tag = "Node_CritterWeaknesses";
            treeNode18.Text = "Weaknesses";
            this.treCritterPowers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18});
            this.tlpCritter.SetRowSpan(this.treCritterPowers, 9);
            this.treCritterPowers.ShowNodeToolTips = true;
            this.treCritterPowers.ShowPlusMinus = false;
            this.treCritterPowers.ShowRootLines = false;
            this.treCritterPowers.Size = new System.Drawing.Size(295, 590);
            this.treCritterPowers.TabIndex = 0;
            this.treCritterPowers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treCritterPowers_AfterSelect);
            this.treCritterPowers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treCritterPowers_KeyDown);
            this.treCritterPowers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // chkCritterPowerCount
            // 
            this.chkCritterPowerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCritterPowerCount.AutoSize = true;
            this.chkCritterPowerCount.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tlpCritter.SetColumnSpan(this.chkCritterPowerCount, 2);
            this.chkCritterPowerCount.Location = new System.Drawing.Point(304, 233);
            this.chkCritterPowerCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCritterPowerCount.Name = "chkCritterPowerCount";
            this.chkCritterPowerCount.Size = new System.Drawing.Size(528, 388);
            this.chkCritterPowerCount.TabIndex = 21;
            this.chkCritterPowerCount.Tag = "Checkbox_CritterPowerCount";
            this.chkCritterPowerCount.Text = "Counts towards Critter Power limit";
            this.chkCritterPowerCount.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkCritterPowerCount.UseVisualStyleBackColor = true;
            this.chkCritterPowerCount.CheckedChanged += new System.EventHandler(this.chkCritterPowerCount_CheckedChanged);
            // 
            // lblCritterPowerPointsLabel
            // 
            this.lblCritterPowerPointsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerPointsLabel.AutoSize = true;
            this.lblCritterPowerPointsLabel.Location = new System.Drawing.Point(304, 10);
            this.lblCritterPowerPointsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerPointsLabel.Name = "lblCritterPowerPointsLabel";
            this.lblCritterPowerPointsLabel.Size = new System.Drawing.Size(72, 13);
            this.lblCritterPowerPointsLabel.TabIndex = 17;
            this.lblCritterPowerPointsLabel.Tag = "Label_PowerPoints";
            this.lblCritterPowerPointsLabel.Text = "Power Points:";
            this.lblCritterPowerPointsLabel.Visible = false;
            // 
            // lblCritterPowerPointCost
            // 
            this.lblCritterPowerPointCost.AutoSize = true;
            this.lblCritterPowerPointCost.Location = new System.Drawing.Point(382, 210);
            this.lblCritterPowerPointCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerPointCost.Name = "lblCritterPowerPointCost";
            this.lblCritterPowerPointCost.Size = new System.Drawing.Size(75, 13);
            this.lblCritterPowerPointCost.TabIndex = 20;
            this.lblCritterPowerPointCost.Text = "[Power Points]";
            this.lblCritterPowerPointCost.Visible = false;
            // 
            // lblCritterPowerPoints
            // 
            this.lblCritterPowerPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCritterPowerPoints.AutoSize = true;
            this.lblCritterPowerPoints.Location = new System.Drawing.Point(382, 10);
            this.lblCritterPowerPoints.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerPoints.Name = "lblCritterPowerPoints";
            this.lblCritterPowerPoints.Size = new System.Drawing.Size(76, 13);
            this.lblCritterPowerPoints.TabIndex = 18;
            this.lblCritterPowerPoints.Text = "0 (0 remaining)";
            this.lblCritterPowerPoints.Visible = false;
            // 
            // lblCritterPowerPointCostLabel
            // 
            this.lblCritterPowerPointCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerPointCostLabel.AutoSize = true;
            this.lblCritterPowerPointCostLabel.Location = new System.Drawing.Point(337, 210);
            this.lblCritterPowerPointCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerPointCostLabel.Name = "lblCritterPowerPointCostLabel";
            this.lblCritterPowerPointCostLabel.Size = new System.Drawing.Size(39, 13);
            this.lblCritterPowerPointCostLabel.TabIndex = 19;
            this.lblCritterPowerPointCostLabel.Tag = "Label_Points";
            this.lblCritterPowerPointCostLabel.Text = "Points:";
            this.lblCritterPowerPointCostLabel.Visible = false;
            // 
            // lblCritterPowerNameLabel
            // 
            this.lblCritterPowerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerNameLabel.AutoSize = true;
            this.lblCritterPowerNameLabel.Location = new System.Drawing.Point(338, 35);
            this.lblCritterPowerNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerNameLabel.Name = "lblCritterPowerNameLabel";
            this.lblCritterPowerNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblCritterPowerNameLabel.TabIndex = 1;
            this.lblCritterPowerNameLabel.Tag = "Label_Name";
            this.lblCritterPowerNameLabel.Text = "Name:";
            // 
            // lblCritterPowerName
            // 
            this.lblCritterPowerName.AutoSize = true;
            this.lblCritterPowerName.Location = new System.Drawing.Point(382, 35);
            this.lblCritterPowerName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerName.Name = "lblCritterPowerName";
            this.lblCritterPowerName.Size = new System.Drawing.Size(41, 13);
            this.lblCritterPowerName.TabIndex = 2;
            this.lblCritterPowerName.Text = "[Name]";
            // 
            // lblCritterPowerCategoryLabel
            // 
            this.lblCritterPowerCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerCategoryLabel.AutoSize = true;
            this.lblCritterPowerCategoryLabel.Location = new System.Drawing.Point(324, 60);
            this.lblCritterPowerCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerCategoryLabel.Name = "lblCritterPowerCategoryLabel";
            this.lblCritterPowerCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblCritterPowerCategoryLabel.TabIndex = 3;
            this.lblCritterPowerCategoryLabel.Tag = "Label_Category";
            this.lblCritterPowerCategoryLabel.Text = "Category:";
            // 
            // lblCritterPowerSource
            // 
            this.lblCritterPowerSource.AutoSize = true;
            this.lblCritterPowerSource.Location = new System.Drawing.Point(382, 185);
            this.lblCritterPowerSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerSource.Name = "lblCritterPowerSource";
            this.lblCritterPowerSource.Size = new System.Drawing.Size(47, 13);
            this.lblCritterPowerSource.TabIndex = 14;
            this.lblCritterPowerSource.Text = "[Source]";
            this.lblCritterPowerSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblCritterPowerCategory
            // 
            this.lblCritterPowerCategory.AutoSize = true;
            this.lblCritterPowerCategory.Location = new System.Drawing.Point(382, 60);
            this.lblCritterPowerCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerCategory.Name = "lblCritterPowerCategory";
            this.lblCritterPowerCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCritterPowerCategory.TabIndex = 4;
            this.lblCritterPowerCategory.Text = "[Category]";
            // 
            // lblCritterPowerSourceLabel
            // 
            this.lblCritterPowerSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerSourceLabel.AutoSize = true;
            this.lblCritterPowerSourceLabel.Location = new System.Drawing.Point(332, 185);
            this.lblCritterPowerSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerSourceLabel.Name = "lblCritterPowerSourceLabel";
            this.lblCritterPowerSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblCritterPowerSourceLabel.TabIndex = 13;
            this.lblCritterPowerSourceLabel.Tag = "Label_Source";
            this.lblCritterPowerSourceLabel.Text = "Source:";
            // 
            // lblCritterPowerTypeLabel
            // 
            this.lblCritterPowerTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerTypeLabel.AutoSize = true;
            this.lblCritterPowerTypeLabel.Location = new System.Drawing.Point(342, 85);
            this.lblCritterPowerTypeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerTypeLabel.Name = "lblCritterPowerTypeLabel";
            this.lblCritterPowerTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.lblCritterPowerTypeLabel.TabIndex = 5;
            this.lblCritterPowerTypeLabel.Tag = "Label_Type";
            this.lblCritterPowerTypeLabel.Text = "Type:";
            // 
            // lblCritterPowerDurationLabel
            // 
            this.lblCritterPowerDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerDurationLabel.AutoSize = true;
            this.lblCritterPowerDurationLabel.Location = new System.Drawing.Point(326, 160);
            this.lblCritterPowerDurationLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerDurationLabel.Name = "lblCritterPowerDurationLabel";
            this.lblCritterPowerDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.lblCritterPowerDurationLabel.TabIndex = 11;
            this.lblCritterPowerDurationLabel.Tag = "Label_Duration";
            this.lblCritterPowerDurationLabel.Text = "Duration:";
            // 
            // lblCritterPowerDuration
            // 
            this.lblCritterPowerDuration.AutoSize = true;
            this.lblCritterPowerDuration.Location = new System.Drawing.Point(382, 160);
            this.lblCritterPowerDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerDuration.Name = "lblCritterPowerDuration";
            this.lblCritterPowerDuration.Size = new System.Drawing.Size(53, 13);
            this.lblCritterPowerDuration.TabIndex = 12;
            this.lblCritterPowerDuration.Text = "[Duration]";
            // 
            // lblCritterPowerType
            // 
            this.lblCritterPowerType.AutoSize = true;
            this.lblCritterPowerType.Location = new System.Drawing.Point(382, 85);
            this.lblCritterPowerType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerType.Name = "lblCritterPowerType";
            this.lblCritterPowerType.Size = new System.Drawing.Size(37, 13);
            this.lblCritterPowerType.TabIndex = 6;
            this.lblCritterPowerType.Text = "[Type]";
            // 
            // lblCritterPowerActionLabel
            // 
            this.lblCritterPowerActionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerActionLabel.AutoSize = true;
            this.lblCritterPowerActionLabel.Location = new System.Drawing.Point(336, 110);
            this.lblCritterPowerActionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerActionLabel.Name = "lblCritterPowerActionLabel";
            this.lblCritterPowerActionLabel.Size = new System.Drawing.Size(40, 13);
            this.lblCritterPowerActionLabel.TabIndex = 7;
            this.lblCritterPowerActionLabel.Tag = "Label_Action";
            this.lblCritterPowerActionLabel.Text = "Action:";
            // 
            // lblCritterPowerRange
            // 
            this.lblCritterPowerRange.AutoSize = true;
            this.lblCritterPowerRange.Location = new System.Drawing.Point(382, 135);
            this.lblCritterPowerRange.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerRange.Name = "lblCritterPowerRange";
            this.lblCritterPowerRange.Size = new System.Drawing.Size(45, 13);
            this.lblCritterPowerRange.TabIndex = 10;
            this.lblCritterPowerRange.Text = "[Range]";
            // 
            // lblCritterPowerAction
            // 
            this.lblCritterPowerAction.AutoSize = true;
            this.lblCritterPowerAction.Location = new System.Drawing.Point(382, 110);
            this.lblCritterPowerAction.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerAction.Name = "lblCritterPowerAction";
            this.lblCritterPowerAction.Size = new System.Drawing.Size(43, 13);
            this.lblCritterPowerAction.TabIndex = 8;
            this.lblCritterPowerAction.Text = "[Action]";
            // 
            // lblCritterPowerRangeLabel
            // 
            this.lblCritterPowerRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCritterPowerRangeLabel.AutoSize = true;
            this.lblCritterPowerRangeLabel.Location = new System.Drawing.Point(334, 135);
            this.lblCritterPowerRangeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCritterPowerRangeLabel.Name = "lblCritterPowerRangeLabel";
            this.lblCritterPowerRangeLabel.Size = new System.Drawing.Size(42, 13);
            this.lblCritterPowerRangeLabel.TabIndex = 9;
            this.lblCritterPowerRangeLabel.Tag = "Label_Range";
            this.lblCritterPowerRangeLabel.Text = "Range:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.cmdAddCritterPower);
            this.flowLayoutPanel1.Controls.Add(this.cmdDeleteCritterPower);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(172, 29);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // cmdAddCritterPower
            // 
            this.cmdAddCritterPower.AutoSize = true;
            this.cmdAddCritterPower.Location = new System.Drawing.Point(3, 3);
            this.cmdAddCritterPower.Name = "cmdAddCritterPower";
            this.cmdAddCritterPower.Size = new System.Drawing.Size(80, 23);
            this.cmdAddCritterPower.TabIndex = 15;
            this.cmdAddCritterPower.Tag = "Button_AddCritterPower";
            this.cmdAddCritterPower.Text = "&Add Power";
            this.cmdAddCritterPower.UseVisualStyleBackColor = true;
            this.cmdAddCritterPower.Click += new System.EventHandler(this.cmdAddCritterPower_Click);
            // 
            // cmdDeleteCritterPower
            // 
            this.cmdDeleteCritterPower.AutoSize = true;
            this.cmdDeleteCritterPower.Location = new System.Drawing.Point(89, 3);
            this.cmdDeleteCritterPower.Name = "cmdDeleteCritterPower";
            this.cmdDeleteCritterPower.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteCritterPower.TabIndex = 16;
            this.cmdDeleteCritterPower.Tag = "String_Delete";
            this.cmdDeleteCritterPower.Text = "Delete";
            this.cmdDeleteCritterPower.UseVisualStyleBackColor = true;
            this.cmdDeleteCritterPower.Click += new System.EventHandler(this.cmdDeleteCritterPower_Click);
            // 
            // tabInitiation
            // 
            this.tabInitiation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabInitiation.Controls.Add(this.tlpInitiation);
            this.tabInitiation.Location = new System.Drawing.Point(4, 22);
            this.tabInitiation.Name = "tabInitiation";
            this.tabInitiation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInitiation.Size = new System.Drawing.Size(841, 631);
            this.tabInitiation.TabIndex = 10;
            this.tabInitiation.Tag = "Tab_Initiation";
            this.tabInitiation.Text = "Initiation & Submersion";
            // 
            // tlpInitiation
            // 
            this.tlpInitiation.ColumnCount = 3;
            this.tlpInitiation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpInitiation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInitiation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInitiation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInitiation.Controls.Add(this.treMetamagic, 0, 3);
            this.tlpInitiation.Controls.Add(this.lblMetamagicSourceLabel, 1, 3);
            this.tlpInitiation.Controls.Add(this.lblMetamagicSource, 2, 3);
            this.tlpInitiation.Controls.Add(this.flpInitiationCheckBoxes, 0, 0);
            this.tlpInitiation.Controls.Add(this.flpInitiationButtons, 0, 2);
            this.tlpInitiation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInitiation.Location = new System.Drawing.Point(3, 3);
            this.tlpInitiation.Name = "tlpInitiation";
            this.tlpInitiation.RowCount = 4;
            this.tlpInitiation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInitiation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInitiation.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInitiation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInitiation.Size = new System.Drawing.Size(835, 625);
            this.tlpInitiation.TabIndex = 130;
            // 
            // treMetamagic
            // 
            this.treMetamagic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treMetamagic.HideSelection = false;
            this.treMetamagic.Location = new System.Drawing.Point(3, 57);
            this.treMetamagic.Name = "treMetamagic";
            this.treMetamagic.ShowLines = false;
            this.treMetamagic.ShowNodeToolTips = true;
            this.treMetamagic.ShowPlusMinus = false;
            this.treMetamagic.ShowRootLines = false;
            this.treMetamagic.Size = new System.Drawing.Size(295, 565);
            this.treMetamagic.TabIndex = 96;
            this.treMetamagic.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treMetamagic_AfterSelect);
            this.treMetamagic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treMetamagic_KeyDown);
            this.treMetamagic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblMetamagicSourceLabel
            // 
            this.lblMetamagicSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMetamagicSourceLabel.AutoSize = true;
            this.lblMetamagicSourceLabel.Location = new System.Drawing.Point(304, 60);
            this.lblMetamagicSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetamagicSourceLabel.Name = "lblMetamagicSourceLabel";
            this.lblMetamagicSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblMetamagicSourceLabel.TabIndex = 108;
            this.lblMetamagicSourceLabel.Tag = "Label_Source";
            this.lblMetamagicSourceLabel.Text = "Source:";
            // 
            // lblMetamagicSource
            // 
            this.lblMetamagicSource.AutoSize = true;
            this.lblMetamagicSource.Location = new System.Drawing.Point(354, 60);
            this.lblMetamagicSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMetamagicSource.Name = "lblMetamagicSource";
            this.lblMetamagicSource.Size = new System.Drawing.Size(47, 13);
            this.lblMetamagicSource.TabIndex = 109;
            this.lblMetamagicSource.Text = "[Source]";
            this.lblMetamagicSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // flpInitiationCheckBoxes
            // 
            this.flpInitiationCheckBoxes.AutoSize = true;
            this.flpInitiationCheckBoxes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpInitiation.SetColumnSpan(this.flpInitiationCheckBoxes, 3);
            this.flpInitiationCheckBoxes.Controls.Add(this.chkInitiationOrdeal);
            this.flpInitiationCheckBoxes.Controls.Add(this.chkInitiationSchooling);
            this.flpInitiationCheckBoxes.Controls.Add(this.chkInitiationGroup);
            this.flpInitiationCheckBoxes.Location = new System.Drawing.Point(0, 0);
            this.flpInitiationCheckBoxes.Margin = new System.Windows.Forms.Padding(0);
            this.flpInitiationCheckBoxes.Name = "flpInitiationCheckBoxes";
            this.flpInitiationCheckBoxes.Size = new System.Drawing.Size(383, 25);
            this.flpInitiationCheckBoxes.TabIndex = 130;
            // 
            // chkInitiationOrdeal
            // 
            this.chkInitiationOrdeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInitiationOrdeal.AutoSize = true;
            this.chkInitiationOrdeal.Location = new System.Drawing.Point(3, 4);
            this.chkInitiationOrdeal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInitiationOrdeal.Name = "chkInitiationOrdeal";
            this.chkInitiationOrdeal.Size = new System.Drawing.Size(131, 17);
            this.chkInitiationOrdeal.TabIndex = 102;
            this.chkInitiationOrdeal.Tag = "Checkbox_InitiationOrdeal";
            this.chkInitiationOrdeal.Text = "Initiatory Ordeal (-10%)";
            this.chkInitiationOrdeal.UseVisualStyleBackColor = true;
            this.chkInitiationOrdeal.CheckedChanged += new System.EventHandler(this.chkInitiationOrdeal_CheckedChanged);
            // 
            // chkInitiationSchooling
            // 
            this.chkInitiationSchooling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInitiationSchooling.AutoSize = true;
            this.chkInitiationSchooling.Location = new System.Drawing.Point(140, 4);
            this.chkInitiationSchooling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInitiationSchooling.Name = "chkInitiationSchooling";
            this.chkInitiationSchooling.Size = new System.Drawing.Size(105, 17);
            this.chkInitiationSchooling.TabIndex = 129;
            this.chkInitiationSchooling.Tag = "Checkbox_InitiationSchooling";
            this.chkInitiationSchooling.Text = "Schooling (-10%)";
            this.chkInitiationSchooling.UseVisualStyleBackColor = true;
            this.chkInitiationSchooling.CheckedChanged += new System.EventHandler(this.chkInitiationSchooling_CheckedChanged);
            // 
            // chkInitiationGroup
            // 
            this.chkInitiationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInitiationGroup.AutoSize = true;
            this.chkInitiationGroup.Location = new System.Drawing.Point(251, 4);
            this.chkInitiationGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkInitiationGroup.Name = "chkInitiationGroup";
            this.chkInitiationGroup.Size = new System.Drawing.Size(129, 17);
            this.chkInitiationGroup.TabIndex = 101;
            this.chkInitiationGroup.Tag = "Checkbox_GroupInitiation";
            this.chkInitiationGroup.Text = "Group Initiation (-10%)";
            this.chkInitiationGroup.UseVisualStyleBackColor = true;
            this.chkInitiationGroup.CheckedChanged += new System.EventHandler(this.chkInitiationGroup_CheckedChanged);
            // 
            // flpInitiationButtons
            // 
            this.flpInitiationButtons.AutoSize = true;
            this.flpInitiationButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpInitiation.SetColumnSpan(this.flpInitiationButtons, 3);
            this.flpInitiationButtons.Controls.Add(this.cmdAddMetamagic);
            this.flpInitiationButtons.Controls.Add(this.cmdDeleteMetamagic);
            this.flpInitiationButtons.Location = new System.Drawing.Point(0, 25);
            this.flpInitiationButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpInitiationButtons.Name = "flpInitiationButtons";
            this.flpInitiationButtons.Size = new System.Drawing.Size(237, 29);
            this.flpInitiationButtons.TabIndex = 131;
            // 
            // cmdAddMetamagic
            // 
            this.cmdAddMetamagic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddMetamagic.AutoSize = true;
            this.cmdAddMetamagic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddMetamagic.Location = new System.Drawing.Point(3, 3);
            this.cmdAddMetamagic.Name = "cmdAddMetamagic";
            this.cmdAddMetamagic.Size = new System.Drawing.Size(102, 23);
            this.cmdAddMetamagic.TabIndex = 93;
            this.cmdAddMetamagic.Tag = "Button_AddInitiateGrade";
            this.cmdAddMetamagic.Text = "&Add Initiate Grade";
            this.cmdAddMetamagic.UseVisualStyleBackColor = true;
            this.cmdAddMetamagic.Click += new System.EventHandler(this.cmdAddMetamagic_Click);
            // 
            // cmdDeleteMetamagic
            // 
            this.cmdDeleteMetamagic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDeleteMetamagic.AutoSize = true;
            this.cmdDeleteMetamagic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdDeleteMetamagic.Location = new System.Drawing.Point(111, 3);
            this.cmdDeleteMetamagic.Name = "cmdDeleteMetamagic";
            this.cmdDeleteMetamagic.Size = new System.Drawing.Size(123, 23);
            this.cmdDeleteMetamagic.TabIndex = 94;
            this.cmdDeleteMetamagic.Tag = "Button_RemoveInitiateGrade";
            this.cmdDeleteMetamagic.Text = "&Remove Initiate Grade";
            this.cmdDeleteMetamagic.UseVisualStyleBackColor = true;
            this.cmdDeleteMetamagic.Click += new System.EventHandler(this.cmdDeleteMetamagic_Click);
            // 
            // tabCyberware
            // 
            this.tabCyberware.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabCyberware.Controls.Add(this.tlpCyberware);
            this.tabCyberware.Location = new System.Drawing.Point(4, 22);
            this.tabCyberware.Name = "tabCyberware";
            this.tabCyberware.Padding = new System.Windows.Forms.Padding(3);
            this.tabCyberware.Size = new System.Drawing.Size(841, 631);
            this.tabCyberware.TabIndex = 4;
            this.tabCyberware.Tag = "Tab_Cyberware";
            this.tabCyberware.Text = "Cyberware and Bioware";
            // 
            // tlpCyberware
            // 
            this.tlpCyberware.ColumnCount = 2;
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.Controls.Add(this.treCyberware, 0, 1);
            this.tlpCyberware.Controls.Add(this.flowLayoutPanel7, 0, 0);
            this.tlpCyberware.Controls.Add(this.flpCyberware, 1, 1);
            this.tlpCyberware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCyberware.Location = new System.Drawing.Point(3, 3);
            this.tlpCyberware.Name = "tlpCyberware";
            this.tlpCyberware.RowCount = 2;
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberware.Size = new System.Drawing.Size(835, 625);
            this.tlpCyberware.TabIndex = 250;
            // 
            // treCyberware
            // 
            this.treCyberware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treCyberware.HideSelection = false;
            this.treCyberware.Location = new System.Drawing.Point(3, 32);
            this.treCyberware.Name = "treCyberware";
            treeNode19.Name = "nodCyberwareRoot";
            treeNode19.Tag = "Node_SelectedCyberware";
            treeNode19.Text = "Selected Cyberware";
            treeNode20.Name = "nodBioware";
            treeNode20.Tag = "Node_SelectedBioware";
            treeNode20.Text = "Selected Bioware";
            treeNode21.Name = "nodUnequippedModularCyberware";
            treeNode21.Tag = "Node_UnequippedModularCyberware";
            treeNode21.Text = "Unequipped Modular Cyberware";
            this.treCyberware.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            this.treCyberware.ShowNodeToolTips = true;
            this.treCyberware.ShowRootLines = false;
            this.treCyberware.Size = new System.Drawing.Size(295, 590);
            this.treCyberware.TabIndex = 28;
            this.treCyberware.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treCyberware_AfterSelect);
            this.treCyberware.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treCyberware_KeyDown);
            this.treCyberware.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.tlpCyberware.SetColumnSpan(this.flowLayoutPanel7, 2);
            this.flowLayoutPanel7.Controls.Add(this.cmdAddCyberware);
            this.flowLayoutPanel7.Controls.Add(this.cmdAddBioware);
            this.flowLayoutPanel7.Controls.Add(this.cmdDeleteCyberware);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(295, 29);
            this.flowLayoutPanel7.TabIndex = 250;
            // 
            // cmdAddCyberware
            // 
            this.cmdAddCyberware.AutoSize = true;
            this.cmdAddCyberware.ContextMenuStrip = this.cmsCyberware;
            this.cmdAddCyberware.Location = new System.Drawing.Point(3, 3);
            this.cmdAddCyberware.Name = "cmdAddCyberware";
            this.cmdAddCyberware.Size = new System.Drawing.Size(107, 23);
            this.cmdAddCyberware.SplitMenuStrip = this.cmsCyberware;
            this.cmdAddCyberware.TabIndex = 91;
            this.cmdAddCyberware.Tag = "Button_AddCyberware";
            this.cmdAddCyberware.Text = "&Add Cyberware";
            this.cmdAddCyberware.UseVisualStyleBackColor = true;
            this.cmdAddCyberware.Click += new System.EventHandler(this.cmdAddCyberware_Click);
            // 
            // cmdAddBioware
            // 
            this.cmdAddBioware.AutoSize = true;
            this.cmdAddBioware.Location = new System.Drawing.Point(116, 3);
            this.cmdAddBioware.Name = "cmdAddBioware";
            this.cmdAddBioware.Size = new System.Drawing.Size(90, 23);
            this.cmdAddBioware.TabIndex = 46;
            this.cmdAddBioware.Tag = "Button_AddBioware";
            this.cmdAddBioware.Text = "A&dd Bioware";
            this.cmdAddBioware.UseVisualStyleBackColor = true;
            this.cmdAddBioware.Click += new System.EventHandler(this.cmdAddBioware_Click);
            // 
            // cmdDeleteCyberware
            // 
            this.cmdDeleteCyberware.AutoSize = true;
            this.cmdDeleteCyberware.Location = new System.Drawing.Point(212, 3);
            this.cmdDeleteCyberware.Name = "cmdDeleteCyberware";
            this.cmdDeleteCyberware.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteCyberware.TabIndex = 45;
            this.cmdDeleteCyberware.Tag = "String_Delete";
            this.cmdDeleteCyberware.Text = "Delete";
            this.cmdDeleteCyberware.UseVisualStyleBackColor = true;
            this.cmdDeleteCyberware.Click += new System.EventHandler(this.cmdDeleteCyberware_Click);
            // 
            // flpCyberware
            // 
            this.flpCyberware.AutoSize = true;
            this.flpCyberware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCyberware.Controls.Add(this.gpbEssenceConsumption);
            this.flpCyberware.Controls.Add(this.tlpCyberwareCommon);
            this.flpCyberware.Controls.Add(this.tlpCyberwareMatrix);
            this.flpCyberware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCyberware.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCyberware.Location = new System.Drawing.Point(301, 29);
            this.flpCyberware.Margin = new System.Windows.Forms.Padding(0);
            this.flpCyberware.Name = "flpCyberware";
            this.flpCyberware.Size = new System.Drawing.Size(534, 596);
            this.flpCyberware.TabIndex = 252;
            // 
            // gpbEssenceConsumption
            // 
            this.gpbEssenceConsumption.AutoSize = true;
            this.gpbEssenceConsumption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbEssenceConsumption.Controls.Add(this.tlpCyberwareEssenceConsumption);
            this.gpbEssenceConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbEssenceConsumption.Location = new System.Drawing.Point(3, 3);
            this.gpbEssenceConsumption.Name = "gpbEssenceConsumption";
            this.gpbEssenceConsumption.Size = new System.Drawing.Size(522, 119);
            this.gpbEssenceConsumption.TabIndex = 252;
            this.gpbEssenceConsumption.TabStop = false;
            this.gpbEssenceConsumption.Tag = "Label_EssenceConsumption";
            this.gpbEssenceConsumption.Text = "Essence Consumption";
            // 
            // tlpCyberwareEssenceConsumption
            // 
            this.tlpCyberwareEssenceConsumption.AutoSize = true;
            this.tlpCyberwareEssenceConsumption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCyberwareEssenceConsumption.ColumnCount = 2;
            this.tlpCyberwareEssenceConsumption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCyberwareEssenceConsumption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblCyberwareESSLabel, 0, 0);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblBiowareESSLabel, 0, 1);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblEssenceHoleESSLabel, 0, 2);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblPrototypeTranshumanESSLabel, 0, 3);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblCyberwareESS, 1, 0);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblBiowareESS, 1, 1);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblEssenceHoleESS, 1, 2);
            this.tlpCyberwareEssenceConsumption.Controls.Add(this.lblPrototypeTranshumanESS, 1, 3);
            this.tlpCyberwareEssenceConsumption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCyberwareEssenceConsumption.Location = new System.Drawing.Point(3, 16);
            this.tlpCyberwareEssenceConsumption.Name = "tlpCyberwareEssenceConsumption";
            this.tlpCyberwareEssenceConsumption.RowCount = 4;
            this.tlpCyberwareEssenceConsumption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareEssenceConsumption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareEssenceConsumption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareEssenceConsumption.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareEssenceConsumption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCyberwareEssenceConsumption.Size = new System.Drawing.Size(516, 100);
            this.tlpCyberwareEssenceConsumption.TabIndex = 0;
            // 
            // lblCyberwareESSLabel
            // 
            this.lblCyberwareESSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareESSLabel.AutoSize = true;
            this.lblCyberwareESSLabel.Location = new System.Drawing.Point(60, 6);
            this.lblCyberwareESSLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareESSLabel.Name = "lblCyberwareESSLabel";
            this.lblCyberwareESSLabel.Size = new System.Drawing.Size(60, 13);
            this.lblCyberwareESSLabel.TabIndex = 55;
            this.lblCyberwareESSLabel.Tag = "Label_Cyberware";
            this.lblCyberwareESSLabel.Text = "Cyberware:";
            // 
            // lblBiowareESSLabel
            // 
            this.lblBiowareESSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBiowareESSLabel.AutoSize = true;
            this.lblBiowareESSLabel.Location = new System.Drawing.Point(72, 31);
            this.lblBiowareESSLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBiowareESSLabel.Name = "lblBiowareESSLabel";
            this.lblBiowareESSLabel.Size = new System.Drawing.Size(48, 13);
            this.lblBiowareESSLabel.TabIndex = 56;
            this.lblBiowareESSLabel.Tag = "Label_Bioware";
            this.lblBiowareESSLabel.Text = "Bioware:";
            // 
            // lblEssenceHoleESSLabel
            // 
            this.lblEssenceHoleESSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEssenceHoleESSLabel.AutoSize = true;
            this.lblEssenceHoleESSLabel.Location = new System.Drawing.Point(44, 56);
            this.lblEssenceHoleESSLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEssenceHoleESSLabel.Name = "lblEssenceHoleESSLabel";
            this.lblEssenceHoleESSLabel.Size = new System.Drawing.Size(76, 13);
            this.lblEssenceHoleESSLabel.TabIndex = 60;
            this.lblEssenceHoleESSLabel.Tag = "Label_EssenceHole";
            this.lblEssenceHoleESSLabel.Text = "Essence Hole:";
            // 
            // lblPrototypeTranshumanESSLabel
            // 
            this.lblPrototypeTranshumanESSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrototypeTranshumanESSLabel.AutoSize = true;
            this.lblPrototypeTranshumanESSLabel.Location = new System.Drawing.Point(3, 81);
            this.lblPrototypeTranshumanESSLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPrototypeTranshumanESSLabel.Name = "lblPrototypeTranshumanESSLabel";
            this.lblPrototypeTranshumanESSLabel.Size = new System.Drawing.Size(117, 13);
            this.lblPrototypeTranshumanESSLabel.TabIndex = 248;
            this.lblPrototypeTranshumanESSLabel.Tag = "Label_PrototypeTranshuman";
            this.lblPrototypeTranshumanESSLabel.Text = "Prototype Transhuman:";
            // 
            // lblCyberwareESS
            // 
            this.lblCyberwareESS.AutoSize = true;
            this.lblCyberwareESS.Location = new System.Drawing.Point(126, 6);
            this.lblCyberwareESS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareESS.Name = "lblCyberwareESS";
            this.lblCyberwareESS.Size = new System.Drawing.Size(19, 13);
            this.lblCyberwareESS.TabIndex = 57;
            this.lblCyberwareESS.Text = "[0]";
            // 
            // lblBiowareESS
            // 
            this.lblBiowareESS.AutoSize = true;
            this.lblBiowareESS.Location = new System.Drawing.Point(126, 31);
            this.lblBiowareESS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBiowareESS.Name = "lblBiowareESS";
            this.lblBiowareESS.Size = new System.Drawing.Size(19, 13);
            this.lblBiowareESS.TabIndex = 58;
            this.lblBiowareESS.Text = "[0]";
            // 
            // lblEssenceHoleESS
            // 
            this.lblEssenceHoleESS.AutoSize = true;
            this.lblEssenceHoleESS.Location = new System.Drawing.Point(126, 56);
            this.lblEssenceHoleESS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEssenceHoleESS.Name = "lblEssenceHoleESS";
            this.lblEssenceHoleESS.Size = new System.Drawing.Size(19, 13);
            this.lblEssenceHoleESS.TabIndex = 61;
            this.lblEssenceHoleESS.Text = "[0]";
            // 
            // lblPrototypeTranshumanESS
            // 
            this.lblPrototypeTranshumanESS.AutoSize = true;
            this.lblPrototypeTranshumanESS.Location = new System.Drawing.Point(126, 81);
            this.lblPrototypeTranshumanESS.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPrototypeTranshumanESS.Name = "lblPrototypeTranshumanESS";
            this.lblPrototypeTranshumanESS.Size = new System.Drawing.Size(19, 13);
            this.lblPrototypeTranshumanESS.TabIndex = 249;
            this.lblPrototypeTranshumanESS.Text = "[0]";
            // 
            // tlpCyberwareCommon
            // 
            this.tlpCyberwareCommon.AutoSize = true;
            this.tlpCyberwareCommon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCyberwareCommon.ColumnCount = 4;
            this.tlpCyberwareCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCyberwareCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCyberwareCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCyberwareCommon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareNameLabel, 0, 0);
            this.tlpCyberwareCommon.Controls.Add(this.nudCyberwareRating, 3, 1);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareRatingLabel, 2, 1);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCapacity, 3, 2);
            this.tlpCyberwareCommon.Controls.Add(this.chkPrototypeTranshuman, 2, 0);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCost, 3, 3);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCostLabel, 2, 3);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberlimbAGI, 3, 4);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberlimbAGILabel, 2, 4);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberlimbSTR, 3, 5);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberlimbSTRLabel, 2, 5);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCapacityLabel, 2, 2);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareName, 1, 0);
            this.tlpCyberwareCommon.Controls.Add(this.cmdCyberwareChangeMount, 0, 6);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCategoryLabel, 0, 1);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareSource, 1, 5);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareSourceLabel, 0, 5);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareAvail, 1, 4);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareAvailLabel, 0, 4);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareEssence, 1, 3);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareEssenceLabel, 0, 3);
            this.tlpCyberwareCommon.Controls.Add(this.cboCyberwareGrade, 1, 2);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareGradeLabel, 0, 2);
            this.tlpCyberwareCommon.Controls.Add(this.lblCyberwareCategory, 1, 1);
            this.tlpCyberwareCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCyberwareCommon.Location = new System.Drawing.Point(0, 125);
            this.tlpCyberwareCommon.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCyberwareCommon.Name = "tlpCyberwareCommon";
            this.tlpCyberwareCommon.RowCount = 7;
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareCommon.Size = new System.Drawing.Size(528, 182);
            this.tlpCyberwareCommon.TabIndex = 253;
            // 
            // lblCyberwareNameLabel
            // 
            this.lblCyberwareNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareNameLabel.AutoSize = true;
            this.lblCyberwareNameLabel.Location = new System.Drawing.Point(91, 6);
            this.lblCyberwareNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareNameLabel.Name = "lblCyberwareNameLabel";
            this.lblCyberwareNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblCyberwareNameLabel.TabIndex = 29;
            this.lblCyberwareNameLabel.Tag = "Label_Name";
            this.lblCyberwareNameLabel.Text = "Name:";
            // 
            // nudCyberwareRating
            // 
            this.nudCyberwareRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCyberwareRating.Enabled = false;
            this.nudCyberwareRating.Location = new System.Drawing.Point(399, 28);
            this.nudCyberwareRating.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCyberwareRating.Name = "nudCyberwareRating";
            this.nudCyberwareRating.Size = new System.Drawing.Size(126, 20);
            this.nudCyberwareRating.TabIndex = 44;
            this.nudCyberwareRating.ValueChanged += new System.EventHandler(this.nudCyberwareRating_ValueChanged);
            // 
            // lblCyberwareRatingLabel
            // 
            this.lblCyberwareRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareRatingLabel.AutoSize = true;
            this.lblCyberwareRatingLabel.Location = new System.Drawing.Point(352, 31);
            this.lblCyberwareRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareRatingLabel.Name = "lblCyberwareRatingLabel";
            this.lblCyberwareRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblCyberwareRatingLabel.TabIndex = 42;
            this.lblCyberwareRatingLabel.Tag = "Label_Rating";
            this.lblCyberwareRatingLabel.Text = "Rating:";
            // 
            // lblCyberwareCapacity
            // 
            this.lblCyberwareCapacity.AutoSize = true;
            this.lblCyberwareCapacity.Location = new System.Drawing.Point(399, 57);
            this.lblCyberwareCapacity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCapacity.Name = "lblCyberwareCapacity";
            this.lblCyberwareCapacity.Size = new System.Drawing.Size(54, 13);
            this.lblCyberwareCapacity.TabIndex = 36;
            this.lblCyberwareCapacity.Text = "[Capacity]";
            // 
            // chkPrototypeTranshuman
            // 
            this.chkPrototypeTranshuman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrototypeTranshuman.AutoSize = true;
            this.tlpCyberwareCommon.SetColumnSpan(this.chkPrototypeTranshuman, 2);
            this.chkPrototypeTranshuman.Location = new System.Drawing.Point(267, 4);
            this.chkPrototypeTranshuman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPrototypeTranshuman.Name = "chkPrototypeTranshuman";
            this.chkPrototypeTranshuman.Size = new System.Drawing.Size(258, 17);
            this.chkPrototypeTranshuman.TabIndex = 226;
            this.chkPrototypeTranshuman.Tag = "Checkbox_PrototypeTranshuman";
            this.chkPrototypeTranshuman.Text = "Prototype Transhuman";
            this.chkPrototypeTranshuman.UseVisualStyleBackColor = true;
            this.chkPrototypeTranshuman.Visible = false;
            this.chkPrototypeTranshuman.CheckedChanged += new System.EventHandler(this.chkPrototypeTranshuman_CheckedChanged);
            // 
            // lblCyberwareCost
            // 
            this.lblCyberwareCost.AutoSize = true;
            this.lblCyberwareCost.Location = new System.Drawing.Point(399, 84);
            this.lblCyberwareCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCost.Name = "lblCyberwareCost";
            this.lblCyberwareCost.Size = new System.Drawing.Size(34, 13);
            this.lblCyberwareCost.TabIndex = 41;
            this.lblCyberwareCost.Text = "[Cost]";
            // 
            // lblCyberwareCostLabel
            // 
            this.lblCyberwareCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareCostLabel.AutoSize = true;
            this.lblCyberwareCostLabel.Location = new System.Drawing.Point(362, 84);
            this.lblCyberwareCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCostLabel.Name = "lblCyberwareCostLabel";
            this.lblCyberwareCostLabel.Size = new System.Drawing.Size(31, 13);
            this.lblCyberwareCostLabel.TabIndex = 40;
            this.lblCyberwareCostLabel.Tag = "Label_Cost";
            this.lblCyberwareCostLabel.Text = "Cost:";
            // 
            // lblCyberlimbAGI
            // 
            this.lblCyberlimbAGI.AutoSize = true;
            this.lblCyberlimbAGI.Location = new System.Drawing.Point(399, 109);
            this.lblCyberlimbAGI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberlimbAGI.Name = "lblCyberlimbAGI";
            this.lblCyberlimbAGI.Size = new System.Drawing.Size(19, 13);
            this.lblCyberlimbAGI.TabIndex = 224;
            this.lblCyberlimbAGI.Text = "[0]";
            this.lblCyberlimbAGI.Visible = false;
            // 
            // lblCyberlimbAGILabel
            // 
            this.lblCyberlimbAGILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberlimbAGILabel.AutoSize = true;
            this.lblCyberlimbAGILabel.Location = new System.Drawing.Point(329, 109);
            this.lblCyberlimbAGILabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberlimbAGILabel.Name = "lblCyberlimbAGILabel";
            this.lblCyberlimbAGILabel.Size = new System.Drawing.Size(64, 13);
            this.lblCyberlimbAGILabel.TabIndex = 222;
            this.lblCyberlimbAGILabel.Tag = "Label_CyberlimbAGI";
            this.lblCyberlimbAGILabel.Text = "Agility (AGI):";
            this.lblCyberlimbAGILabel.Visible = false;
            // 
            // lblCyberlimbSTR
            // 
            this.lblCyberlimbSTR.AutoSize = true;
            this.lblCyberlimbSTR.Location = new System.Drawing.Point(399, 134);
            this.lblCyberlimbSTR.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberlimbSTR.Name = "lblCyberlimbSTR";
            this.lblCyberlimbSTR.Size = new System.Drawing.Size(19, 13);
            this.lblCyberlimbSTR.TabIndex = 225;
            this.lblCyberlimbSTR.Text = "[0]";
            this.lblCyberlimbSTR.Visible = false;
            // 
            // lblCyberlimbSTRLabel
            // 
            this.lblCyberlimbSTRLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberlimbSTRLabel.AutoSize = true;
            this.lblCyberlimbSTRLabel.Location = new System.Drawing.Point(312, 134);
            this.lblCyberlimbSTRLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberlimbSTRLabel.Name = "lblCyberlimbSTRLabel";
            this.lblCyberlimbSTRLabel.Size = new System.Drawing.Size(81, 13);
            this.lblCyberlimbSTRLabel.TabIndex = 223;
            this.lblCyberlimbSTRLabel.Tag = "Label_CyberlimbSTR";
            this.lblCyberlimbSTRLabel.Text = "Strength (STR):";
            this.lblCyberlimbSTRLabel.Visible = false;
            // 
            // lblCyberwareCapacityLabel
            // 
            this.lblCyberwareCapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareCapacityLabel.AutoSize = true;
            this.lblCyberwareCapacityLabel.Location = new System.Drawing.Point(342, 57);
            this.lblCyberwareCapacityLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCapacityLabel.Name = "lblCyberwareCapacityLabel";
            this.lblCyberwareCapacityLabel.Size = new System.Drawing.Size(51, 13);
            this.lblCyberwareCapacityLabel.TabIndex = 35;
            this.lblCyberwareCapacityLabel.Tag = "Label_Capacity";
            this.lblCyberwareCapacityLabel.Text = "Capacity:";
            // 
            // lblCyberwareName
            // 
            this.lblCyberwareName.AutoSize = true;
            this.lblCyberwareName.Location = new System.Drawing.Point(135, 6);
            this.lblCyberwareName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareName.Name = "lblCyberwareName";
            this.lblCyberwareName.Size = new System.Drawing.Size(41, 13);
            this.lblCyberwareName.TabIndex = 30;
            this.lblCyberwareName.Text = "[Name]";
            // 
            // cmdCyberwareChangeMount
            // 
            this.cmdCyberwareChangeMount.AutoSize = true;
            this.cmdCyberwareChangeMount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCyberwareCommon.SetColumnSpan(this.cmdCyberwareChangeMount, 4);
            this.cmdCyberwareChangeMount.Location = new System.Drawing.Point(3, 156);
            this.cmdCyberwareChangeMount.Name = "cmdCyberwareChangeMount";
            this.cmdCyberwareChangeMount.Size = new System.Drawing.Size(143, 23);
            this.cmdCyberwareChangeMount.TabIndex = 227;
            this.cmdCyberwareChangeMount.Tag = "Button_ChangeMountedLocation";
            this.cmdCyberwareChangeMount.Text = "Change Mounted Location";
            this.cmdCyberwareChangeMount.UseVisualStyleBackColor = true;
            this.cmdCyberwareChangeMount.Visible = false;
            this.cmdCyberwareChangeMount.Click += new System.EventHandler(this.cmdCyberwareChangeMount_Click);
            // 
            // lblCyberwareCategoryLabel
            // 
            this.lblCyberwareCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareCategoryLabel.AutoSize = true;
            this.lblCyberwareCategoryLabel.Location = new System.Drawing.Point(77, 31);
            this.lblCyberwareCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCategoryLabel.Name = "lblCyberwareCategoryLabel";
            this.lblCyberwareCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblCyberwareCategoryLabel.TabIndex = 31;
            this.lblCyberwareCategoryLabel.Tag = "Label_Category";
            this.lblCyberwareCategoryLabel.Text = "Category:";
            // 
            // lblCyberwareSource
            // 
            this.lblCyberwareSource.AutoSize = true;
            this.lblCyberwareSource.Location = new System.Drawing.Point(135, 134);
            this.lblCyberwareSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareSource.Name = "lblCyberwareSource";
            this.lblCyberwareSource.Size = new System.Drawing.Size(47, 13);
            this.lblCyberwareSource.TabIndex = 48;
            this.lblCyberwareSource.Text = "[Source]";
            this.lblCyberwareSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblCyberwareSourceLabel
            // 
            this.lblCyberwareSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareSourceLabel.AutoSize = true;
            this.lblCyberwareSourceLabel.Location = new System.Drawing.Point(85, 134);
            this.lblCyberwareSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareSourceLabel.Name = "lblCyberwareSourceLabel";
            this.lblCyberwareSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblCyberwareSourceLabel.TabIndex = 47;
            this.lblCyberwareSourceLabel.Tag = "Label_Source";
            this.lblCyberwareSourceLabel.Text = "Source:";
            // 
            // lblCyberwareAvail
            // 
            this.lblCyberwareAvail.AutoSize = true;
            this.lblCyberwareAvail.Location = new System.Drawing.Point(135, 109);
            this.lblCyberwareAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareAvail.Name = "lblCyberwareAvail";
            this.lblCyberwareAvail.Size = new System.Drawing.Size(36, 13);
            this.lblCyberwareAvail.TabIndex = 39;
            this.lblCyberwareAvail.Text = "[Avail]";
            // 
            // lblCyberwareAvailLabel
            // 
            this.lblCyberwareAvailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareAvailLabel.AutoSize = true;
            this.lblCyberwareAvailLabel.Location = new System.Drawing.Point(96, 109);
            this.lblCyberwareAvailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareAvailLabel.Name = "lblCyberwareAvailLabel";
            this.lblCyberwareAvailLabel.Size = new System.Drawing.Size(33, 13);
            this.lblCyberwareAvailLabel.TabIndex = 38;
            this.lblCyberwareAvailLabel.Tag = "Label_Avail";
            this.lblCyberwareAvailLabel.Text = "Avail:";
            // 
            // lblCyberwareEssence
            // 
            this.lblCyberwareEssence.AutoSize = true;
            this.lblCyberwareEssence.Location = new System.Drawing.Point(135, 84);
            this.lblCyberwareEssence.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareEssence.Name = "lblCyberwareEssence";
            this.lblCyberwareEssence.Size = new System.Drawing.Size(34, 13);
            this.lblCyberwareEssence.TabIndex = 34;
            this.lblCyberwareEssence.Text = "[ESS]";
            // 
            // lblCyberwareEssenceLabel
            // 
            this.lblCyberwareEssenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareEssenceLabel.AutoSize = true;
            this.lblCyberwareEssenceLabel.Location = new System.Drawing.Point(78, 84);
            this.lblCyberwareEssenceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareEssenceLabel.Name = "lblCyberwareEssenceLabel";
            this.lblCyberwareEssenceLabel.Size = new System.Drawing.Size(51, 13);
            this.lblCyberwareEssenceLabel.TabIndex = 33;
            this.lblCyberwareEssenceLabel.Tag = "Label_Essence";
            this.lblCyberwareEssenceLabel.Text = "Essence:";
            // 
            // cboCyberwareGrade
            // 
            this.cboCyberwareGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCyberwareGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCyberwareGrade.FormattingEnabled = true;
            this.cboCyberwareGrade.Location = new System.Drawing.Point(135, 54);
            this.cboCyberwareGrade.Name = "cboCyberwareGrade";
            this.cboCyberwareGrade.Size = new System.Drawing.Size(126, 21);
            this.cboCyberwareGrade.TabIndex = 43;
            this.cboCyberwareGrade.TooltipText = "";
            this.cboCyberwareGrade.Visible = false;
            this.cboCyberwareGrade.SelectedIndexChanged += new System.EventHandler(this.cboCyberwareGrade_SelectedIndexChanged);
            // 
            // lblCyberwareGradeLabel
            // 
            this.lblCyberwareGradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCyberwareGradeLabel.AutoSize = true;
            this.lblCyberwareGradeLabel.Location = new System.Drawing.Point(90, 57);
            this.lblCyberwareGradeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareGradeLabel.Name = "lblCyberwareGradeLabel";
            this.lblCyberwareGradeLabel.Size = new System.Drawing.Size(39, 13);
            this.lblCyberwareGradeLabel.TabIndex = 37;
            this.lblCyberwareGradeLabel.Tag = "Label_Grade";
            this.lblCyberwareGradeLabel.Text = "Grade:";
            // 
            // lblCyberwareCategory
            // 
            this.lblCyberwareCategory.AutoSize = true;
            this.lblCyberwareCategory.Location = new System.Drawing.Point(135, 31);
            this.lblCyberwareCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberwareCategory.Name = "lblCyberwareCategory";
            this.lblCyberwareCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCyberwareCategory.TabIndex = 32;
            this.lblCyberwareCategory.Text = "[Category]";
            // 
            // tlpCyberwareMatrix
            // 
            this.tlpCyberwareMatrix.AutoSize = true;
            this.tlpCyberwareMatrix.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCyberwareMatrix.ColumnCount = 5;
            this.tlpCyberwareMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCyberwareMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCyberwareMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCyberwareMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCyberwareMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberFirewallLabel, 4, 1);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberSleazeLabel, 2, 1);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberDeviceRatingLabel, 0, 1);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberDeviceRating, 0, 2);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberAttack, 1, 2);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberAttackLabel, 1, 1);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberSleaze, 2, 2);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberDataProcessingLabel, 3, 1);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberDataProcessing, 3, 2);
            this.tlpCyberwareMatrix.Controls.Add(this.lblCyberFirewall, 4, 2);
            this.tlpCyberwareMatrix.Controls.Add(this.chkCyberwareHomeNode, 2, 0);
            this.tlpCyberwareMatrix.Controls.Add(this.chkCyberwareActiveCommlink, 3, 0);
            this.tlpCyberwareMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCyberwareMatrix.Location = new System.Drawing.Point(0, 307);
            this.tlpCyberwareMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCyberwareMatrix.Name = "tlpCyberwareMatrix";
            this.tlpCyberwareMatrix.RowCount = 3;
            this.tlpCyberwareMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCyberwareMatrix.Size = new System.Drawing.Size(528, 75);
            this.tlpCyberwareMatrix.TabIndex = 251;
            // 
            // lblCyberFirewallLabel
            // 
            this.lblCyberFirewallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCyberFirewallLabel.AutoSize = true;
            this.lblCyberFirewallLabel.Location = new System.Drawing.Point(423, 31);
            this.lblCyberFirewallLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberFirewallLabel.Name = "lblCyberFirewallLabel";
            this.lblCyberFirewallLabel.Size = new System.Drawing.Size(45, 13);
            this.lblCyberFirewallLabel.TabIndex = 174;
            this.lblCyberFirewallLabel.Tag = "Label_Firewall";
            this.lblCyberFirewallLabel.Text = "Firewall:";
            this.lblCyberFirewallLabel.Visible = false;
            // 
            // lblCyberSleazeLabel
            // 
            this.lblCyberSleazeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCyberSleazeLabel.AutoSize = true;
            this.lblCyberSleazeLabel.Location = new System.Drawing.Point(213, 31);
            this.lblCyberSleazeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberSleazeLabel.Name = "lblCyberSleazeLabel";
            this.lblCyberSleazeLabel.Size = new System.Drawing.Size(42, 13);
            this.lblCyberSleazeLabel.TabIndex = 170;
            this.lblCyberSleazeLabel.Tag = "Label_Sleaze";
            this.lblCyberSleazeLabel.Text = "Sleaze:";
            this.lblCyberSleazeLabel.Visible = false;
            // 
            // lblCyberDeviceRatingLabel
            // 
            this.lblCyberDeviceRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCyberDeviceRatingLabel.AutoSize = true;
            this.lblCyberDeviceRatingLabel.Location = new System.Drawing.Point(3, 31);
            this.lblCyberDeviceRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberDeviceRatingLabel.Name = "lblCyberDeviceRatingLabel";
            this.lblCyberDeviceRatingLabel.Size = new System.Drawing.Size(78, 13);
            this.lblCyberDeviceRatingLabel.TabIndex = 166;
            this.lblCyberDeviceRatingLabel.Tag = "Label_DeviceRating";
            this.lblCyberDeviceRatingLabel.Text = "Device Rating:";
            this.lblCyberDeviceRatingLabel.Visible = false;
            // 
            // lblCyberDeviceRating
            // 
            this.lblCyberDeviceRating.AutoSize = true;
            this.lblCyberDeviceRating.Location = new System.Drawing.Point(3, 56);
            this.lblCyberDeviceRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberDeviceRating.Name = "lblCyberDeviceRating";
            this.lblCyberDeviceRating.Size = new System.Drawing.Size(19, 13);
            this.lblCyberDeviceRating.TabIndex = 167;
            this.lblCyberDeviceRating.Text = "[0]";
            this.lblCyberDeviceRating.Visible = false;
            // 
            // lblCyberAttack
            // 
            this.lblCyberAttack.AutoSize = true;
            this.lblCyberAttack.Location = new System.Drawing.Point(108, 56);
            this.lblCyberAttack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberAttack.Name = "lblCyberAttack";
            this.lblCyberAttack.Size = new System.Drawing.Size(19, 13);
            this.lblCyberAttack.TabIndex = 169;
            this.lblCyberAttack.Text = "[0]";
            this.lblCyberAttack.Visible = false;
            // 
            // lblCyberAttackLabel
            // 
            this.lblCyberAttackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCyberAttackLabel.AutoSize = true;
            this.lblCyberAttackLabel.Location = new System.Drawing.Point(108, 31);
            this.lblCyberAttackLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberAttackLabel.Name = "lblCyberAttackLabel";
            this.lblCyberAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.lblCyberAttackLabel.TabIndex = 168;
            this.lblCyberAttackLabel.Tag = "Label_Attack";
            this.lblCyberAttackLabel.Text = "Attack:";
            this.lblCyberAttackLabel.Visible = false;
            // 
            // lblCyberSleaze
            // 
            this.lblCyberSleaze.AutoSize = true;
            this.lblCyberSleaze.Location = new System.Drawing.Point(213, 56);
            this.lblCyberSleaze.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberSleaze.Name = "lblCyberSleaze";
            this.lblCyberSleaze.Size = new System.Drawing.Size(19, 13);
            this.lblCyberSleaze.TabIndex = 171;
            this.lblCyberSleaze.Text = "[0]";
            this.lblCyberSleaze.Visible = false;
            // 
            // lblCyberDataProcessingLabel
            // 
            this.lblCyberDataProcessingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCyberDataProcessingLabel.AutoSize = true;
            this.lblCyberDataProcessingLabel.Location = new System.Drawing.Point(318, 31);
            this.lblCyberDataProcessingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberDataProcessingLabel.Name = "lblCyberDataProcessingLabel";
            this.lblCyberDataProcessingLabel.Size = new System.Drawing.Size(88, 13);
            this.lblCyberDataProcessingLabel.TabIndex = 172;
            this.lblCyberDataProcessingLabel.Tag = "Label_DataProcessing";
            this.lblCyberDataProcessingLabel.Text = "Data Processing:";
            this.lblCyberDataProcessingLabel.Visible = false;
            // 
            // lblCyberDataProcessing
            // 
            this.lblCyberDataProcessing.AutoSize = true;
            this.lblCyberDataProcessing.Location = new System.Drawing.Point(318, 56);
            this.lblCyberDataProcessing.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberDataProcessing.Name = "lblCyberDataProcessing";
            this.lblCyberDataProcessing.Size = new System.Drawing.Size(19, 13);
            this.lblCyberDataProcessing.TabIndex = 173;
            this.lblCyberDataProcessing.Text = "[0]";
            this.lblCyberDataProcessing.Visible = false;
            // 
            // lblCyberFirewall
            // 
            this.lblCyberFirewall.AutoSize = true;
            this.lblCyberFirewall.Location = new System.Drawing.Point(423, 56);
            this.lblCyberFirewall.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCyberFirewall.Name = "lblCyberFirewall";
            this.lblCyberFirewall.Size = new System.Drawing.Size(19, 13);
            this.lblCyberFirewall.TabIndex = 175;
            this.lblCyberFirewall.Text = "[0]";
            this.lblCyberFirewall.Visible = false;
            // 
            // chkCyberwareHomeNode
            // 
            this.chkCyberwareHomeNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCyberwareHomeNode.AutoSize = true;
            this.chkCyberwareHomeNode.Location = new System.Drawing.Point(213, 4);
            this.chkCyberwareHomeNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCyberwareHomeNode.Name = "chkCyberwareHomeNode";
            this.chkCyberwareHomeNode.Size = new System.Drawing.Size(99, 17);
            this.chkCyberwareHomeNode.TabIndex = 246;
            this.chkCyberwareHomeNode.Tag = "Checkbox_HomeNode";
            this.chkCyberwareHomeNode.Text = "Home Node";
            this.chkCyberwareHomeNode.UseVisualStyleBackColor = true;
            this.chkCyberwareHomeNode.Visible = false;
            this.chkCyberwareHomeNode.CheckedChanged += new System.EventHandler(this.chkCyberwareHomeNode_CheckedChanged);
            // 
            // chkCyberwareActiveCommlink
            // 
            this.chkCyberwareActiveCommlink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCyberwareActiveCommlink.AutoSize = true;
            this.tlpCyberwareMatrix.SetColumnSpan(this.chkCyberwareActiveCommlink, 2);
            this.chkCyberwareActiveCommlink.Location = new System.Drawing.Point(318, 4);
            this.chkCyberwareActiveCommlink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkCyberwareActiveCommlink.Name = "chkCyberwareActiveCommlink";
            this.chkCyberwareActiveCommlink.Size = new System.Drawing.Size(207, 17);
            this.chkCyberwareActiveCommlink.TabIndex = 247;
            this.chkCyberwareActiveCommlink.Tag = "Checkbox_ActiveCommlink";
            this.chkCyberwareActiveCommlink.Text = "Active Commlink";
            this.chkCyberwareActiveCommlink.UseVisualStyleBackColor = true;
            this.chkCyberwareActiveCommlink.Visible = false;
            this.chkCyberwareActiveCommlink.CheckedChanged += new System.EventHandler(this.chkCyberwareActiveCommlink_CheckedChanged);
            // 
            // tabStreetGear
            // 
            this.tabStreetGear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabStreetGear.Controls.Add(this.tabStreetGearTabs);
            this.tabStreetGear.Location = new System.Drawing.Point(4, 22);
            this.tabStreetGear.Name = "tabStreetGear";
            this.tabStreetGear.Size = new System.Drawing.Size(841, 631);
            this.tabStreetGear.TabIndex = 5;
            this.tabStreetGear.Tag = "Tab_StreeGear";
            this.tabStreetGear.Text = "Street Gear";
            // 
            // tabStreetGearTabs
            // 
            this.tabStreetGearTabs.Controls.Add(this.tabGear);
            this.tabStreetGearTabs.Controls.Add(this.tabArmor);
            this.tabStreetGearTabs.Controls.Add(this.tabWeapons);
            this.tabStreetGearTabs.Controls.Add(this.tabDrugs);
            this.tabStreetGearTabs.Controls.Add(this.tabLifestyle);
            this.tabStreetGearTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStreetGearTabs.Location = new System.Drawing.Point(0, 0);
            this.tabStreetGearTabs.Name = "tabStreetGearTabs";
            this.tabStreetGearTabs.SelectedIndex = 0;
            this.tabStreetGearTabs.Size = new System.Drawing.Size(841, 631);
            this.tabStreetGearTabs.TabIndex = 87;
            this.tabStreetGearTabs.SelectedIndexChanged += new System.EventHandler(this.tabStreetGearTabs_SelectedIndexChanged);
            // 
            // tabGear
            // 
            this.tabGear.BackColor = System.Drawing.SystemColors.Control;
            this.tabGear.Controls.Add(this.tlpGear);
            this.tabGear.Location = new System.Drawing.Point(4, 22);
            this.tabGear.Name = "tabGear";
            this.tabGear.Padding = new System.Windows.Forms.Padding(3);
            this.tabGear.Size = new System.Drawing.Size(833, 605);
            this.tabGear.TabIndex = 3;
            this.tabGear.Tag = "Tab_Gear";
            this.tabGear.Text = "Gear";
            // 
            // tlpGear
            // 
            this.tlpGear.ColumnCount = 7;
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGear.Controls.Add(this.cmdCreateStackedFocus, 5, 12);
            this.tlpGear.Controls.Add(this.chkGearActiveCommlink, 1, 9);
            this.tlpGear.Controls.Add(this.treFoci, 1, 12);
            this.tlpGear.Controls.Add(this.lblFoci, 1, 11);
            this.tlpGear.Controls.Add(this.chkGearHomeNode, 1, 10);
            this.tlpGear.Controls.Add(this.lblGearAttackLabel, 3, 7);
            this.tlpGear.Controls.Add(this.lblGearSleazeLabel, 4, 7);
            this.tlpGear.Controls.Add(this.lblGearDataProcessingLabel, 5, 7);
            this.tlpGear.Controls.Add(this.lblGearFirewallLabel, 6, 7);
            this.tlpGear.Controls.Add(this.cboGearFirewall, 6, 8);
            this.tlpGear.Controls.Add(this.lblGearDeviceRating, 2, 8);
            this.tlpGear.Controls.Add(this.cboGearDataProcessing, 5, 8);
            this.tlpGear.Controls.Add(this.lblGearDeviceRatingLabel, 1, 8);
            this.tlpGear.Controls.Add(this.treGear, 0, 1);
            this.tlpGear.Controls.Add(this.flowLayoutPanel13, 0, 0);
            this.tlpGear.Controls.Add(this.cboGearSleaze, 4, 8);
            this.tlpGear.Controls.Add(this.lblGearNameLabel, 1, 1);
            this.tlpGear.Controls.Add(this.cboGearAttack, 3, 8);
            this.tlpGear.Controls.Add(this.lblGearName, 2, 1);
            this.tlpGear.Controls.Add(this.lblGearCategoryLabel, 1, 2);
            this.tlpGear.Controls.Add(this.lblGearCategory, 2, 2);
            this.tlpGear.Controls.Add(this.lblGearRatingLabel, 1, 3);
            this.tlpGear.Controls.Add(this.nudGearRating, 2, 3);
            this.tlpGear.Controls.Add(this.lblGearCapacityLabel, 1, 4);
            this.tlpGear.Controls.Add(this.lblGearCapacity, 2, 4);
            this.tlpGear.Controls.Add(this.lblGearQtyLabel, 1, 5);
            this.tlpGear.Controls.Add(this.chkGearEquipped, 3, 6);
            this.tlpGear.Controls.Add(this.lblGearAP, 4, 2);
            this.tlpGear.Controls.Add(this.nudGearQty, 2, 5);
            this.tlpGear.Controls.Add(this.lblGearAPLabel, 3, 2);
            this.tlpGear.Controls.Add(this.lblGearSource, 2, 6);
            this.tlpGear.Controls.Add(this.lblGearDamageLabel, 3, 1);
            this.tlpGear.Controls.Add(this.lblGearSourceLabel, 1, 6);
            this.tlpGear.Controls.Add(this.lblGearDamage, 4, 1);
            this.tlpGear.Controls.Add(this.lblGearAvailLabel, 3, 3);
            this.tlpGear.Controls.Add(this.lblGearAvail, 4, 3);
            this.tlpGear.Controls.Add(this.lblGearCostLabel, 3, 4);
            this.tlpGear.Controls.Add(this.lblGearCost, 4, 4);
            this.tlpGear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGear.Location = new System.Drawing.Point(3, 3);
            this.tlpGear.Name = "tlpGear";
            this.tlpGear.RowCount = 13;
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGear.Size = new System.Drawing.Size(827, 599);
            this.tlpGear.TabIndex = 160;
            // 
            // cmdCreateStackedFocus
            // 
            this.cmdCreateStackedFocus.AutoSize = true;
            this.cmdCreateStackedFocus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpGear.SetColumnSpan(this.cmdCreateStackedFocus, 2);
            this.cmdCreateStackedFocus.Location = new System.Drawing.Point(662, 311);
            this.cmdCreateStackedFocus.Name = "cmdCreateStackedFocus";
            this.cmdCreateStackedFocus.Size = new System.Drawing.Size(123, 23);
            this.cmdCreateStackedFocus.TabIndex = 109;
            this.cmdCreateStackedFocus.Tag = "Button_CreateStackedFocus";
            this.cmdCreateStackedFocus.Text = "Create Stacked Focus";
            this.cmdCreateStackedFocus.UseVisualStyleBackColor = true;
            this.cmdCreateStackedFocus.Visible = false;
            this.cmdCreateStackedFocus.Click += new System.EventHandler(this.cmdCreateStackedFocus_Click);
            // 
            // chkGearActiveCommlink
            // 
            this.chkGearActiveCommlink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGearActiveCommlink.AutoSize = true;
            this.tlpGear.SetColumnSpan(this.chkGearActiveCommlink, 2);
            this.chkGearActiveCommlink.Enabled = false;
            this.chkGearActiveCommlink.Location = new System.Drawing.Point(304, 237);
            this.chkGearActiveCommlink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGearActiveCommlink.Name = "chkGearActiveCommlink";
            this.chkGearActiveCommlink.Size = new System.Drawing.Size(184, 17);
            this.chkGearActiveCommlink.TabIndex = 115;
            this.chkGearActiveCommlink.Tag = "Checkbox_ActiveCommlink";
            this.chkGearActiveCommlink.Text = "Active Commlink";
            this.chkGearActiveCommlink.UseVisualStyleBackColor = true;
            this.chkGearActiveCommlink.CheckedChanged += new System.EventHandler(this.chkGearActiveCommlink_CheckedChanged);
            // 
            // treFoci
            // 
            this.treFoci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treFoci.CheckBoxes = true;
            this.tlpGear.SetColumnSpan(this.treFoci, 4);
            this.treFoci.Location = new System.Drawing.Point(304, 311);
            this.treFoci.Name = "treFoci";
            this.treFoci.ShowLines = false;
            this.treFoci.ShowPlusMinus = false;
            this.treFoci.ShowRootLines = false;
            this.treFoci.Size = new System.Drawing.Size(352, 285);
            this.treFoci.TabIndex = 91;
            this.treFoci.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treFoci_BeforeCheck);
            this.treFoci.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treFoci_AfterCheck);
            // 
            // chkGearHomeNode
            // 
            this.chkGearHomeNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGearHomeNode.AutoSize = true;
            this.tlpGear.SetColumnSpan(this.chkGearHomeNode, 2);
            this.chkGearHomeNode.Location = new System.Drawing.Point(304, 262);
            this.chkGearHomeNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGearHomeNode.Name = "chkGearHomeNode";
            this.chkGearHomeNode.Size = new System.Drawing.Size(184, 17);
            this.chkGearHomeNode.TabIndex = 108;
            this.chkGearHomeNode.Tag = "Checkbox_HomeNode";
            this.chkGearHomeNode.Text = "Home Node";
            this.chkGearHomeNode.UseVisualStyleBackColor = true;
            this.chkGearHomeNode.Visible = false;
            this.chkGearHomeNode.CheckedChanged += new System.EventHandler(this.chkGearHomeNode_CheckedChanged);
            // 
            // lblGearAttackLabel
            // 
            this.lblGearAttackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGearAttackLabel.Location = new System.Drawing.Point(494, 187);
            this.lblGearAttackLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearAttackLabel.Name = "lblGearAttackLabel";
            this.lblGearAttackLabel.Size = new System.Drawing.Size(60, 13);
            this.lblGearAttackLabel.TabIndex = 148;
            this.lblGearAttackLabel.Tag = "Label_Attack";
            this.lblGearAttackLabel.Text = "Attack:";
            this.lblGearAttackLabel.Visible = false;
            // 
            // lblGearSleazeLabel
            // 
            this.lblGearSleazeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGearSleazeLabel.Location = new System.Drawing.Point(578, 187);
            this.lblGearSleazeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearSleazeLabel.Name = "lblGearSleazeLabel";
            this.lblGearSleazeLabel.Size = new System.Drawing.Size(60, 13);
            this.lblGearSleazeLabel.TabIndex = 150;
            this.lblGearSleazeLabel.Tag = "Label_Sleaze";
            this.lblGearSleazeLabel.Text = "Sleaze:";
            this.lblGearSleazeLabel.Visible = false;
            // 
            // lblGearDataProcessingLabel
            // 
            this.lblGearDataProcessingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGearDataProcessingLabel.Location = new System.Drawing.Point(662, 187);
            this.lblGearDataProcessingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearDataProcessingLabel.Name = "lblGearDataProcessingLabel";
            this.lblGearDataProcessingLabel.Size = new System.Drawing.Size(60, 13);
            this.lblGearDataProcessingLabel.TabIndex = 152;
            this.lblGearDataProcessingLabel.Tag = "Label_DataProcessing";
            this.lblGearDataProcessingLabel.Text = "Data Proc:";
            this.lblGearDataProcessingLabel.Visible = false;
            // 
            // lblGearFirewallLabel
            // 
            this.lblGearFirewallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGearFirewallLabel.Location = new System.Drawing.Point(746, 187);
            this.lblGearFirewallLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearFirewallLabel.Name = "lblGearFirewallLabel";
            this.lblGearFirewallLabel.Size = new System.Drawing.Size(60, 13);
            this.lblGearFirewallLabel.TabIndex = 154;
            this.lblGearFirewallLabel.Tag = "Label_Firewall";
            this.lblGearFirewallLabel.Text = "Firewall:";
            this.lblGearFirewallLabel.Visible = false;
            // 
            // cboGearFirewall
            // 
            this.cboGearFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGearFirewall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGearFirewall.FormattingEnabled = true;
            this.cboGearFirewall.Location = new System.Drawing.Point(746, 209);
            this.cboGearFirewall.Name = "cboGearFirewall";
            this.cboGearFirewall.Size = new System.Drawing.Size(78, 21);
            this.cboGearFirewall.TabIndex = 158;
            this.cboGearFirewall.TooltipText = "";
            this.cboGearFirewall.Visible = false;
            this.cboGearFirewall.SelectedIndexChanged += new System.EventHandler(this.cboGearFirewall_SelectedIndexChanged);
            // 
            // lblGearDeviceRating
            // 
            this.lblGearDeviceRating.AutoSize = true;
            this.lblGearDeviceRating.Location = new System.Drawing.Point(388, 212);
            this.lblGearDeviceRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearDeviceRating.Name = "lblGearDeviceRating";
            this.lblGearDeviceRating.Size = new System.Drawing.Size(19, 13);
            this.lblGearDeviceRating.TabIndex = 66;
            this.lblGearDeviceRating.Text = "[0]";
            // 
            // cboGearDataProcessing
            // 
            this.cboGearDataProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGearDataProcessing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGearDataProcessing.FormattingEnabled = true;
            this.cboGearDataProcessing.Location = new System.Drawing.Point(662, 209);
            this.cboGearDataProcessing.Name = "cboGearDataProcessing";
            this.cboGearDataProcessing.Size = new System.Drawing.Size(78, 21);
            this.cboGearDataProcessing.TabIndex = 159;
            this.cboGearDataProcessing.TooltipText = "";
            this.cboGearDataProcessing.Visible = false;
            this.cboGearDataProcessing.SelectedIndexChanged += new System.EventHandler(this.cboGearDataProcessing_SelectedIndexChanged);
            // 
            // lblGearDeviceRatingLabel
            // 
            this.lblGearDeviceRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearDeviceRatingLabel.AutoSize = true;
            this.lblGearDeviceRatingLabel.Location = new System.Drawing.Point(304, 212);
            this.lblGearDeviceRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearDeviceRatingLabel.Name = "lblGearDeviceRatingLabel";
            this.lblGearDeviceRatingLabel.Size = new System.Drawing.Size(78, 13);
            this.lblGearDeviceRatingLabel.TabIndex = 65;
            this.lblGearDeviceRatingLabel.Tag = "Label_DeviceRating";
            this.lblGearDeviceRatingLabel.Text = "Device Rating:";
            // 
            // treGear
            // 
            this.treGear.AllowDrop = true;
            this.treGear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treGear.HideSelection = false;
            this.treGear.Location = new System.Drawing.Point(3, 32);
            this.treGear.Name = "treGear";
            treeNode22.Name = "nodGearRoot";
            treeNode22.Tag = "Node_SelectedGear";
            treeNode22.Text = "Selected Gear";
            this.treGear.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.tlpGear.SetRowSpan(this.treGear, 12);
            this.treGear.ShowNodeToolTips = true;
            this.treGear.Size = new System.Drawing.Size(295, 564);
            this.treGear.TabIndex = 49;
            this.treGear.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treGear_AfterSelect);
            this.treGear.DragOver += new System.Windows.Forms.DragEventHandler(this.treGear_DragOver);
            this.treGear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treGear_KeyDown);
            this.treGear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.AutoSize = true;
            this.tlpGear.SetColumnSpan(this.flowLayoutPanel13, 7);
            this.flowLayoutPanel13.Controls.Add(this.cmdAddGear);
            this.flowLayoutPanel13.Controls.Add(this.cmdDeleteGear);
            this.flowLayoutPanel13.Controls.Add(this.cmdAddLocation);
            this.flowLayoutPanel13.Controls.Add(this.chkCommlinks);
            this.flowLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(392, 29);
            this.flowLayoutPanel13.TabIndex = 50;
            // 
            // cmdAddGear
            // 
            this.cmdAddGear.AutoSize = true;
            this.cmdAddGear.ContextMenuStrip = this.cmsGearButton;
            this.cmdAddGear.Location = new System.Drawing.Point(3, 3);
            this.cmdAddGear.Name = "cmdAddGear";
            this.cmdAddGear.Size = new System.Drawing.Size(80, 23);
            this.cmdAddGear.SplitMenuStrip = this.cmsGearButton;
            this.cmdAddGear.TabIndex = 145;
            this.cmdAddGear.Tag = "Button_AddGear";
            this.cmdAddGear.Text = "&Add Gear";
            this.cmdAddGear.UseVisualStyleBackColor = true;
            this.cmdAddGear.Click += new System.EventHandler(this.cmdAddGear_Click);
            // 
            // cmdDeleteGear
            // 
            this.cmdDeleteGear.AutoSize = true;
            this.cmdDeleteGear.Location = new System.Drawing.Point(89, 3);
            this.cmdDeleteGear.Name = "cmdDeleteGear";
            this.cmdDeleteGear.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteGear.TabIndex = 50;
            this.cmdDeleteGear.Tag = "String_Delete";
            this.cmdDeleteGear.Text = "Delete";
            this.cmdDeleteGear.UseVisualStyleBackColor = true;
            this.cmdDeleteGear.Click += new System.EventHandler(this.cmdDeleteGear_Click);
            // 
            // cmdAddLocation
            // 
            this.cmdAddLocation.AutoSize = true;
            this.cmdAddLocation.Location = new System.Drawing.Point(175, 3);
            this.cmdAddLocation.Name = "cmdAddLocation";
            this.cmdAddLocation.Size = new System.Drawing.Size(80, 23);
            this.cmdAddLocation.TabIndex = 103;
            this.cmdAddLocation.Tag = "Button_AddLocation";
            this.cmdAddLocation.Text = "Add Location";
            this.cmdAddLocation.UseVisualStyleBackColor = true;
            this.cmdAddLocation.Click += new System.EventHandler(this.cmdAddLocation_Click);
            // 
            // chkCommlinks
            // 
            this.chkCommlinks.AutoSize = true;
            this.chkCommlinks.Location = new System.Drawing.Point(261, 6);
            this.chkCommlinks.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkCommlinks.Name = "chkCommlinks";
            this.chkCommlinks.Size = new System.Drawing.Size(128, 17);
            this.chkCommlinks.TabIndex = 114;
            this.chkCommlinks.Tag = "Checkbox_Commlinks";
            this.chkCommlinks.Text = "Only show Commlinks";
            this.chkCommlinks.UseVisualStyleBackColor = true;
            this.chkCommlinks.CheckedChanged += new System.EventHandler(this.chkCommlinks_CheckedChanged);
            // 
            // cboGearSleaze
            // 
            this.cboGearSleaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGearSleaze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGearSleaze.FormattingEnabled = true;
            this.cboGearSleaze.Location = new System.Drawing.Point(578, 209);
            this.cboGearSleaze.Name = "cboGearSleaze";
            this.cboGearSleaze.Size = new System.Drawing.Size(78, 21);
            this.cboGearSleaze.TabIndex = 157;
            this.cboGearSleaze.TooltipText = "";
            this.cboGearSleaze.Visible = false;
            this.cboGearSleaze.SelectedIndexChanged += new System.EventHandler(this.cboGearSleaze_SelectedIndexChanged);
            // 
            // lblGearNameLabel
            // 
            this.lblGearNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearNameLabel.AutoSize = true;
            this.lblGearNameLabel.Location = new System.Drawing.Point(344, 35);
            this.lblGearNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearNameLabel.Name = "lblGearNameLabel";
            this.lblGearNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblGearNameLabel.TabIndex = 53;
            this.lblGearNameLabel.Tag = "Label_Name";
            this.lblGearNameLabel.Text = "Name:";
            // 
            // cboGearAttack
            // 
            this.cboGearAttack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGearAttack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGearAttack.FormattingEnabled = true;
            this.cboGearAttack.Location = new System.Drawing.Point(494, 209);
            this.cboGearAttack.Name = "cboGearAttack";
            this.cboGearAttack.Size = new System.Drawing.Size(78, 21);
            this.cboGearAttack.TabIndex = 156;
            this.cboGearAttack.TooltipText = "";
            this.cboGearAttack.Visible = false;
            this.cboGearAttack.SelectedIndexChanged += new System.EventHandler(this.cboGearAttack_SelectedIndexChanged);
            // 
            // lblGearName
            // 
            this.lblGearName.AutoSize = true;
            this.lblGearName.Location = new System.Drawing.Point(388, 35);
            this.lblGearName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearName.Name = "lblGearName";
            this.lblGearName.Size = new System.Drawing.Size(41, 13);
            this.lblGearName.TabIndex = 54;
            this.lblGearName.Text = "[Name]";
            // 
            // lblGearCategoryLabel
            // 
            this.lblGearCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearCategoryLabel.AutoSize = true;
            this.lblGearCategoryLabel.Location = new System.Drawing.Point(330, 60);
            this.lblGearCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCategoryLabel.Name = "lblGearCategoryLabel";
            this.lblGearCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblGearCategoryLabel.TabIndex = 55;
            this.lblGearCategoryLabel.Tag = "Label_Category";
            this.lblGearCategoryLabel.Text = "Category:";
            // 
            // lblGearCategory
            // 
            this.lblGearCategory.AutoSize = true;
            this.lblGearCategory.Location = new System.Drawing.Point(388, 60);
            this.lblGearCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCategory.Name = "lblGearCategory";
            this.lblGearCategory.Size = new System.Drawing.Size(55, 13);
            this.lblGearCategory.TabIndex = 56;
            this.lblGearCategory.Text = "[Category]";
            // 
            // lblGearRatingLabel
            // 
            this.lblGearRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearRatingLabel.AutoSize = true;
            this.lblGearRatingLabel.Location = new System.Drawing.Point(341, 85);
            this.lblGearRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearRatingLabel.Name = "lblGearRatingLabel";
            this.lblGearRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblGearRatingLabel.TabIndex = 51;
            this.lblGearRatingLabel.Tag = "Label_Rating";
            this.lblGearRatingLabel.Text = "Rating:";
            // 
            // nudGearRating
            // 
            this.nudGearRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGearRating.AutoSize = true;
            this.nudGearRating.Enabled = false;
            this.nudGearRating.Location = new System.Drawing.Point(388, 82);
            this.nudGearRating.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudGearRating.MinimumSize = new System.Drawing.Size(100, 0);
            this.nudGearRating.Name = "nudGearRating";
            this.nudGearRating.Size = new System.Drawing.Size(100, 20);
            this.nudGearRating.TabIndex = 52;
            this.nudGearRating.ValueChanged += new System.EventHandler(this.nudGearRating_ValueChanged);
            // 
            // lblGearCapacityLabel
            // 
            this.lblGearCapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearCapacityLabel.AutoSize = true;
            this.lblGearCapacityLabel.Location = new System.Drawing.Point(331, 111);
            this.lblGearCapacityLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCapacityLabel.Name = "lblGearCapacityLabel";
            this.lblGearCapacityLabel.Size = new System.Drawing.Size(51, 13);
            this.lblGearCapacityLabel.TabIndex = 57;
            this.lblGearCapacityLabel.Tag = "Label_Capacity";
            this.lblGearCapacityLabel.Text = "Capacity:";
            // 
            // lblGearCapacity
            // 
            this.lblGearCapacity.AutoSize = true;
            this.lblGearCapacity.Location = new System.Drawing.Point(388, 111);
            this.lblGearCapacity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCapacity.Name = "lblGearCapacity";
            this.lblGearCapacity.Size = new System.Drawing.Size(54, 13);
            this.lblGearCapacity.TabIndex = 58;
            this.lblGearCapacity.Text = "[Capacity]";
            // 
            // lblGearQtyLabel
            // 
            this.lblGearQtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearQtyLabel.AutoSize = true;
            this.lblGearQtyLabel.Location = new System.Drawing.Point(356, 136);
            this.lblGearQtyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearQtyLabel.Name = "lblGearQtyLabel";
            this.lblGearQtyLabel.Size = new System.Drawing.Size(26, 13);
            this.lblGearQtyLabel.TabIndex = 63;
            this.lblGearQtyLabel.Tag = "Label_Qty";
            this.lblGearQtyLabel.Text = "Qty:";
            // 
            // chkGearEquipped
            // 
            this.chkGearEquipped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGearEquipped.AutoSize = true;
            this.tlpGear.SetColumnSpan(this.chkGearEquipped, 4);
            this.chkGearEquipped.Location = new System.Drawing.Point(494, 160);
            this.chkGearEquipped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkGearEquipped.Name = "chkGearEquipped";
            this.chkGearEquipped.Size = new System.Drawing.Size(330, 17);
            this.chkGearEquipped.TabIndex = 93;
            this.chkGearEquipped.Tag = "Checkbox_Equipped";
            this.chkGearEquipped.Text = "Equipped";
            this.chkGearEquipped.UseVisualStyleBackColor = true;
            this.chkGearEquipped.Visible = false;
            this.chkGearEquipped.CheckedChanged += new System.EventHandler(this.chkGearEquipped_CheckedChanged);
            // 
            // lblGearAP
            // 
            this.lblGearAP.AutoSize = true;
            this.lblGearAP.Location = new System.Drawing.Point(578, 60);
            this.lblGearAP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearAP.Name = "lblGearAP";
            this.lblGearAP.Size = new System.Drawing.Size(19, 13);
            this.lblGearAP.TabIndex = 107;
            this.lblGearAP.Text = "[0]";
            // 
            // nudGearQty
            // 
            this.nudGearQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGearQty.AutoSize = true;
            this.nudGearQty.Enabled = false;
            this.nudGearQty.Location = new System.Drawing.Point(388, 133);
            this.nudGearQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudGearQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGearQty.MinimumSize = new System.Drawing.Size(100, 0);
            this.nudGearQty.Name = "nudGearQty";
            this.nudGearQty.Size = new System.Drawing.Size(100, 20);
            this.nudGearQty.TabIndex = 64;
            this.nudGearQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGearQty.ValueChanged += new System.EventHandler(this.nudGearQty_ValueChanged);
            // 
            // lblGearAPLabel
            // 
            this.lblGearAPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearAPLabel.AutoSize = true;
            this.lblGearAPLabel.Location = new System.Drawing.Point(548, 60);
            this.lblGearAPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearAPLabel.Name = "lblGearAPLabel";
            this.lblGearAPLabel.Size = new System.Drawing.Size(24, 13);
            this.lblGearAPLabel.TabIndex = 106;
            this.lblGearAPLabel.Tag = "Label_AP";
            this.lblGearAPLabel.Text = "AP:";
            // 
            // lblGearSource
            // 
            this.lblGearSource.AutoSize = true;
            this.lblGearSource.Location = new System.Drawing.Point(388, 162);
            this.lblGearSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearSource.Name = "lblGearSource";
            this.lblGearSource.Size = new System.Drawing.Size(47, 13);
            this.lblGearSource.TabIndex = 74;
            this.lblGearSource.Text = "[Source]";
            this.lblGearSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblGearDamageLabel
            // 
            this.lblGearDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearDamageLabel.AutoSize = true;
            this.lblGearDamageLabel.Location = new System.Drawing.Point(522, 35);
            this.lblGearDamageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearDamageLabel.Name = "lblGearDamageLabel";
            this.lblGearDamageLabel.Size = new System.Drawing.Size(50, 13);
            this.lblGearDamageLabel.TabIndex = 104;
            this.lblGearDamageLabel.Tag = "Label_Damage";
            this.lblGearDamageLabel.Text = "Damage:";
            // 
            // lblGearSourceLabel
            // 
            this.lblGearSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearSourceLabel.AutoSize = true;
            this.lblGearSourceLabel.Location = new System.Drawing.Point(338, 162);
            this.lblGearSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearSourceLabel.Name = "lblGearSourceLabel";
            this.lblGearSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblGearSourceLabel.TabIndex = 73;
            this.lblGearSourceLabel.Tag = "Label_Source";
            this.lblGearSourceLabel.Text = "Source:";
            // 
            // lblGearDamage
            // 
            this.lblGearDamage.AutoSize = true;
            this.lblGearDamage.Location = new System.Drawing.Point(578, 35);
            this.lblGearDamage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearDamage.Name = "lblGearDamage";
            this.lblGearDamage.Size = new System.Drawing.Size(19, 13);
            this.lblGearDamage.TabIndex = 105;
            this.lblGearDamage.Text = "[0]";
            // 
            // lblGearAvailLabel
            // 
            this.lblGearAvailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearAvailLabel.AutoSize = true;
            this.lblGearAvailLabel.Location = new System.Drawing.Point(539, 85);
            this.lblGearAvailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearAvailLabel.Name = "lblGearAvailLabel";
            this.lblGearAvailLabel.Size = new System.Drawing.Size(33, 13);
            this.lblGearAvailLabel.TabIndex = 59;
            this.lblGearAvailLabel.Tag = "Label_Avail";
            this.lblGearAvailLabel.Text = "Avail:";
            // 
            // lblGearAvail
            // 
            this.lblGearAvail.AutoSize = true;
            this.lblGearAvail.Location = new System.Drawing.Point(578, 85);
            this.lblGearAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearAvail.Name = "lblGearAvail";
            this.lblGearAvail.Size = new System.Drawing.Size(36, 13);
            this.lblGearAvail.TabIndex = 60;
            this.lblGearAvail.Text = "[Avail]";
            // 
            // lblGearCostLabel
            // 
            this.lblGearCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGearCostLabel.AutoSize = true;
            this.lblGearCostLabel.Location = new System.Drawing.Point(541, 111);
            this.lblGearCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCostLabel.Name = "lblGearCostLabel";
            this.lblGearCostLabel.Size = new System.Drawing.Size(31, 13);
            this.lblGearCostLabel.TabIndex = 61;
            this.lblGearCostLabel.Tag = "Label_Cost";
            this.lblGearCostLabel.Text = "Cost:";
            // 
            // lblGearCost
            // 
            this.lblGearCost.AutoSize = true;
            this.lblGearCost.Location = new System.Drawing.Point(578, 111);
            this.lblGearCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblGearCost.Name = "lblGearCost";
            this.lblGearCost.Size = new System.Drawing.Size(34, 13);
            this.lblGearCost.TabIndex = 62;
            this.lblGearCost.Text = "[Cost]";
            // 
            // tabArmor
            // 
            this.tabArmor.BackColor = System.Drawing.SystemColors.Control;
            this.tabArmor.Controls.Add(this.tlpArmor);
            this.tabArmor.Location = new System.Drawing.Point(4, 22);
            this.tabArmor.Name = "tabArmor";
            this.tabArmor.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmor.Size = new System.Drawing.Size(184, 48);
            this.tabArmor.TabIndex = 1;
            this.tabArmor.Tag = "Tab_Armor";
            this.tabArmor.Text = "Armor";
            // 
            // tlpArmor
            // 
            this.tlpArmor.ColumnCount = 7;
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArmor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpArmor.Controls.Add(this.chkIncludedInArmor, 5, 4);
            this.tlpArmor.Controls.Add(this.cmdArmorUnEquipAll, 4, 7);
            this.tlpArmor.Controls.Add(this.lblArmorEquippedLabel, 1, 7);
            this.tlpArmor.Controls.Add(this.lblArmorFirewall, 6, 6);
            this.tlpArmor.Controls.Add(this.treArmor, 0, 1);
            this.tlpArmor.Controls.Add(this.lblArmorDataProcessing, 5, 6);
            this.tlpArmor.Controls.Add(this.lblArmorFirewallLabel, 6, 5);
            this.tlpArmor.Controls.Add(this.lblArmorSleaze, 4, 6);
            this.tlpArmor.Controls.Add(this.lblArmorValueLabel, 1, 1);
            this.tlpArmor.Controls.Add(this.chkArmorEquipped, 3, 4);
            this.tlpArmor.Controls.Add(this.lblArmorSource, 2, 4);
            this.tlpArmor.Controls.Add(this.lblArmorAttack, 3, 6);
            this.tlpArmor.Controls.Add(this.lblArmorValue, 2, 1);
            this.tlpArmor.Controls.Add(this.lblArmorDeviceRating, 2, 6);
            this.tlpArmor.Controls.Add(this.lblArmorDataProcessingLabel, 5, 5);
            this.tlpArmor.Controls.Add(this.lblArmorDeviceRatingLabel, 1, 6);
            this.tlpArmor.Controls.Add(this.lblArmorRatingLabel, 1, 2);
            this.tlpArmor.Controls.Add(this.nudArmorRating, 2, 2);
            this.tlpArmor.Controls.Add(this.lblArmorAvailLabel, 3, 2);
            this.tlpArmor.Controls.Add(this.lblArmorAvail, 4, 2);
            this.tlpArmor.Controls.Add(this.lblArmorCapacityLabel, 1, 3);
            this.tlpArmor.Controls.Add(this.lblArmorCapacity, 2, 3);
            this.tlpArmor.Controls.Add(this.lblArmorSourceLabel, 1, 4);
            this.tlpArmor.Controls.Add(this.lblArmorCostLabel, 3, 3);
            this.tlpArmor.Controls.Add(this.lblArmorCost, 4, 3);
            this.tlpArmor.Controls.Add(this.lblArmorAttackLabel, 3, 5);
            this.tlpArmor.Controls.Add(this.lblArmorSleazeLabel, 4, 5);
            this.tlpArmor.Controls.Add(this.cmdArmorEquipAll, 3, 7);
            this.tlpArmor.Controls.Add(this.lblArmorEquipped, 1, 8);
            this.tlpArmor.Controls.Add(this.flowLayoutPanel14, 0, 0);
            this.tlpArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpArmor.Location = new System.Drawing.Point(3, 3);
            this.tlpArmor.Name = "tlpArmor";
            this.tlpArmor.RowCount = 9;
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpArmor.Size = new System.Drawing.Size(178, 42);
            this.tlpArmor.TabIndex = 176;
            // 
            // chkIncludedInArmor
            // 
            this.chkIncludedInArmor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludedInArmor.AutoSize = true;
            this.tlpArmor.SetColumnSpan(this.chkIncludedInArmor, 2);
            this.chkIncludedInArmor.Enabled = false;
            this.chkIncludedInArmor.Location = new System.Drawing.Point(316, 138);
            this.chkIncludedInArmor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludedInArmor.Name = "chkIncludedInArmor";
            this.chkIncludedInArmor.Size = new System.Drawing.Size(1, 17);
            this.chkIncludedInArmor.TabIndex = 113;
            this.chkIncludedInArmor.Tag = "Checkbox_BaseArmor";
            this.chkIncludedInArmor.Text = "Part of base Armor";
            this.chkIncludedInArmor.UseVisualStyleBackColor = true;
            this.chkIncludedInArmor.CheckedChanged += new System.EventHandler(this.chkIncludedInArmor_CheckedChanged);
            // 
            // cmdArmorUnEquipAll
            // 
            this.cmdArmorUnEquipAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdArmorUnEquipAll.AutoSize = true;
            this.cmdArmorUnEquipAll.Location = new System.Drawing.Point(382, 199);
            this.cmdArmorUnEquipAll.Name = "cmdArmorUnEquipAll";
            this.cmdArmorUnEquipAll.Size = new System.Drawing.Size(1, 23);
            this.cmdArmorUnEquipAll.TabIndex = 109;
            this.cmdArmorUnEquipAll.Tag = "Button_UnEquipAll";
            this.cmdArmorUnEquipAll.Text = "Un-Equip All";
            this.cmdArmorUnEquipAll.UseVisualStyleBackColor = true;
            this.cmdArmorUnEquipAll.Visible = false;
            this.cmdArmorUnEquipAll.Click += new System.EventHandler(this.cmdArmorUnEquipAll_Click);
            // 
            // lblArmorEquippedLabel
            // 
            this.lblArmorEquippedLabel.AutoSize = true;
            this.tlpArmor.SetColumnSpan(this.lblArmorEquippedLabel, 2);
            this.lblArmorEquippedLabel.Location = new System.Drawing.Point(304, 202);
            this.lblArmorEquippedLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorEquippedLabel.Name = "lblArmorEquippedLabel";
            this.lblArmorEquippedLabel.Size = new System.Drawing.Size(52, 13);
            this.lblArmorEquippedLabel.TabIndex = 110;
            this.lblArmorEquippedLabel.Tag = "Checkbox_Equipped";
            this.lblArmorEquippedLabel.Text = "Equipped";
            this.lblArmorEquippedLabel.Visible = false;
            // 
            // lblArmorFirewall
            // 
            this.lblArmorFirewall.AutoSize = true;
            this.lblArmorFirewall.Location = new System.Drawing.Point(250, 177);
            this.lblArmorFirewall.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorFirewall.Name = "lblArmorFirewall";
            this.lblArmorFirewall.Size = new System.Drawing.Size(1, 13);
            this.lblArmorFirewall.TabIndex = 175;
            this.lblArmorFirewall.Text = "[0]";
            // 
            // treArmor
            // 
            this.treArmor.AllowDrop = true;
            this.treArmor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treArmor.HideSelection = false;
            this.treArmor.Location = new System.Drawing.Point(3, 61);
            this.treArmor.Name = "treArmor";
            treeNode1.Name = "nodArmorRoot";
            treeNode1.Tag = "Node_SelectedArmor";
            treeNode1.Text = "Selected Armor";
            this.treArmor.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tlpArmor.SetRowSpan(this.treArmor, 8);
            this.treArmor.ShowNodeToolTips = true;
            this.treArmor.Size = new System.Drawing.Size(295, 565);
            this.treArmor.TabIndex = 69;
            this.treArmor.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treArmor_AfterSelect);
            this.treArmor.DragOver += new System.Windows.Forms.DragEventHandler(this.treArmor_DragOver);
            this.treArmor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treArmor_KeyDown);
            this.treArmor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblArmorDataProcessing
            // 
            this.lblArmorDataProcessing.AutoSize = true;
            this.lblArmorDataProcessing.Location = new System.Drawing.Point(316, 177);
            this.lblArmorDataProcessing.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorDataProcessing.Name = "lblArmorDataProcessing";
            this.lblArmorDataProcessing.Size = new System.Drawing.Size(1, 13);
            this.lblArmorDataProcessing.TabIndex = 173;
            this.lblArmorDataProcessing.Text = "[0]";
            // 
            // lblArmorFirewallLabel
            // 
            this.lblArmorFirewallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArmorFirewallLabel.AutoSize = true;
            this.lblArmorFirewallLabel.Location = new System.Drawing.Point(250, 165);
            this.lblArmorFirewallLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorFirewallLabel.Name = "lblArmorFirewallLabel";
            this.lblArmorFirewallLabel.Size = new System.Drawing.Size(1, 1);
            this.lblArmorFirewallLabel.TabIndex = 174;
            this.lblArmorFirewallLabel.Tag = "Label_Firewall";
            this.lblArmorFirewallLabel.Text = "Firewall:";
            // 
            // lblArmorSleaze
            // 
            this.lblArmorSleaze.AutoSize = true;
            this.lblArmorSleaze.Location = new System.Drawing.Point(382, 177);
            this.lblArmorSleaze.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorSleaze.Name = "lblArmorSleaze";
            this.lblArmorSleaze.Size = new System.Drawing.Size(1, 13);
            this.lblArmorSleaze.TabIndex = 171;
            this.lblArmorSleaze.Text = "[0]";
            // 
            // lblArmorValueLabel
            // 
            this.lblArmorValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorValueLabel.AutoSize = true;
            this.lblArmorValueLabel.Location = new System.Drawing.Point(345, 64);
            this.lblArmorValueLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorValueLabel.Name = "lblArmorValueLabel";
            this.lblArmorValueLabel.Size = new System.Drawing.Size(37, 13);
            this.lblArmorValueLabel.TabIndex = 132;
            this.lblArmorValueLabel.Tag = "Label_Armor";
            this.lblArmorValueLabel.Text = "Armor:";
            // 
            // lblArmorSource
            // 
            this.lblArmorSource.AutoSize = true;
            this.lblArmorSource.Location = new System.Drawing.Point(388, 140);
            this.lblArmorSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorSource.Name = "lblArmorSource";
            this.lblArmorSource.Size = new System.Drawing.Size(47, 13);
            this.lblArmorSource.TabIndex = 80;
            this.lblArmorSource.Text = "[Source]";
            this.lblArmorSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblArmorAttack
            // 
            this.lblArmorAttack.AutoSize = true;
            this.lblArmorAttack.Location = new System.Drawing.Point(448, 177);
            this.lblArmorAttack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorAttack.Name = "lblArmorAttack";
            this.lblArmorAttack.Size = new System.Drawing.Size(1, 13);
            this.lblArmorAttack.TabIndex = 169;
            this.lblArmorAttack.Text = "[0]";
            // 
            // lblArmorValue
            // 
            this.lblArmorValue.AutoSize = true;
            this.lblArmorValue.Location = new System.Drawing.Point(388, 64);
            this.lblArmorValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorValue.Name = "lblArmorValue";
            this.lblArmorValue.Size = new System.Drawing.Size(20, 13);
            this.lblArmorValue.TabIndex = 133;
            this.lblArmorValue.Text = "[A]";
            // 
            // lblArmorDeviceRating
            // 
            this.lblArmorDeviceRating.AutoSize = true;
            this.lblArmorDeviceRating.Location = new System.Drawing.Point(388, 177);
            this.lblArmorDeviceRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorDeviceRating.Name = "lblArmorDeviceRating";
            this.lblArmorDeviceRating.Size = new System.Drawing.Size(19, 13);
            this.lblArmorDeviceRating.TabIndex = 167;
            this.lblArmorDeviceRating.Text = "[0]";
            // 
            // lblArmorDataProcessingLabel
            // 
            this.lblArmorDataProcessingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArmorDataProcessingLabel.AutoSize = true;
            this.lblArmorDataProcessingLabel.Location = new System.Drawing.Point(316, 165);
            this.lblArmorDataProcessingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorDataProcessingLabel.Name = "lblArmorDataProcessingLabel";
            this.lblArmorDataProcessingLabel.Size = new System.Drawing.Size(1, 1);
            this.lblArmorDataProcessingLabel.TabIndex = 172;
            this.lblArmorDataProcessingLabel.Tag = "Label_DataProcessing";
            this.lblArmorDataProcessingLabel.Text = "Data Proc.:";
            // 
            // lblArmorDeviceRatingLabel
            // 
            this.lblArmorDeviceRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorDeviceRatingLabel.AutoSize = true;
            this.lblArmorDeviceRatingLabel.Location = new System.Drawing.Point(304, 177);
            this.lblArmorDeviceRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorDeviceRatingLabel.Name = "lblArmorDeviceRatingLabel";
            this.lblArmorDeviceRatingLabel.Size = new System.Drawing.Size(78, 13);
            this.lblArmorDeviceRatingLabel.TabIndex = 166;
            this.lblArmorDeviceRatingLabel.Tag = "Label_DeviceRating";
            this.lblArmorDeviceRatingLabel.Text = "Device Rating:";
            // 
            // lblArmorRatingLabel
            // 
            this.lblArmorRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorRatingLabel.AutoSize = true;
            this.lblArmorRatingLabel.Location = new System.Drawing.Point(341, 89);
            this.lblArmorRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorRatingLabel.Name = "lblArmorRatingLabel";
            this.lblArmorRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblArmorRatingLabel.TabIndex = 81;
            this.lblArmorRatingLabel.Tag = "Label_Rating";
            this.lblArmorRatingLabel.Text = "Rating:";
            // 
            // nudArmorRating
            // 
            this.nudArmorRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudArmorRating.Enabled = false;
            this.nudArmorRating.Location = new System.Drawing.Point(388, 86);
            this.nudArmorRating.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudArmorRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudArmorRating.Name = "nudArmorRating";
            this.nudArmorRating.Size = new System.Drawing.Size(54, 20);
            this.nudArmorRating.TabIndex = 82;
            this.nudArmorRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudArmorRating.ValueChanged += new System.EventHandler(this.nudArmorRating_ValueChanged);
            // 
            // lblArmorAvailLabel
            // 
            this.lblArmorAvailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorAvailLabel.AutoSize = true;
            this.lblArmorAvailLabel.Location = new System.Drawing.Point(448, 89);
            this.lblArmorAvailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorAvailLabel.Name = "lblArmorAvailLabel";
            this.lblArmorAvailLabel.Size = new System.Drawing.Size(1, 13);
            this.lblArmorAvailLabel.TabIndex = 74;
            this.lblArmorAvailLabel.Tag = "Label_Avail";
            this.lblArmorAvailLabel.Text = "Avail:";
            // 
            // lblArmorAvail
            // 
            this.lblArmorAvail.AutoSize = true;
            this.lblArmorAvail.Location = new System.Drawing.Point(382, 89);
            this.lblArmorAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorAvail.Name = "lblArmorAvail";
            this.lblArmorAvail.Size = new System.Drawing.Size(1, 13);
            this.lblArmorAvail.TabIndex = 75;
            this.lblArmorAvail.Text = "[Avail]";
            // 
            // lblArmorCapacityLabel
            // 
            this.lblArmorCapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorCapacityLabel.AutoSize = true;
            this.lblArmorCapacityLabel.Location = new System.Drawing.Point(331, 115);
            this.lblArmorCapacityLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorCapacityLabel.Name = "lblArmorCapacityLabel";
            this.lblArmorCapacityLabel.Size = new System.Drawing.Size(51, 13);
            this.lblArmorCapacityLabel.TabIndex = 83;
            this.lblArmorCapacityLabel.Tag = "Label_Capacity";
            this.lblArmorCapacityLabel.Text = "Capacity:";
            // 
            // lblArmorCapacity
            // 
            this.lblArmorCapacity.AutoSize = true;
            this.lblArmorCapacity.Location = new System.Drawing.Point(388, 115);
            this.lblArmorCapacity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorCapacity.Name = "lblArmorCapacity";
            this.lblArmorCapacity.Size = new System.Drawing.Size(54, 13);
            this.lblArmorCapacity.TabIndex = 84;
            this.lblArmorCapacity.Text = "[Capacity]";
            // 
            // lblArmorSourceLabel
            // 
            this.lblArmorSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorSourceLabel.AutoSize = true;
            this.lblArmorSourceLabel.Location = new System.Drawing.Point(338, 140);
            this.lblArmorSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorSourceLabel.Name = "lblArmorSourceLabel";
            this.lblArmorSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblArmorSourceLabel.TabIndex = 79;
            this.lblArmorSourceLabel.Tag = "Label_Source";
            this.lblArmorSourceLabel.Text = "Source:";
            // 
            // lblArmorCostLabel
            // 
            this.lblArmorCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArmorCostLabel.AutoSize = true;
            this.lblArmorCostLabel.Location = new System.Drawing.Point(448, 115);
            this.lblArmorCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorCostLabel.Name = "lblArmorCostLabel";
            this.lblArmorCostLabel.Size = new System.Drawing.Size(1, 13);
            this.lblArmorCostLabel.TabIndex = 76;
            this.lblArmorCostLabel.Tag = "Label_Cost";
            this.lblArmorCostLabel.Text = "Cost:";
            // 
            // lblArmorCost
            // 
            this.lblArmorCost.AutoSize = true;
            this.lblArmorCost.Location = new System.Drawing.Point(382, 115);
            this.lblArmorCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorCost.Name = "lblArmorCost";
            this.lblArmorCost.Size = new System.Drawing.Size(1, 13);
            this.lblArmorCost.TabIndex = 77;
            this.lblArmorCost.Text = "[Cost]";
            // 
            // lblArmorAttackLabel
            // 
            this.lblArmorAttackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArmorAttackLabel.AutoSize = true;
            this.lblArmorAttackLabel.Location = new System.Drawing.Point(448, 165);
            this.lblArmorAttackLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorAttackLabel.Name = "lblArmorAttackLabel";
            this.lblArmorAttackLabel.Size = new System.Drawing.Size(1, 1);
            this.lblArmorAttackLabel.TabIndex = 168;
            this.lblArmorAttackLabel.Tag = "Label_Attack";
            this.lblArmorAttackLabel.Text = "Attack:";
            // 
            // lblArmorSleazeLabel
            // 
            this.lblArmorSleazeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblArmorSleazeLabel.AutoSize = true;
            this.lblArmorSleazeLabel.Location = new System.Drawing.Point(382, 165);
            this.lblArmorSleazeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorSleazeLabel.Name = "lblArmorSleazeLabel";
            this.lblArmorSleazeLabel.Size = new System.Drawing.Size(1, 1);
            this.lblArmorSleazeLabel.TabIndex = 170;
            this.lblArmorSleazeLabel.Tag = "Label_Sleaze";
            this.lblArmorSleazeLabel.Text = "Sleaze:";
            // 
            // cmdArmorEquipAll
            // 
            this.cmdArmorEquipAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdArmorEquipAll.AutoSize = true;
            this.cmdArmorEquipAll.Location = new System.Drawing.Point(448, 199);
            this.cmdArmorEquipAll.Name = "cmdArmorEquipAll";
            this.cmdArmorEquipAll.Size = new System.Drawing.Size(1, 23);
            this.cmdArmorEquipAll.TabIndex = 108;
            this.cmdArmorEquipAll.Tag = "Button_EquipAll";
            this.cmdArmorEquipAll.Text = "Equip All";
            this.cmdArmorEquipAll.UseVisualStyleBackColor = true;
            this.cmdArmorEquipAll.Visible = false;
            this.cmdArmorEquipAll.Click += new System.EventHandler(this.cmdArmorEquipAll_Click);
            // 
            // lblArmorEquipped
            // 
            this.lblArmorEquipped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpArmor.SetColumnSpan(this.lblArmorEquipped, 6);
            this.lblArmorEquipped.Location = new System.Drawing.Point(304, 231);
            this.lblArmorEquipped.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmorEquipped.Name = "lblArmorEquipped";
            this.lblArmorEquipped.Size = new System.Drawing.Size(1, 392);
            this.lblArmorEquipped.TabIndex = 111;
            this.lblArmorEquipped.Text = "[Armor Bundle Equipped Items]";
            this.lblArmorEquipped.Visible = false;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.AutoSize = true;
            this.tlpArmor.SetColumnSpan(this.flowLayoutPanel14, 7);
            this.flowLayoutPanel14.Controls.Add(this.cmdAddArmor);
            this.flowLayoutPanel14.Controls.Add(this.cmdDeleteArmor);
            this.flowLayoutPanel14.Controls.Add(this.cmdAddArmorBundle);
            this.flowLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(176, 58);
            this.flowLayoutPanel14.TabIndex = 176;
            // 
            // cmdAddArmor
            // 
            this.cmdAddArmor.AutoSize = true;
            this.cmdAddArmor.ContextMenuStrip = this.cmsArmor;
            this.cmdAddArmor.Location = new System.Drawing.Point(3, 3);
            this.cmdAddArmor.Name = "cmdAddArmor";
            this.cmdAddArmor.Size = new System.Drawing.Size(84, 23);
            this.cmdAddArmor.SplitMenuStrip = this.cmsArmor;
            this.cmdAddArmor.TabIndex = 131;
            this.cmdAddArmor.Tag = "Button_AddArmor";
            this.cmdAddArmor.Text = "&Add Armor";
            this.cmdAddArmor.UseVisualStyleBackColor = true;
            this.cmdAddArmor.Click += new System.EventHandler(this.cmdAddArmor_Click);
            // 
            // cmdDeleteArmor
            // 
            this.cmdDeleteArmor.AutoSize = true;
            this.cmdDeleteArmor.Location = new System.Drawing.Point(93, 3);
            this.cmdDeleteArmor.Name = "cmdDeleteArmor";
            this.cmdDeleteArmor.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteArmor.TabIndex = 68;
            this.cmdDeleteArmor.Tag = "String_Delete";
            this.cmdDeleteArmor.Text = "Delete";
            this.cmdDeleteArmor.UseVisualStyleBackColor = true;
            this.cmdDeleteArmor.Click += new System.EventHandler(this.cmdDeleteArmor_Click);
            // 
            // cmdAddArmorBundle
            // 
            this.cmdAddArmorBundle.AutoSize = true;
            this.cmdAddArmorBundle.Location = new System.Drawing.Point(3, 32);
            this.cmdAddArmorBundle.Name = "cmdAddArmorBundle";
            this.cmdAddArmorBundle.Size = new System.Drawing.Size(102, 23);
            this.cmdAddArmorBundle.TabIndex = 104;
            this.cmdAddArmorBundle.Tag = "Button_AddBundle";
            this.cmdAddArmorBundle.Text = "Add Armor Bundle";
            this.cmdAddArmorBundle.UseVisualStyleBackColor = true;
            this.cmdAddArmorBundle.Click += new System.EventHandler(this.cmdAddArmorBundle_Click);
            // 
            // tabWeapons
            // 
            this.tabWeapons.BackColor = System.Drawing.SystemColors.Control;
            this.tabWeapons.Controls.Add(this.tlpWeapons);
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(184, 48);
            this.tabWeapons.TabIndex = 2;
            this.tabWeapons.Tag = "Tab_Weapons";
            this.tabWeapons.Text = "Weapons";
            // 
            // tlpWeapons
            // 
            this.tlpWeapons.ColumnCount = 8;
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpWeapons.Controls.Add(this.lblWeaponCapacity, 2, 4);
            this.tlpWeapons.Controls.Add(this.treWeapons, 0, 1);
            this.tlpWeapons.Controls.Add(this.lblWeaponCapacityLabel, 1, 4);
            this.tlpWeapons.Controls.Add(this.lblWeaponNameLabel, 1, 1);
            this.tlpWeapons.Controls.Add(this.lblWeaponName, 2, 1);
            this.tlpWeapons.Controls.Add(this.lblWeaponCategoryLabel, 1, 2);
            this.tlpWeapons.Controls.Add(this.lblWeaponCategory, 2, 2);
            this.tlpWeapons.Controls.Add(this.flowLayoutPanel15, 0, 0);
            this.tlpWeapons.Controls.Add(this.lblWeaponDamageLabel, 3, 1);
            this.tlpWeapons.Controls.Add(this.lblWeaponDamage, 4, 1);
            this.tlpWeapons.Controls.Add(this.lblWeaponRating, 2, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponRatingLabel, 1, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponAPLabel, 3, 2);
            this.tlpWeapons.Controls.Add(this.lblWeaponAP, 4, 2);
            this.tlpWeapons.Controls.Add(this.lblWeaponAccuracyLabel, 1, 6);
            this.tlpWeapons.Controls.Add(this.lblWeaponAccuracy, 2, 6);
            this.tlpWeapons.Controls.Add(this.lblWeaponSlotsLabel, 1, 5);
            this.tlpWeapons.Controls.Add(this.lblWeaponSlots, 2, 5);
            this.tlpWeapons.Controls.Add(this.lblWeaponConceal, 4, 5);
            this.tlpWeapons.Controls.Add(this.lblWeaponSourceLabel, 1, 7);
            this.tlpWeapons.Controls.Add(this.lblWeaponConcealLabel, 3, 5);
            this.tlpWeapons.Controls.Add(this.lblWeaponSource, 2, 7);
            this.tlpWeapons.Controls.Add(this.lblWeaponAvailLabel, 3, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponAvail, 4, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponCostLabel, 3, 4);
            this.tlpWeapons.Controls.Add(this.lblWeaponCost, 4, 4);
            this.tlpWeapons.Controls.Add(this.lblWeaponReachLabel, 5, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponReach, 6, 3);
            this.tlpWeapons.Controls.Add(this.lblWeaponAmmoLabel, 5, 4);
            this.tlpWeapons.Controls.Add(this.lblWeaponAmmo, 6, 4);
            this.tlpWeapons.Controls.Add(this.lblWeaponModeLabel, 5, 5);
            this.tlpWeapons.Controls.Add(this.chkWeaponAccessoryInstalled, 5, 7);
            this.tlpWeapons.Controls.Add(this.chkIncludedInWeapon, 3, 7);
            this.tlpWeapons.Controls.Add(this.lblWeaponMode, 6, 5);
            this.tlpWeapons.Controls.Add(this.lblWeaponRCLabel, 3, 6);
            this.tlpWeapons.Controls.Add(this.lblWeaponRC, 4, 6);
            this.tlpWeapons.Controls.Add(this.tableLayoutPanel4, 1, 8);
            this.tlpWeapons.Controls.Add(this.tableLayoutPanel5, 1, 9);
            this.tlpWeapons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWeapons.Location = new System.Drawing.Point(3, 3);
            this.tlpWeapons.Name = "tlpWeapons";
            this.tlpWeapons.RowCount = 10;
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWeapons.Size = new System.Drawing.Size(178, 42);
            this.tlpWeapons.TabIndex = 225;
            // 
            // lblWeaponCapacity
            // 
            this.lblWeaponCapacity.AutoSize = true;
            this.lblWeaponCapacity.Location = new System.Drawing.Point(367, 110);
            this.lblWeaponCapacity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCapacity.Name = "lblWeaponCapacity";
            this.lblWeaponCapacity.Size = new System.Drawing.Size(54, 13);
            this.lblWeaponCapacity.TabIndex = 224;
            this.lblWeaponCapacity.Text = "[Capacity]";
            // 
            // treWeapons
            // 
            this.treWeapons.AllowDrop = true;
            this.treWeapons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treWeapons.HideSelection = false;
            this.treWeapons.Location = new System.Drawing.Point(3, 32);
            this.treWeapons.Name = "treWeapons";
            treeNode2.Name = "nodWeaponsRoot";
            treeNode2.Tag = "Node_SelectedWeapons";
            treeNode2.Text = "Selected Weapons";
            this.treWeapons.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tlpWeapons.SetRowSpan(this.treWeapons, 10);
            this.treWeapons.ShowNodeToolTips = true;
            this.treWeapons.Size = new System.Drawing.Size(295, 564);
            this.treWeapons.TabIndex = 29;
            this.treWeapons.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treWeapons_AfterSelect);
            this.treWeapons.DragOver += new System.Windows.Forms.DragEventHandler(this.treWeapons_DragOver);
            this.treWeapons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treWeapons_KeyDown);
            this.treWeapons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblWeaponCapacityLabel
            // 
            this.lblWeaponCapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponCapacityLabel.AutoSize = true;
            this.lblWeaponCapacityLabel.Location = new System.Drawing.Point(310, 110);
            this.lblWeaponCapacityLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCapacityLabel.Name = "lblWeaponCapacityLabel";
            this.lblWeaponCapacityLabel.Size = new System.Drawing.Size(51, 13);
            this.lblWeaponCapacityLabel.TabIndex = 223;
            this.lblWeaponCapacityLabel.Tag = "Label_Capacity";
            this.lblWeaponCapacityLabel.Text = "Capacity:";
            // 
            // lblWeaponNameLabel
            // 
            this.lblWeaponNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponNameLabel.AutoSize = true;
            this.lblWeaponNameLabel.Location = new System.Drawing.Point(323, 35);
            this.lblWeaponNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponNameLabel.Name = "lblWeaponNameLabel";
            this.lblWeaponNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblWeaponNameLabel.TabIndex = 47;
            this.lblWeaponNameLabel.Tag = "Label_Name";
            this.lblWeaponNameLabel.Text = "Name:";
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(367, 35);
            this.lblWeaponName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(41, 13);
            this.lblWeaponName.TabIndex = 48;
            this.lblWeaponName.Text = "[Name]";
            // 
            // lblWeaponCategoryLabel
            // 
            this.lblWeaponCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponCategoryLabel.AutoSize = true;
            this.lblWeaponCategoryLabel.Location = new System.Drawing.Point(309, 60);
            this.lblWeaponCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCategoryLabel.Name = "lblWeaponCategoryLabel";
            this.lblWeaponCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblWeaponCategoryLabel.TabIndex = 49;
            this.lblWeaponCategoryLabel.Tag = "Label_Category";
            this.lblWeaponCategoryLabel.Text = "Category:";
            // 
            // lblWeaponCategory
            // 
            this.lblWeaponCategory.AutoSize = true;
            this.lblWeaponCategory.Location = new System.Drawing.Point(367, 60);
            this.lblWeaponCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCategory.Name = "lblWeaponCategory";
            this.lblWeaponCategory.Size = new System.Drawing.Size(55, 13);
            this.lblWeaponCategory.TabIndex = 50;
            this.lblWeaponCategory.Text = "[Category]";
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.AutoSize = true;
            this.tlpWeapons.SetColumnSpan(this.flowLayoutPanel15, 7);
            this.flowLayoutPanel15.Controls.Add(this.cmdAddWeapon);
            this.flowLayoutPanel15.Controls.Add(this.cmdDeleteWeapon);
            this.flowLayoutPanel15.Controls.Add(this.cmdAddWeaponLocation);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(276, 29);
            this.flowLayoutPanel15.TabIndex = 51;
            // 
            // cmdAddWeapon
            // 
            this.cmdAddWeapon.AutoSize = true;
            this.cmdAddWeapon.ContextMenuStrip = this.cmsWeapon;
            this.cmdAddWeapon.Location = new System.Drawing.Point(3, 3);
            this.cmdAddWeapon.Name = "cmdAddWeapon";
            this.cmdAddWeapon.Size = new System.Drawing.Size(98, 23);
            this.cmdAddWeapon.SplitMenuStrip = this.cmsWeapon;
            this.cmdAddWeapon.TabIndex = 154;
            this.cmdAddWeapon.Tag = "Button_AddWeapon";
            this.cmdAddWeapon.Text = "&Add Weapon";
            this.cmdAddWeapon.UseVisualStyleBackColor = true;
            this.cmdAddWeapon.Click += new System.EventHandler(this.cmdAddWeapon_Click);
            // 
            // cmdDeleteWeapon
            // 
            this.cmdDeleteWeapon.AutoSize = true;
            this.cmdDeleteWeapon.Location = new System.Drawing.Point(107, 3);
            this.cmdDeleteWeapon.Name = "cmdDeleteWeapon";
            this.cmdDeleteWeapon.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteWeapon.TabIndex = 46;
            this.cmdDeleteWeapon.Tag = "String_Delete";
            this.cmdDeleteWeapon.Text = "Delete";
            this.cmdDeleteWeapon.UseVisualStyleBackColor = true;
            this.cmdDeleteWeapon.Click += new System.EventHandler(this.cmdDeleteWeapon_Click);
            // 
            // cmdAddWeaponLocation
            // 
            this.cmdAddWeaponLocation.AutoSize = true;
            this.cmdAddWeaponLocation.Location = new System.Drawing.Point(193, 3);
            this.cmdAddWeaponLocation.Name = "cmdAddWeaponLocation";
            this.cmdAddWeaponLocation.Size = new System.Drawing.Size(80, 23);
            this.cmdAddWeaponLocation.TabIndex = 114;
            this.cmdAddWeaponLocation.Tag = "Button_AddLocation";
            this.cmdAddWeaponLocation.Text = "Add Location";
            this.cmdAddWeaponLocation.UseVisualStyleBackColor = true;
            this.cmdAddWeaponLocation.Click += new System.EventHandler(this.cmdAddWeaponLocation_Click);
            // 
            // lblWeaponDamageLabel
            // 
            this.lblWeaponDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponDamageLabel.AutoSize = true;
            this.lblWeaponDamageLabel.Location = new System.Drawing.Point(431, 35);
            this.lblWeaponDamageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDamageLabel.Name = "lblWeaponDamageLabel";
            this.lblWeaponDamageLabel.Size = new System.Drawing.Size(50, 13);
            this.lblWeaponDamageLabel.TabIndex = 51;
            this.lblWeaponDamageLabel.Tag = "Label_Damage";
            this.lblWeaponDamageLabel.Text = "Damage:";
            // 
            // lblWeaponDamage
            // 
            this.lblWeaponDamage.AutoSize = true;
            this.lblWeaponDamage.Location = new System.Drawing.Point(487, 35);
            this.lblWeaponDamage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDamage.Name = "lblWeaponDamage";
            this.lblWeaponDamage.Size = new System.Drawing.Size(53, 13);
            this.lblWeaponDamage.TabIndex = 52;
            this.lblWeaponDamage.Text = "[Damage]";
            // 
            // lblWeaponRating
            // 
            this.lblWeaponRating.AutoSize = true;
            this.lblWeaponRating.Location = new System.Drawing.Point(367, 85);
            this.lblWeaponRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRating.Name = "lblWeaponRating";
            this.lblWeaponRating.Size = new System.Drawing.Size(44, 13);
            this.lblWeaponRating.TabIndex = 167;
            this.lblWeaponRating.Text = "[Rating]";
            // 
            // lblWeaponRatingLabel
            // 
            this.lblWeaponRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRatingLabel.AutoSize = true;
            this.lblWeaponRatingLabel.Location = new System.Drawing.Point(320, 85);
            this.lblWeaponRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRatingLabel.Name = "lblWeaponRatingLabel";
            this.lblWeaponRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblWeaponRatingLabel.TabIndex = 166;
            this.lblWeaponRatingLabel.Tag = "Label_Rating";
            this.lblWeaponRatingLabel.Text = "Rating:";
            // 
            // lblWeaponAPLabel
            // 
            this.lblWeaponAPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAPLabel.AutoSize = true;
            this.lblWeaponAPLabel.Location = new System.Drawing.Point(457, 60);
            this.lblWeaponAPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAPLabel.Name = "lblWeaponAPLabel";
            this.lblWeaponAPLabel.Size = new System.Drawing.Size(24, 13);
            this.lblWeaponAPLabel.TabIndex = 60;
            this.lblWeaponAPLabel.Tag = "Label_AP";
            this.lblWeaponAPLabel.Text = "AP:";
            // 
            // lblWeaponAP
            // 
            this.lblWeaponAP.AutoSize = true;
            this.lblWeaponAP.Location = new System.Drawing.Point(487, 60);
            this.lblWeaponAP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAP.Name = "lblWeaponAP";
            this.lblWeaponAP.Size = new System.Drawing.Size(27, 13);
            this.lblWeaponAP.TabIndex = 61;
            this.lblWeaponAP.Text = "[AP]";
            // 
            // lblWeaponAccuracyLabel
            // 
            this.lblWeaponAccuracyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAccuracyLabel.AutoSize = true;
            this.lblWeaponAccuracyLabel.Location = new System.Drawing.Point(306, 160);
            this.lblWeaponAccuracyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAccuracyLabel.Name = "lblWeaponAccuracyLabel";
            this.lblWeaponAccuracyLabel.Size = new System.Drawing.Size(55, 13);
            this.lblWeaponAccuracyLabel.TabIndex = 115;
            this.lblWeaponAccuracyLabel.Tag = "Label_Accuracy";
            this.lblWeaponAccuracyLabel.Text = "Accuracy:";
            // 
            // lblWeaponAccuracy
            // 
            this.lblWeaponAccuracy.AutoSize = true;
            this.lblWeaponAccuracy.Location = new System.Drawing.Point(367, 160);
            this.lblWeaponAccuracy.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAccuracy.Name = "lblWeaponAccuracy";
            this.lblWeaponAccuracy.Size = new System.Drawing.Size(58, 13);
            this.lblWeaponAccuracy.TabIndex = 116;
            this.lblWeaponAccuracy.Text = "[Accuracy]";
            // 
            // lblWeaponSlotsLabel
            // 
            this.lblWeaponSlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponSlotsLabel.AutoSize = true;
            this.lblWeaponSlotsLabel.Location = new System.Drawing.Point(304, 135);
            this.lblWeaponSlotsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSlotsLabel.Name = "lblWeaponSlotsLabel";
            this.lblWeaponSlotsLabel.Size = new System.Drawing.Size(57, 13);
            this.lblWeaponSlotsLabel.TabIndex = 70;
            this.lblWeaponSlotsLabel.Tag = "Label_ModSlots";
            this.lblWeaponSlotsLabel.Text = "Mod Slots:";
            // 
            // lblWeaponSlots
            // 
            this.lblWeaponSlots.AutoSize = true;
            this.lblWeaponSlots.Location = new System.Drawing.Point(367, 135);
            this.lblWeaponSlots.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSlots.Name = "lblWeaponSlots";
            this.lblWeaponSlots.Size = new System.Drawing.Size(36, 13);
            this.lblWeaponSlots.TabIndex = 71;
            this.lblWeaponSlots.Text = "[Slots]";
            // 
            // lblWeaponConceal
            // 
            this.lblWeaponConceal.AutoSize = true;
            this.lblWeaponConceal.Location = new System.Drawing.Point(487, 135);
            this.lblWeaponConceal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponConceal.Name = "lblWeaponConceal";
            this.lblWeaponConceal.Size = new System.Drawing.Size(52, 13);
            this.lblWeaponConceal.TabIndex = 100;
            this.lblWeaponConceal.Text = "[Conceal]";
            // 
            // lblWeaponSourceLabel
            // 
            this.lblWeaponSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponSourceLabel.AutoSize = true;
            this.lblWeaponSourceLabel.Location = new System.Drawing.Point(317, 185);
            this.lblWeaponSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSourceLabel.Name = "lblWeaponSourceLabel";
            this.lblWeaponSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblWeaponSourceLabel.TabIndex = 68;
            this.lblWeaponSourceLabel.Tag = "Label_Source";
            this.lblWeaponSourceLabel.Text = "Source:";
            // 
            // lblWeaponConcealLabel
            // 
            this.lblWeaponConcealLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponConcealLabel.AutoSize = true;
            this.lblWeaponConcealLabel.Location = new System.Drawing.Point(432, 135);
            this.lblWeaponConcealLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponConcealLabel.Name = "lblWeaponConcealLabel";
            this.lblWeaponConcealLabel.Size = new System.Drawing.Size(49, 13);
            this.lblWeaponConcealLabel.TabIndex = 99;
            this.lblWeaponConcealLabel.Tag = "Label_Conceal";
            this.lblWeaponConcealLabel.Text = "Conceal:";
            // 
            // lblWeaponSource
            // 
            this.lblWeaponSource.AutoSize = true;
            this.lblWeaponSource.Location = new System.Drawing.Point(367, 185);
            this.lblWeaponSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSource.Name = "lblWeaponSource";
            this.lblWeaponSource.Size = new System.Drawing.Size(47, 13);
            this.lblWeaponSource.TabIndex = 69;
            this.lblWeaponSource.Text = "[Source]";
            this.lblWeaponSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblWeaponAvailLabel
            // 
            this.lblWeaponAvailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAvailLabel.AutoSize = true;
            this.lblWeaponAvailLabel.Location = new System.Drawing.Point(448, 85);
            this.lblWeaponAvailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAvailLabel.Name = "lblWeaponAvailLabel";
            this.lblWeaponAvailLabel.Size = new System.Drawing.Size(33, 13);
            this.lblWeaponAvailLabel.TabIndex = 56;
            this.lblWeaponAvailLabel.Tag = "Label_Avail";
            this.lblWeaponAvailLabel.Text = "Avail:";
            // 
            // lblWeaponAvail
            // 
            this.lblWeaponAvail.AutoSize = true;
            this.lblWeaponAvail.Location = new System.Drawing.Point(487, 85);
            this.lblWeaponAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAvail.Name = "lblWeaponAvail";
            this.lblWeaponAvail.Size = new System.Drawing.Size(36, 13);
            this.lblWeaponAvail.TabIndex = 57;
            this.lblWeaponAvail.Text = "[Avail]";
            // 
            // lblWeaponCostLabel
            // 
            this.lblWeaponCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponCostLabel.AutoSize = true;
            this.lblWeaponCostLabel.Location = new System.Drawing.Point(450, 110);
            this.lblWeaponCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCostLabel.Name = "lblWeaponCostLabel";
            this.lblWeaponCostLabel.Size = new System.Drawing.Size(31, 13);
            this.lblWeaponCostLabel.TabIndex = 58;
            this.lblWeaponCostLabel.Tag = "Label_Cost";
            this.lblWeaponCostLabel.Text = "Cost:";
            // 
            // lblWeaponCost
            // 
            this.lblWeaponCost.AutoSize = true;
            this.lblWeaponCost.Location = new System.Drawing.Point(487, 110);
            this.lblWeaponCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponCost.Name = "lblWeaponCost";
            this.lblWeaponCost.Size = new System.Drawing.Size(34, 13);
            this.lblWeaponCost.TabIndex = 59;
            this.lblWeaponCost.Text = "[Cost]";
            // 
            // lblWeaponReachLabel
            // 
            this.lblWeaponReachLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponReachLabel.AutoSize = true;
            this.lblWeaponReachLabel.Location = new System.Drawing.Point(564, 85);
            this.lblWeaponReachLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponReachLabel.Name = "lblWeaponReachLabel";
            this.lblWeaponReachLabel.Size = new System.Drawing.Size(42, 13);
            this.lblWeaponReachLabel.TabIndex = 62;
            this.lblWeaponReachLabel.Tag = "Label_Reach";
            this.lblWeaponReachLabel.Text = "Reach:";
            // 
            // lblWeaponReach
            // 
            this.lblWeaponReach.AutoSize = true;
            this.lblWeaponReach.Location = new System.Drawing.Point(612, 85);
            this.lblWeaponReach.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponReach.Name = "lblWeaponReach";
            this.lblWeaponReach.Size = new System.Drawing.Size(45, 13);
            this.lblWeaponReach.TabIndex = 63;
            this.lblWeaponReach.Text = "[Reach]";
            // 
            // lblWeaponAmmoLabel
            // 
            this.lblWeaponAmmoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAmmoLabel.AutoSize = true;
            this.lblWeaponAmmoLabel.Location = new System.Drawing.Point(567, 110);
            this.lblWeaponAmmoLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAmmoLabel.Name = "lblWeaponAmmoLabel";
            this.lblWeaponAmmoLabel.Size = new System.Drawing.Size(39, 13);
            this.lblWeaponAmmoLabel.TabIndex = 66;
            this.lblWeaponAmmoLabel.Tag = "Label_Ammo";
            this.lblWeaponAmmoLabel.Text = "Ammo:";
            // 
            // lblWeaponAmmo
            // 
            this.lblWeaponAmmo.AutoSize = true;
            this.lblWeaponAmmo.Location = new System.Drawing.Point(612, 110);
            this.lblWeaponAmmo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAmmo.Name = "lblWeaponAmmo";
            this.lblWeaponAmmo.Size = new System.Drawing.Size(42, 13);
            this.lblWeaponAmmo.TabIndex = 67;
            this.lblWeaponAmmo.Text = "[Ammo]";
            // 
            // lblWeaponModeLabel
            // 
            this.lblWeaponModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponModeLabel.AutoSize = true;
            this.lblWeaponModeLabel.Location = new System.Drawing.Point(569, 135);
            this.lblWeaponModeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponModeLabel.Name = "lblWeaponModeLabel";
            this.lblWeaponModeLabel.Size = new System.Drawing.Size(37, 13);
            this.lblWeaponModeLabel.TabIndex = 64;
            this.lblWeaponModeLabel.Tag = "Label_Mode";
            this.lblWeaponModeLabel.Text = "Mode:";
            // 
            // chkIncludedInWeapon
            // 
            this.chkIncludedInWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludedInWeapon.AutoSize = true;
            this.tlpWeapons.SetColumnSpan(this.chkIncludedInWeapon, 2);
            this.chkIncludedInWeapon.Enabled = false;
            this.chkIncludedInWeapon.Location = new System.Drawing.Point(431, 183);
            this.chkIncludedInWeapon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIncludedInWeapon.Name = "chkIncludedInWeapon";
            this.chkIncludedInWeapon.Size = new System.Drawing.Size(127, 17);
            this.chkIncludedInWeapon.TabIndex = 73;
            this.chkIncludedInWeapon.Tag = "Checkbox_BaseWeapon";
            this.chkIncludedInWeapon.Text = "Part of base Weapon";
            this.chkIncludedInWeapon.UseVisualStyleBackColor = true;
            this.chkIncludedInWeapon.CheckedChanged += new System.EventHandler(this.chkIncludedInWeapon_CheckedChanged);
            // 
            // lblWeaponMode
            // 
            this.lblWeaponMode.AutoSize = true;
            this.lblWeaponMode.Location = new System.Drawing.Point(612, 135);
            this.lblWeaponMode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponMode.Name = "lblWeaponMode";
            this.lblWeaponMode.Size = new System.Drawing.Size(40, 13);
            this.lblWeaponMode.TabIndex = 65;
            this.lblWeaponMode.Text = "[Mode]";
            // 
            // lblWeaponRCLabel
            // 
            this.lblWeaponRCLabel.AutoSize = true;
            this.lblWeaponRCLabel.Location = new System.Drawing.Point(431, 160);
            this.lblWeaponRCLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRCLabel.Name = "lblWeaponRCLabel";
            this.lblWeaponRCLabel.Size = new System.Drawing.Size(25, 13);
            this.lblWeaponRCLabel.TabIndex = 53;
            this.lblWeaponRCLabel.Tag = "Label_RC";
            this.lblWeaponRCLabel.Text = "RC:";
            // 
            // lblWeaponRC
            // 
            this.lblWeaponRC.AutoSize = true;
            this.lblWeaponRC.Location = new System.Drawing.Point(487, 160);
            this.lblWeaponRC.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRC.Name = "lblWeaponRC";
            this.lblWeaponRC.Size = new System.Drawing.Size(28, 13);
            this.lblWeaponRC.TabIndex = 54;
            this.lblWeaponRC.Text = "[RC]";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tlpWeapons.SetColumnSpan(this.tableLayoutPanel4, 6);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponAlternateRangeExtreme, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeAlternate, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponAlternateRangeLong, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponAlternateRangeMedium, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeMain, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponAlternateRangeShort, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponDicePoolLabel, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponDicePool, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeShortLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeShort, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeMediumLabel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeLongLabel, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeExtremeLabel, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeMedium, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeLong, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblWeaponRangeExtreme, 4, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(301, 204);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 100);
            this.tableLayoutPanel4.TabIndex = 225;
            // 
            // lblWeaponAlternateRangeExtreme
            // 
            this.lblWeaponAlternateRangeExtreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAlternateRangeExtreme.AutoSize = true;
            this.lblWeaponAlternateRangeExtreme.Location = new System.Drawing.Point(411, 56);
            this.lblWeaponAlternateRangeExtreme.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAlternateRangeExtreme.Name = "lblWeaponAlternateRangeExtreme";
            this.lblWeaponAlternateRangeExtreme.Size = new System.Drawing.Size(100, 13);
            this.lblWeaponAlternateRangeExtreme.TabIndex = 220;
            this.lblWeaponAlternateRangeExtreme.Text = "[0]";
            this.lblWeaponAlternateRangeExtreme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeAlternate
            // 
            this.lblWeaponRangeAlternate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeAlternate.AutoSize = true;
            this.lblWeaponRangeAlternate.Location = new System.Drawing.Point(3, 56);
            this.lblWeaponRangeAlternate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeAlternate.Name = "lblWeaponRangeAlternate";
            this.lblWeaponRangeAlternate.Size = new System.Drawing.Size(90, 13);
            this.lblWeaponRangeAlternate.TabIndex = 222;
            this.lblWeaponRangeAlternate.Tag = "";
            this.lblWeaponRangeAlternate.Text = "[Alternate Range]";
            // 
            // lblWeaponAlternateRangeLong
            // 
            this.lblWeaponAlternateRangeLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAlternateRangeLong.AutoSize = true;
            this.lblWeaponAlternateRangeLong.Location = new System.Drawing.Point(307, 56);
            this.lblWeaponAlternateRangeLong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAlternateRangeLong.Name = "lblWeaponAlternateRangeLong";
            this.lblWeaponAlternateRangeLong.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponAlternateRangeLong.TabIndex = 219;
            this.lblWeaponAlternateRangeLong.Text = "[0]";
            this.lblWeaponAlternateRangeLong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeLabel
            // 
            this.lblWeaponRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeLabel.AutoSize = true;
            this.lblWeaponRangeLabel.Location = new System.Drawing.Point(3, 6);
            this.lblWeaponRangeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeLabel.Name = "lblWeaponRangeLabel";
            this.lblWeaponRangeLabel.Size = new System.Drawing.Size(90, 13);
            this.lblWeaponRangeLabel.TabIndex = 90;
            this.lblWeaponRangeLabel.Tag = "Label_RangeHeading";
            this.lblWeaponRangeLabel.Text = "Range";
            this.lblWeaponRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponAlternateRangeMedium
            // 
            this.lblWeaponAlternateRangeMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAlternateRangeMedium.AutoSize = true;
            this.lblWeaponAlternateRangeMedium.Location = new System.Drawing.Point(203, 56);
            this.lblWeaponAlternateRangeMedium.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAlternateRangeMedium.Name = "lblWeaponAlternateRangeMedium";
            this.lblWeaponAlternateRangeMedium.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponAlternateRangeMedium.TabIndex = 218;
            this.lblWeaponAlternateRangeMedium.Text = "[0]";
            this.lblWeaponAlternateRangeMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeMain
            // 
            this.lblWeaponRangeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeMain.AutoSize = true;
            this.lblWeaponRangeMain.Location = new System.Drawing.Point(22, 31);
            this.lblWeaponRangeMain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeMain.Name = "lblWeaponRangeMain";
            this.lblWeaponRangeMain.Size = new System.Drawing.Size(71, 13);
            this.lblWeaponRangeMain.TabIndex = 221;
            this.lblWeaponRangeMain.Tag = "";
            this.lblWeaponRangeMain.Text = "[Main Range]";
            // 
            // lblWeaponAlternateRangeShort
            // 
            this.lblWeaponAlternateRangeShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponAlternateRangeShort.Location = new System.Drawing.Point(99, 56);
            this.lblWeaponAlternateRangeShort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAlternateRangeShort.Name = "lblWeaponAlternateRangeShort";
            this.lblWeaponAlternateRangeShort.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponAlternateRangeShort.TabIndex = 217;
            this.lblWeaponAlternateRangeShort.Text = "[0]";
            this.lblWeaponAlternateRangeShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponDicePoolLabel
            // 
            this.lblWeaponDicePoolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponDicePoolLabel.AutoSize = true;
            this.lblWeaponDicePoolLabel.Location = new System.Drawing.Point(37, 81);
            this.lblWeaponDicePoolLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDicePoolLabel.Name = "lblWeaponDicePoolLabel";
            this.lblWeaponDicePoolLabel.Size = new System.Drawing.Size(56, 13);
            this.lblWeaponDicePoolLabel.TabIndex = 106;
            this.lblWeaponDicePoolLabel.Tag = "Label_DicePool";
            this.lblWeaponDicePoolLabel.Text = "Dice Pool:";
            // 
            // lblWeaponDicePool
            // 
            this.lblWeaponDicePool.AutoSize = true;
            this.lblWeaponDicePool.Location = new System.Drawing.Point(99, 81);
            this.lblWeaponDicePool.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDicePool.Name = "lblWeaponDicePool";
            this.lblWeaponDicePool.Size = new System.Drawing.Size(34, 13);
            this.lblWeaponDicePool.TabIndex = 107;
            this.lblWeaponDicePool.Text = "[Pool]";
            // 
            // lblWeaponRangeShortLabel
            // 
            this.lblWeaponRangeShortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeShortLabel.AutoSize = true;
            this.lblWeaponRangeShortLabel.Location = new System.Drawing.Point(99, 6);
            this.lblWeaponRangeShortLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeShortLabel.Name = "lblWeaponRangeShortLabel";
            this.lblWeaponRangeShortLabel.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeShortLabel.TabIndex = 91;
            this.lblWeaponRangeShortLabel.Tag = "Label_RangeShort";
            this.lblWeaponRangeShortLabel.Text = "Short (-0)";
            this.lblWeaponRangeShortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeShort
            // 
            this.lblWeaponRangeShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeShort.AutoSize = true;
            this.lblWeaponRangeShort.Location = new System.Drawing.Point(99, 31);
            this.lblWeaponRangeShort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeShort.Name = "lblWeaponRangeShort";
            this.lblWeaponRangeShort.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeShort.TabIndex = 95;
            this.lblWeaponRangeShort.Text = "[0]";
            this.lblWeaponRangeShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeMediumLabel
            // 
            this.lblWeaponRangeMediumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeMediumLabel.AutoSize = true;
            this.lblWeaponRangeMediumLabel.Location = new System.Drawing.Point(203, 6);
            this.lblWeaponRangeMediumLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeMediumLabel.Name = "lblWeaponRangeMediumLabel";
            this.lblWeaponRangeMediumLabel.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeMediumLabel.TabIndex = 92;
            this.lblWeaponRangeMediumLabel.Tag = "Label_RangeMedium";
            this.lblWeaponRangeMediumLabel.Text = "Medium (-1)";
            this.lblWeaponRangeMediumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeLongLabel
            // 
            this.lblWeaponRangeLongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeLongLabel.AutoSize = true;
            this.lblWeaponRangeLongLabel.Location = new System.Drawing.Point(307, 6);
            this.lblWeaponRangeLongLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeLongLabel.Name = "lblWeaponRangeLongLabel";
            this.lblWeaponRangeLongLabel.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeLongLabel.TabIndex = 93;
            this.lblWeaponRangeLongLabel.Tag = "Label_RangeLong";
            this.lblWeaponRangeLongLabel.Text = "Long (-3)";
            this.lblWeaponRangeLongLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeExtremeLabel
            // 
            this.lblWeaponRangeExtremeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeExtremeLabel.AutoSize = true;
            this.lblWeaponRangeExtremeLabel.Location = new System.Drawing.Point(411, 6);
            this.lblWeaponRangeExtremeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeExtremeLabel.Name = "lblWeaponRangeExtremeLabel";
            this.lblWeaponRangeExtremeLabel.Size = new System.Drawing.Size(100, 13);
            this.lblWeaponRangeExtremeLabel.TabIndex = 94;
            this.lblWeaponRangeExtremeLabel.Tag = "Label_RangeExtreme";
            this.lblWeaponRangeExtremeLabel.Text = "Extreme (-6)";
            this.lblWeaponRangeExtremeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeMedium
            // 
            this.lblWeaponRangeMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeMedium.AutoSize = true;
            this.lblWeaponRangeMedium.Location = new System.Drawing.Point(203, 31);
            this.lblWeaponRangeMedium.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeMedium.Name = "lblWeaponRangeMedium";
            this.lblWeaponRangeMedium.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeMedium.TabIndex = 96;
            this.lblWeaponRangeMedium.Text = "[0]";
            this.lblWeaponRangeMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeLong
            // 
            this.lblWeaponRangeLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeLong.AutoSize = true;
            this.lblWeaponRangeLong.Location = new System.Drawing.Point(307, 31);
            this.lblWeaponRangeLong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeLong.Name = "lblWeaponRangeLong";
            this.lblWeaponRangeLong.Size = new System.Drawing.Size(98, 13);
            this.lblWeaponRangeLong.TabIndex = 97;
            this.lblWeaponRangeLong.Text = "[0]";
            this.lblWeaponRangeLong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWeaponRangeExtreme
            // 
            this.lblWeaponRangeExtreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeaponRangeExtreme.AutoSize = true;
            this.lblWeaponRangeExtreme.Location = new System.Drawing.Point(411, 31);
            this.lblWeaponRangeExtreme.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponRangeExtreme.Name = "lblWeaponRangeExtreme";
            this.lblWeaponRangeExtreme.Size = new System.Drawing.Size(100, 13);
            this.lblWeaponRangeExtreme.TabIndex = 98;
            this.lblWeaponRangeExtreme.Text = "[0]";
            this.lblWeaponRangeExtreme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tlpWeapons.SetColumnSpan(this.tableLayoutPanel5, 6);
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponFirewall, 5, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponDataProcessing, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponFirewallLabel, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponSleaze, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponAttack, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponAttackLabel, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponDataProcessingLabel, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponSleazeLabel, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponDeviceRatingLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblWeaponDeviceRating, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(301, 304);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(514, 50);
            this.tableLayoutPanel5.TabIndex = 226;
            // 
            // lblWeaponFirewall
            // 
            this.lblWeaponFirewall.AutoSize = true;
            this.lblWeaponFirewall.Location = new System.Drawing.Point(408, 31);
            this.lblWeaponFirewall.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponFirewall.Name = "lblWeaponFirewall";
            this.lblWeaponFirewall.Size = new System.Drawing.Size(19, 13);
            this.lblWeaponFirewall.TabIndex = 165;
            this.lblWeaponFirewall.Text = "[0]";
            // 
            // lblWeaponDataProcessing
            // 
            this.lblWeaponDataProcessing.AutoSize = true;
            this.lblWeaponDataProcessing.Location = new System.Drawing.Point(301, 31);
            this.lblWeaponDataProcessing.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDataProcessing.Name = "lblWeaponDataProcessing";
            this.lblWeaponDataProcessing.Size = new System.Drawing.Size(19, 13);
            this.lblWeaponDataProcessing.TabIndex = 163;
            this.lblWeaponDataProcessing.Text = "[0]";
            // 
            // lblWeaponFirewallLabel
            // 
            this.lblWeaponFirewallLabel.AutoSize = true;
            this.lblWeaponFirewallLabel.Location = new System.Drawing.Point(408, 6);
            this.lblWeaponFirewallLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponFirewallLabel.Name = "lblWeaponFirewallLabel";
            this.lblWeaponFirewallLabel.Size = new System.Drawing.Size(45, 13);
            this.lblWeaponFirewallLabel.TabIndex = 164;
            this.lblWeaponFirewallLabel.Tag = "Label_Firewall";
            this.lblWeaponFirewallLabel.Text = "Firewall:";
            // 
            // lblWeaponSleaze
            // 
            this.lblWeaponSleaze.AutoSize = true;
            this.lblWeaponSleaze.Location = new System.Drawing.Point(194, 31);
            this.lblWeaponSleaze.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSleaze.Name = "lblWeaponSleaze";
            this.lblWeaponSleaze.Size = new System.Drawing.Size(19, 13);
            this.lblWeaponSleaze.TabIndex = 161;
            this.lblWeaponSleaze.Text = "[0]";
            // 
            // lblWeaponAttack
            // 
            this.lblWeaponAttack.AutoSize = true;
            this.lblWeaponAttack.Location = new System.Drawing.Point(87, 31);
            this.lblWeaponAttack.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAttack.Name = "lblWeaponAttack";
            this.lblWeaponAttack.Size = new System.Drawing.Size(19, 13);
            this.lblWeaponAttack.TabIndex = 159;
            this.lblWeaponAttack.Text = "[0]";
            // 
            // lblWeaponAttackLabel
            // 
            this.lblWeaponAttackLabel.AutoSize = true;
            this.lblWeaponAttackLabel.Location = new System.Drawing.Point(87, 6);
            this.lblWeaponAttackLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponAttackLabel.Name = "lblWeaponAttackLabel";
            this.lblWeaponAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.lblWeaponAttackLabel.TabIndex = 158;
            this.lblWeaponAttackLabel.Tag = "Label_Attack";
            this.lblWeaponAttackLabel.Text = "Attack:";
            // 
            // lblWeaponDataProcessingLabel
            // 
            this.lblWeaponDataProcessingLabel.AutoSize = true;
            this.lblWeaponDataProcessingLabel.Location = new System.Drawing.Point(301, 6);
            this.lblWeaponDataProcessingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDataProcessingLabel.Name = "lblWeaponDataProcessingLabel";
            this.lblWeaponDataProcessingLabel.Size = new System.Drawing.Size(88, 13);
            this.lblWeaponDataProcessingLabel.TabIndex = 162;
            this.lblWeaponDataProcessingLabel.Tag = "Label_DataProcessing";
            this.lblWeaponDataProcessingLabel.Text = "Data Processing:";
            // 
            // lblWeaponSleazeLabel
            // 
            this.lblWeaponSleazeLabel.AutoSize = true;
            this.lblWeaponSleazeLabel.Location = new System.Drawing.Point(194, 6);
            this.lblWeaponSleazeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponSleazeLabel.Name = "lblWeaponSleazeLabel";
            this.lblWeaponSleazeLabel.Size = new System.Drawing.Size(42, 13);
            this.lblWeaponSleazeLabel.TabIndex = 160;
            this.lblWeaponSleazeLabel.Tag = "Label_Sleaze";
            this.lblWeaponSleazeLabel.Text = "Sleaze:";
            // 
            // lblWeaponDeviceRatingLabel
            // 
            this.lblWeaponDeviceRatingLabel.AutoSize = true;
            this.lblWeaponDeviceRatingLabel.Location = new System.Drawing.Point(3, 6);
            this.lblWeaponDeviceRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDeviceRatingLabel.Name = "lblWeaponDeviceRatingLabel";
            this.lblWeaponDeviceRatingLabel.Size = new System.Drawing.Size(78, 13);
            this.lblWeaponDeviceRatingLabel.TabIndex = 156;
            this.lblWeaponDeviceRatingLabel.Tag = "Label_DeviceRating";
            this.lblWeaponDeviceRatingLabel.Text = "Device Rating:";
            // 
            // lblWeaponDeviceRating
            // 
            this.lblWeaponDeviceRating.AutoSize = true;
            this.lblWeaponDeviceRating.Location = new System.Drawing.Point(3, 31);
            this.lblWeaponDeviceRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeaponDeviceRating.Name = "lblWeaponDeviceRating";
            this.lblWeaponDeviceRating.Size = new System.Drawing.Size(19, 13);
            this.lblWeaponDeviceRating.TabIndex = 157;
            this.lblWeaponDeviceRating.Text = "[0]";
            // 
            // tabDrugs
            // 
            this.tabDrugs.BackColor = System.Drawing.SystemColors.Control;
            this.tabDrugs.Controls.Add(this.tblDrugInfo);
            this.tabDrugs.Location = new System.Drawing.Point(4, 22);
            this.tabDrugs.Name = "tabDrugs";
            this.tabDrugs.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrugs.Size = new System.Drawing.Size(184, 48);
            this.tabDrugs.TabIndex = 6;
            this.tabDrugs.Tag = "Tab_Drugs";
            this.tabDrugs.Text = "Drugs";
            // 
            // tblDrugInfo
            // 
            this.tblDrugInfo.ColumnCount = 4;
            this.tblDrugInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tblDrugInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDrugInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblDrugInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDrugInfo.Controls.Add(this.lblDrugNameLabel, 1, 1);
            this.tblDrugInfo.Controls.Add(this.treCustomDrugs, 0, 1);
            this.tblDrugInfo.Controls.Add(this.lblDrugComponents, 2, 9);
            this.tblDrugInfo.Controls.Add(this.lblDrugComponentsLabel, 1, 9);
            this.tblDrugInfo.Controls.Add(this.lblDrugAddictionThresholdLabel, 1, 7);
            this.tblDrugInfo.Controls.Add(this.lblDrugAddictionRating, 2, 8);
            this.tblDrugInfo.Controls.Add(this.lblDrugAddictionRatingLabel, 1, 8);
            this.tblDrugInfo.Controls.Add(this.lblDrugGrade, 2, 4);
            this.tblDrugInfo.Controls.Add(this.lblDrugQtyLabel, 1, 3);
            this.tblDrugInfo.Controls.Add(this.lblDrugAddictionThreshold, 2, 7);
            this.tblDrugInfo.Controls.Add(this.lblDrugGradeLabel, 1, 4);
            this.tblDrugInfo.Controls.Add(this.nudDrugQty, 2, 3);
            this.tblDrugInfo.Controls.Add(this.lblDrugName, 2, 1);
            this.tblDrugInfo.Controls.Add(this.lblDrugCategoryLabel, 1, 2);
            this.tblDrugInfo.Controls.Add(this.lblDrugCostLabel, 1, 6);
            this.tblDrugInfo.Controls.Add(this.lblDrugCost, 2, 6);
            this.tblDrugInfo.Controls.Add(this.lblDrugCategory, 2, 2);
            this.tblDrugInfo.Controls.Add(this.lblDrugAvailabel, 1, 5);
            this.tblDrugInfo.Controls.Add(this.lblDrugAvail, 2, 5);
            this.tblDrugInfo.Controls.Add(this.lblDrugEffectLabel, 1, 10);
            this.tblDrugInfo.Controls.Add(this.lblDrugEffect, 2, 10);
            this.tblDrugInfo.Controls.Add(this.flowLayoutPanel12, 0, 0);
            this.tblDrugInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDrugInfo.Location = new System.Drawing.Point(3, 3);
            this.tblDrugInfo.MinimumSize = new System.Drawing.Size(815, 587);
            this.tblDrugInfo.Name = "tblDrugInfo";
            this.tblDrugInfo.RowCount = 11;
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDrugInfo.Size = new System.Drawing.Size(815, 587);
            this.tblDrugInfo.TabIndex = 97;
            // 
            // lblDrugNameLabel
            // 
            this.lblDrugNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugNameLabel.AutoSize = true;
            this.lblDrugNameLabel.Location = new System.Drawing.Point(335, 35);
            this.lblDrugNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugNameLabel.Name = "lblDrugNameLabel";
            this.lblDrugNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblDrugNameLabel.TabIndex = 73;
            this.lblDrugNameLabel.Tag = "Label_Name";
            this.lblDrugNameLabel.Text = "Name:";
            // 
            // treCustomDrugs
            // 
            this.treCustomDrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treCustomDrugs.Location = new System.Drawing.Point(3, 32);
            this.treCustomDrugs.Name = "treCustomDrugs";
            treeNode23.Name = "treeNode24";
            treeNode23.Tag = "Node_SelectedDrugs";
            treeNode23.Text = "Selected Drugs";
            this.treCustomDrugs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23});
            this.tblDrugInfo.SetRowSpan(this.treCustomDrugs, 10);
            this.treCustomDrugs.Size = new System.Drawing.Size(295, 564);
            this.treCustomDrugs.TabIndex = 2;
            this.treCustomDrugs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treCustomDrugs_AfterSelect);
            // 
            // lblDrugComponents
            // 
            this.lblDrugComponents.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugComponents, 2);
            this.lblDrugComponents.Location = new System.Drawing.Point(379, 236);
            this.lblDrugComponents.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugComponents.Name = "lblDrugComponents";
            this.lblDrugComponents.Size = new System.Drawing.Size(72, 13);
            this.lblDrugComponents.TabIndex = 84;
            this.lblDrugComponents.Text = "[Components]";
            // 
            // lblDrugComponentsLabel
            // 
            this.lblDrugComponentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugComponentsLabel.AutoSize = true;
            this.lblDrugComponentsLabel.Location = new System.Drawing.Point(304, 236);
            this.lblDrugComponentsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugComponentsLabel.Name = "lblDrugComponentsLabel";
            this.lblDrugComponentsLabel.Size = new System.Drawing.Size(69, 13);
            this.lblDrugComponentsLabel.TabIndex = 91;
            this.lblDrugComponentsLabel.Tag = "Label_DrugComponents";
            this.lblDrugComponentsLabel.Text = "Components:";
            // 
            // lblDrugAddictionThresholdLabel
            // 
            this.lblDrugAddictionThresholdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugAddictionThresholdLabel.AutoSize = true;
            this.lblDrugAddictionThresholdLabel.Location = new System.Drawing.Point(316, 186);
            this.lblDrugAddictionThresholdLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAddictionThresholdLabel.Name = "lblDrugAddictionThresholdLabel";
            this.lblDrugAddictionThresholdLabel.Size = new System.Drawing.Size(57, 13);
            this.lblDrugAddictionThresholdLabel.TabIndex = 92;
            this.lblDrugAddictionThresholdLabel.Tag = "Label_AddictionThreshold";
            this.lblDrugAddictionThresholdLabel.Text = "Threshold:";
            // 
            // lblDrugAddictionRating
            // 
            this.lblDrugAddictionRating.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugAddictionRating, 2);
            this.lblDrugAddictionRating.Location = new System.Drawing.Point(379, 211);
            this.lblDrugAddictionRating.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAddictionRating.Name = "lblDrugAddictionRating";
            this.lblDrugAddictionRating.Size = new System.Drawing.Size(44, 13);
            this.lblDrugAddictionRating.TabIndex = 88;
            this.lblDrugAddictionRating.Text = "[Rating]";
            // 
            // lblDrugAddictionRatingLabel
            // 
            this.lblDrugAddictionRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugAddictionRatingLabel.AutoSize = true;
            this.lblDrugAddictionRatingLabel.Location = new System.Drawing.Point(332, 211);
            this.lblDrugAddictionRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAddictionRatingLabel.Name = "lblDrugAddictionRatingLabel";
            this.lblDrugAddictionRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblDrugAddictionRatingLabel.TabIndex = 90;
            this.lblDrugAddictionRatingLabel.Tag = "Label_Rating";
            this.lblDrugAddictionRatingLabel.Text = "Rating:";
            // 
            // lblDrugGrade
            // 
            this.lblDrugGrade.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugGrade, 2);
            this.lblDrugGrade.Location = new System.Drawing.Point(379, 111);
            this.lblDrugGrade.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugGrade.Name = "lblDrugGrade";
            this.lblDrugGrade.Size = new System.Drawing.Size(42, 13);
            this.lblDrugGrade.TabIndex = 94;
            this.lblDrugGrade.Text = "[Grade]";
            // 
            // lblDrugQtyLabel
            // 
            this.lblDrugQtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugQtyLabel.AutoSize = true;
            this.lblDrugQtyLabel.Location = new System.Drawing.Point(347, 85);
            this.lblDrugQtyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugQtyLabel.Name = "lblDrugQtyLabel";
            this.lblDrugQtyLabel.Size = new System.Drawing.Size(26, 13);
            this.lblDrugQtyLabel.TabIndex = 95;
            this.lblDrugQtyLabel.Tag = "Label_Qty";
            this.lblDrugQtyLabel.Text = "Qty:";
            // 
            // lblDrugAddictionThreshold
            // 
            this.lblDrugAddictionThreshold.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugAddictionThreshold, 2);
            this.lblDrugAddictionThreshold.Location = new System.Drawing.Point(379, 186);
            this.lblDrugAddictionThreshold.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAddictionThreshold.Name = "lblDrugAddictionThreshold";
            this.lblDrugAddictionThreshold.Size = new System.Drawing.Size(60, 13);
            this.lblDrugAddictionThreshold.TabIndex = 86;
            this.lblDrugAddictionThreshold.Text = "[Threshold]";
            // 
            // lblDrugGradeLabel
            // 
            this.lblDrugGradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugGradeLabel.AutoSize = true;
            this.lblDrugGradeLabel.Location = new System.Drawing.Point(334, 111);
            this.lblDrugGradeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugGradeLabel.Name = "lblDrugGradeLabel";
            this.lblDrugGradeLabel.Size = new System.Drawing.Size(39, 13);
            this.lblDrugGradeLabel.TabIndex = 93;
            this.lblDrugGradeLabel.Tag = "Label_Grade";
            this.lblDrugGradeLabel.Text = "Grade:";
            // 
            // nudDrugQty
            // 
            this.nudDrugQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDrugQty.Enabled = false;
            this.nudDrugQty.Location = new System.Drawing.Point(379, 82);
            this.nudDrugQty.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.nudDrugQty.Name = "nudDrugQty";
            this.nudDrugQty.Size = new System.Drawing.Size(94, 20);
            this.nudDrugQty.TabIndex = 96;
            this.nudDrugQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDrugQty.Visible = false;
            this.nudDrugQty.ValueChanged += new System.EventHandler(this.nudDrugQty_ValueChanged);
            // 
            // lblDrugName
            // 
            this.lblDrugName.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugName, 2);
            this.lblDrugName.Location = new System.Drawing.Point(379, 35);
            this.lblDrugName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugName.Name = "lblDrugName";
            this.lblDrugName.Size = new System.Drawing.Size(41, 13);
            this.lblDrugName.TabIndex = 74;
            this.lblDrugName.Text = "[Name]";
            // 
            // lblDrugCategoryLabel
            // 
            this.lblDrugCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugCategoryLabel.AutoSize = true;
            this.lblDrugCategoryLabel.Location = new System.Drawing.Point(321, 60);
            this.lblDrugCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugCategoryLabel.Name = "lblDrugCategoryLabel";
            this.lblDrugCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblDrugCategoryLabel.TabIndex = 75;
            this.lblDrugCategoryLabel.Tag = "Label_Category";
            this.lblDrugCategoryLabel.Text = "Category:";
            // 
            // lblDrugCostLabel
            // 
            this.lblDrugCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugCostLabel.AutoSize = true;
            this.lblDrugCostLabel.Location = new System.Drawing.Point(342, 161);
            this.lblDrugCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugCostLabel.Name = "lblDrugCostLabel";
            this.lblDrugCostLabel.Size = new System.Drawing.Size(31, 13);
            this.lblDrugCostLabel.TabIndex = 79;
            this.lblDrugCostLabel.Tag = "Label_Cost";
            this.lblDrugCostLabel.Text = "Cost:";
            // 
            // lblDrugCost
            // 
            this.lblDrugCost.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugCost, 2);
            this.lblDrugCost.Location = new System.Drawing.Point(379, 161);
            this.lblDrugCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugCost.Name = "lblDrugCost";
            this.lblDrugCost.Size = new System.Drawing.Size(34, 13);
            this.lblDrugCost.TabIndex = 80;
            this.lblDrugCost.Text = "[Cost]";
            // 
            // lblDrugCategory
            // 
            this.lblDrugCategory.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugCategory, 2);
            this.lblDrugCategory.Location = new System.Drawing.Point(379, 60);
            this.lblDrugCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugCategory.Name = "lblDrugCategory";
            this.lblDrugCategory.Size = new System.Drawing.Size(55, 13);
            this.lblDrugCategory.TabIndex = 76;
            this.lblDrugCategory.Text = "[Category]";
            // 
            // lblDrugAvailabel
            // 
            this.lblDrugAvailabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugAvailabel.AutoSize = true;
            this.lblDrugAvailabel.Location = new System.Drawing.Point(340, 136);
            this.lblDrugAvailabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAvailabel.Name = "lblDrugAvailabel";
            this.lblDrugAvailabel.Size = new System.Drawing.Size(33, 13);
            this.lblDrugAvailabel.TabIndex = 77;
            this.lblDrugAvailabel.Tag = "Label_Avail";
            this.lblDrugAvailabel.Text = "Avail:";
            // 
            // lblDrugAvail
            // 
            this.lblDrugAvail.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugAvail, 2);
            this.lblDrugAvail.Location = new System.Drawing.Point(379, 136);
            this.lblDrugAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugAvail.Name = "lblDrugAvail";
            this.lblDrugAvail.Size = new System.Drawing.Size(36, 13);
            this.lblDrugAvail.TabIndex = 78;
            this.lblDrugAvail.Text = "[Avail]";
            // 
            // lblDrugEffectLabel
            // 
            this.lblDrugEffectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrugEffectLabel.AutoSize = true;
            this.lblDrugEffectLabel.Location = new System.Drawing.Point(330, 261);
            this.lblDrugEffectLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugEffectLabel.Name = "lblDrugEffectLabel";
            this.lblDrugEffectLabel.Size = new System.Drawing.Size(43, 13);
            this.lblDrugEffectLabel.TabIndex = 97;
            this.lblDrugEffectLabel.Text = "Effects:";
            // 
            // lblDrugEffect
            // 
            this.lblDrugEffect.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.lblDrugEffect, 2);
            this.lblDrugEffect.Location = new System.Drawing.Point(379, 261);
            this.lblDrugEffect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrugEffect.Name = "lblDrugEffect";
            this.lblDrugEffect.Size = new System.Drawing.Size(19, 13);
            this.lblDrugEffect.TabIndex = 98;
            this.lblDrugEffect.Text = "[0]";
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.AutoSize = true;
            this.tblDrugInfo.SetColumnSpan(this.flowLayoutPanel12, 4);
            this.flowLayoutPanel12.Controls.Add(this.btnCreateCustomDrug);
            this.flowLayoutPanel12.Controls.Add(this.btnDeleteCustomDrug);
            this.flowLayoutPanel12.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(201, 29);
            this.flowLayoutPanel12.TabIndex = 99;
            // 
            // btnCreateCustomDrug
            // 
            this.btnCreateCustomDrug.Location = new System.Drawing.Point(3, 3);
            this.btnCreateCustomDrug.Name = "btnCreateCustomDrug";
            this.btnCreateCustomDrug.Size = new System.Drawing.Size(114, 23);
            this.btnCreateCustomDrug.TabIndex = 1;
            this.btnCreateCustomDrug.Tag = "Button_CreateCustomDrug";
            this.btnCreateCustomDrug.Text = "Create Custom Drug";
            this.btnCreateCustomDrug.UseVisualStyleBackColor = true;
            this.btnCreateCustomDrug.Click += new System.EventHandler(this.btnCreateCustomDrug_Click_1);
            // 
            // btnDeleteCustomDrug
            // 
            this.btnDeleteCustomDrug.Location = new System.Drawing.Point(123, 3);
            this.btnDeleteCustomDrug.Name = "btnDeleteCustomDrug";
            this.btnDeleteCustomDrug.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCustomDrug.TabIndex = 3;
            this.btnDeleteCustomDrug.Tag = "String_Delete";
            this.btnDeleteCustomDrug.Text = "Delete";
            this.btnDeleteCustomDrug.UseVisualStyleBackColor = true;
            // 
            // tabLifestyle
            // 
            this.tabLifestyle.BackColor = System.Drawing.SystemColors.Control;
            this.tabLifestyle.Controls.Add(this.tblLifestyleDetails);
            this.tabLifestyle.Location = new System.Drawing.Point(4, 22);
            this.tabLifestyle.Name = "tabLifestyle";
            this.tabLifestyle.Padding = new System.Windows.Forms.Padding(3);
            this.tabLifestyle.Size = new System.Drawing.Size(184, 48);
            this.tabLifestyle.TabIndex = 0;
            this.tabLifestyle.Tag = "Tab_Lifestyle";
            this.tabLifestyle.Text = "Lifestyle";
            // 
            // tblLifestyleDetails
            // 
            this.tblLifestyleDetails.AutoSize = true;
            this.tblLifestyleDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblLifestyleDetails.ColumnCount = 3;
            this.tblLifestyleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tblLifestyleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLifestyleDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleCostLabel, 1, 1);
            this.tblLifestyleDetails.Controls.Add(this.treLifestyles, 0, 1);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleCost, 2, 1);
            this.tblLifestyleDetails.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleQualitiesLabel, 1, 6);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleSourceLabel, 1, 3);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleStartingNuyen, 2, 5);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleStartingNuyenLabel, 1, 5);
            this.tblLifestyleDetails.Controls.Add(this.lblBaseLifestyle, 2, 4);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleSource, 2, 3);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleComfortsLabel, 1, 4);
            this.tblLifestyleDetails.Controls.Add(this.lblLifestyleQualities, 2, 6);
            this.tblLifestyleDetails.Controls.Add(this.flowLayoutPanel11, 0, 0);
            this.tblLifestyleDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLifestyleDetails.Location = new System.Drawing.Point(3, 3);
            this.tblLifestyleDetails.MinimumSize = new System.Drawing.Size(815, 587);
            this.tblLifestyleDetails.Name = "tblLifestyleDetails";
            this.tblLifestyleDetails.RowCount = 7;
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLifestyleDetails.Size = new System.Drawing.Size(815, 587);
            this.tblLifestyleDetails.TabIndex = 104;
            // 
            // lblLifestyleCostLabel
            // 
            this.lblLifestyleCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLifestyleCostLabel.AutoSize = true;
            this.lblLifestyleCostLabel.Location = new System.Drawing.Point(318, 35);
            this.lblLifestyleCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleCostLabel.Name = "lblLifestyleCostLabel";
            this.lblLifestyleCostLabel.Size = new System.Drawing.Size(66, 13);
            this.lblLifestyleCostLabel.TabIndex = 85;
            this.lblLifestyleCostLabel.Tag = "Label_SelectLifestyle_CostPerMonth";
            this.lblLifestyleCostLabel.Text = "Cost/Month:";
            // 
            // treLifestyles
            // 
            this.treLifestyles.AllowDrop = true;
            this.treLifestyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treLifestyles.HideSelection = false;
            this.treLifestyles.Location = new System.Drawing.Point(3, 32);
            this.treLifestyles.Name = "treLifestyles";
            treeNode24.Name = "nodLifestylesRoot";
            treeNode24.Tag = "Node_SelectedLifestyles";
            treeNode24.Text = "Selected Lifestyles";
            this.treLifestyles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24});
            this.tblLifestyleDetails.SetRowSpan(this.treLifestyles, 6);
            this.treLifestyles.ShowNodeToolTips = true;
            this.treLifestyles.ShowRootLines = false;
            this.treLifestyles.Size = new System.Drawing.Size(295, 564);
            this.treLifestyles.TabIndex = 80;
            this.treLifestyles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treLifestyles_AfterSelect);
            this.treLifestyles.DragOver += new System.Windows.Forms.DragEventHandler(this.treLifestyles_DragOver);
            this.treLifestyles.DoubleClick += new System.EventHandler(this.treLifestyles_DoubleClick);
            this.treLifestyles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treLifestyles_KeyDown);
            this.treLifestyles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblLifestyleCost
            // 
            this.lblLifestyleCost.AutoSize = true;
            this.lblLifestyleCost.Location = new System.Drawing.Point(390, 35);
            this.lblLifestyleCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleCost.MaximumSize = new System.Drawing.Size(427, 0);
            this.lblLifestyleCost.Name = "lblLifestyleCost";
            this.lblLifestyleCost.Size = new System.Drawing.Size(34, 13);
            this.lblLifestyleCost.TabIndex = 84;
            this.lblLifestyleCost.Text = "[Cost]";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tblLifestyleDetails.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.nudLifestyleMonths, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLifestyleMonthsLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLifestyleTotalCost, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(301, 54);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(514, 26);
            this.tableLayoutPanel2.TabIndex = 86;
            // 
            // nudLifestyleMonths
            // 
            this.nudLifestyleMonths.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudLifestyleMonths.Location = new System.Drawing.Point(3, 3);
            this.nudLifestyleMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLifestyleMonths.Name = "nudLifestyleMonths";
            this.nudLifestyleMonths.Size = new System.Drawing.Size(42, 20);
            this.nudLifestyleMonths.TabIndex = 82;
            this.nudLifestyleMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLifestyleMonths.Visible = false;
            this.nudLifestyleMonths.ValueChanged += new System.EventHandler(this.nudLifestyleMonths_ValueChanged);
            // 
            // lblLifestyleMonthsLabel
            // 
            this.lblLifestyleMonthsLabel.AutoSize = true;
            this.lblLifestyleMonthsLabel.Location = new System.Drawing.Point(51, 6);
            this.lblLifestyleMonthsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleMonthsLabel.Name = "lblLifestyleMonthsLabel";
            this.lblLifestyleMonthsLabel.Size = new System.Drawing.Size(174, 13);
            this.lblLifestyleMonthsLabel.TabIndex = 83;
            this.lblLifestyleMonthsLabel.Text = "[Intervals] ([Number] for Permanent)";
            this.lblLifestyleMonthsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLifestyleTotalCost
            // 
            this.lblLifestyleTotalCost.AutoSize = true;
            this.lblLifestyleTotalCost.Location = new System.Drawing.Point(231, 6);
            this.lblLifestyleTotalCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleTotalCost.Name = "lblLifestyleTotalCost";
            this.lblLifestyleTotalCost.Size = new System.Drawing.Size(34, 13);
            this.lblLifestyleTotalCost.TabIndex = 86;
            this.lblLifestyleTotalCost.Text = "[Cost]";
            this.lblLifestyleTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLifestyleQualitiesLabel
            // 
            this.lblLifestyleQualitiesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLifestyleQualitiesLabel.AutoSize = true;
            this.lblLifestyleQualitiesLabel.Location = new System.Drawing.Point(334, 161);
            this.lblLifestyleQualitiesLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleQualitiesLabel.Name = "lblLifestyleQualitiesLabel";
            this.lblLifestyleQualitiesLabel.Size = new System.Drawing.Size(50, 13);
            this.lblLifestyleQualitiesLabel.TabIndex = 102;
            this.lblLifestyleQualitiesLabel.Tag = "Label_LifestyleQualities";
            this.lblLifestyleQualitiesLabel.Text = "Qualities:";
            // 
            // lblLifestyleSourceLabel
            // 
            this.lblLifestyleSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLifestyleSourceLabel.AutoSize = true;
            this.lblLifestyleSourceLabel.Location = new System.Drawing.Point(340, 86);
            this.lblLifestyleSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleSourceLabel.Name = "lblLifestyleSourceLabel";
            this.lblLifestyleSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblLifestyleSourceLabel.TabIndex = 87;
            this.lblLifestyleSourceLabel.Tag = "Label_Source";
            this.lblLifestyleSourceLabel.Text = "Source:";
            // 
            // lblLifestyleStartingNuyen
            // 
            this.lblLifestyleStartingNuyen.AutoSize = true;
            this.lblLifestyleStartingNuyen.Location = new System.Drawing.Point(390, 136);
            this.lblLifestyleStartingNuyen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleStartingNuyen.MaximumSize = new System.Drawing.Size(427, 0);
            this.lblLifestyleStartingNuyen.Name = "lblLifestyleStartingNuyen";
            this.lblLifestyleStartingNuyen.Size = new System.Drawing.Size(83, 13);
            this.lblLifestyleStartingNuyen.TabIndex = 89;
            this.lblLifestyleStartingNuyen.Text = "[Starting Nuyen]";
            // 
            // lblLifestyleStartingNuyenLabel
            // 
            this.lblLifestyleStartingNuyenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLifestyleStartingNuyenLabel.AutoSize = true;
            this.lblLifestyleStartingNuyenLabel.Location = new System.Drawing.Point(304, 136);
            this.lblLifestyleStartingNuyenLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleStartingNuyenLabel.Name = "lblLifestyleStartingNuyenLabel";
            this.lblLifestyleStartingNuyenLabel.Size = new System.Drawing.Size(80, 13);
            this.lblLifestyleStartingNuyenLabel.TabIndex = 90;
            this.lblLifestyleStartingNuyenLabel.Tag = "Label_SelectLifestyle_StartingNuyen";
            this.lblLifestyleStartingNuyenLabel.Text = "Starting Nuyen:";
            // 
            // lblBaseLifestyle
            // 
            this.lblBaseLifestyle.AutoSize = true;
            this.lblBaseLifestyle.Location = new System.Drawing.Point(390, 111);
            this.lblBaseLifestyle.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBaseLifestyle.Name = "lblBaseLifestyle";
            this.lblBaseLifestyle.Size = new System.Drawing.Size(19, 13);
            this.lblBaseLifestyle.TabIndex = 93;
            this.lblBaseLifestyle.Text = "[0]";
            // 
            // lblLifestyleSource
            // 
            this.lblLifestyleSource.AutoSize = true;
            this.lblLifestyleSource.Location = new System.Drawing.Point(390, 86);
            this.lblLifestyleSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleSource.Name = "lblLifestyleSource";
            this.lblLifestyleSource.Size = new System.Drawing.Size(47, 13);
            this.lblLifestyleSource.TabIndex = 88;
            this.lblLifestyleSource.Text = "[Source]";
            this.lblLifestyleSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // lblLifestyleComfortsLabel
            // 
            this.lblLifestyleComfortsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLifestyleComfortsLabel.AutoSize = true;
            this.lblLifestyleComfortsLabel.Location = new System.Drawing.Point(336, 111);
            this.lblLifestyleComfortsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleComfortsLabel.Name = "lblLifestyleComfortsLabel";
            this.lblLifestyleComfortsLabel.Size = new System.Drawing.Size(48, 13);
            this.lblLifestyleComfortsLabel.TabIndex = 92;
            this.lblLifestyleComfortsLabel.Tag = "Label_SelectAdvancedLifestyle_Lifestyle";
            this.lblLifestyleComfortsLabel.Text = "Lifestyle:";
            // 
            // lblLifestyleQualities
            // 
            this.lblLifestyleQualities.AutoSize = true;
            this.lblLifestyleQualities.Location = new System.Drawing.Point(390, 161);
            this.lblLifestyleQualities.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLifestyleQualities.MaximumSize = new System.Drawing.Size(427, 0);
            this.lblLifestyleQualities.Name = "lblLifestyleQualities";
            this.lblLifestyleQualities.Size = new System.Drawing.Size(19, 13);
            this.lblLifestyleQualities.TabIndex = 103;
            this.lblLifestyleQualities.Text = "[0]";
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.AutoSize = true;
            this.tblLifestyleDetails.SetColumnSpan(this.flowLayoutPanel11, 3);
            this.flowLayoutPanel11.Controls.Add(this.cmdAddLifestyle);
            this.flowLayoutPanel11.Controls.Add(this.cmdDeleteLifestyle);
            this.flowLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(187, 29);
            this.flowLayoutPanel11.TabIndex = 104;
            // 
            // cmdAddLifestyle
            // 
            this.cmdAddLifestyle.AutoSize = true;
            this.cmdAddLifestyle.ContextMenuStrip = this.cmsLifestyle;
            this.cmdAddLifestyle.Location = new System.Drawing.Point(3, 3);
            this.cmdAddLifestyle.Name = "cmdAddLifestyle";
            this.cmdAddLifestyle.Size = new System.Drawing.Size(95, 23);
            this.cmdAddLifestyle.SplitMenuStrip = this.cmsLifestyle;
            this.cmdAddLifestyle.TabIndex = 91;
            this.cmdAddLifestyle.Tag = "Button_AddLifestyle";
            this.cmdAddLifestyle.Text = "&Add Lifestyle";
            this.cmdAddLifestyle.UseVisualStyleBackColor = true;
            this.cmdAddLifestyle.Click += new System.EventHandler(this.cmdAddLifestyle_Click);
            // 
            // cmdDeleteLifestyle
            // 
            this.cmdDeleteLifestyle.AutoSize = true;
            this.cmdDeleteLifestyle.Location = new System.Drawing.Point(104, 3);
            this.cmdDeleteLifestyle.Name = "cmdDeleteLifestyle";
            this.cmdDeleteLifestyle.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteLifestyle.TabIndex = 81;
            this.cmdDeleteLifestyle.Tag = "String_Delete";
            this.cmdDeleteLifestyle.Text = "Delete";
            this.cmdDeleteLifestyle.UseVisualStyleBackColor = true;
            this.cmdDeleteLifestyle.Click += new System.EventHandler(this.cmdDeleteLifestyle_Click);
            // 
            // tabVehicles
            // 
            this.tabVehicles.BackColor = System.Drawing.SystemColors.Control;
            this.tabVehicles.Controls.Add(this.tlpVehicles);
            this.tabVehicles.Location = new System.Drawing.Point(4, 22);
            this.tabVehicles.Name = "tabVehicles";
            this.tabVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicles.Size = new System.Drawing.Size(841, 631);
            this.tabVehicles.TabIndex = 7;
            this.tabVehicles.Tag = "Tab_Vehicles";
            this.tabVehicles.Text = "Vehicles & Drones";
            // 
            // tlpVehicles
            // 
            this.tlpVehicles.ColumnCount = 9;
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tlpVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAccuracyLabel, 7, 1);
            this.tlpVehicles.Controls.Add(this.flowLayoutPanel8, 0, 0);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAccuracy, 8, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleNameLabel, 1, 1);
            this.tlpVehicles.Controls.Add(this.cmdVehicleCyberwareChangeMount, 1, 12);
            this.tlpVehicles.Controls.Add(this.chkVehicleActiveCommlink, 7, 11);
            this.tlpVehicles.Controls.Add(this.lblVehicleName, 2, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleCategoryLabel, 1, 2);
            this.tlpVehicles.Controls.Add(this.lblVehicleCategory, 2, 2);
            this.tlpVehicles.Controls.Add(this.lblVehicleHandlingLabel, 1, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleHandling, 2, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleAccelLabel, 3, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleAccel, 4, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleSpeedLabel, 5, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleSpeed, 6, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAmmoLabel, 7, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleCosmetic, 6, 8);
            this.tlpVehicles.Controls.Add(this.treVehicles, 0, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponMode, 4, 2);
            this.tlpVehicles.Controls.Add(this.lblVehicleDroneModSlots, 8, 7);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponModeLabel, 3, 2);
            this.tlpVehicles.Controls.Add(this.lblVehicleCosmeticLabel, 5, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleElectromagnetic, 4, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleSeats, 8, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleBodymod, 2, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleElectromagneticLabel, 3, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAP, 6, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleDroneModSlotsLabel, 7, 7);
            this.tlpVehicles.Controls.Add(this.lblVehiclePowertrain, 6, 7);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponDamage, 4, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponDamageLabel, 3, 1);
            this.tlpVehicles.Controls.Add(this.lblVehicleProtection, 4, 7);
            this.tlpVehicles.Controls.Add(this.lblVehicleBodymodLabel, 1, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponsmod, 2, 7);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAmmo, 8, 3);
            this.tlpVehicles.Controls.Add(this.lblVehicleSource, 2, 11);
            this.tlpVehicles.Controls.Add(this.nudVehicleGearQty, 2, 10);
            this.tlpVehicles.Controls.Add(this.lblVehicleSourceLabel, 1, 11);
            this.tlpVehicles.Controls.Add(this.lblVehicleSeatsLabel, 7, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleGearQtyLabel, 1, 10);
            this.tlpVehicles.Controls.Add(this.lblVehiclePowertrainLabel, 5, 7);
            this.tlpVehicles.Controls.Add(this.chkVehicleHomeNode, 7, 10);
            this.tlpVehicles.Controls.Add(this.lblVehiclePilotLabel, 1, 4);
            this.tlpVehicles.Controls.Add(this.lblVehiclePilot, 2, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleProtectionLabel, 3, 7);
            this.tlpVehicles.Controls.Add(this.chkVehicleWeaponAccessoryInstalled, 7, 9);
            this.tlpVehicles.Controls.Add(this.chkVehicleIncludedInWeapon, 4, 9);
            this.tlpVehicles.Controls.Add(this.lblVehicleBodyLabel, 3, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleBody, 4, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponsmodLabel, 1, 7);
            this.tlpVehicles.Controls.Add(this.lblVehicleArmorLabel, 5, 4);
            this.tlpVehicles.Controls.Add(this.nudVehicleRating, 2, 9);
            this.tlpVehicles.Controls.Add(this.lblVehicleSlots, 8, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleRatingLabel, 1, 9);
            this.tlpVehicles.Controls.Add(this.lblVehicleArmor, 6, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleSlotsLabel, 7, 8);
            this.tlpVehicles.Controls.Add(this.lblVehicleSensorLabel, 7, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleSensor, 8, 4);
            this.tlpVehicles.Controls.Add(this.lblVehicleAttackLabel, 1, 5);
            this.tlpVehicles.Controls.Add(this.cboVehicleGearAttack, 2, 5);
            this.tlpVehicles.Controls.Add(this.cboVehicleGearSleaze, 4, 5);
            this.tlpVehicles.Controls.Add(this.lblVehicleSleazeLabel, 3, 5);
            this.tlpVehicles.Controls.Add(this.lblVehicleDataProcessingLabel, 5, 5);
            this.tlpVehicles.Controls.Add(this.cboVehicleGearDataProcessing, 6, 5);
            this.tlpVehicles.Controls.Add(this.lblVehicleFirewallLabel, 7, 5);
            this.tlpVehicles.Controls.Add(this.cboVehicleGearFirewall, 8, 5);
            this.tlpVehicles.Controls.Add(this.lblVehicleDeviceLabel, 5, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleDevice, 6, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleCostLabel, 3, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleCost, 4, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleAvailLabel, 1, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleAvail, 2, 6);
            this.tlpVehicles.Controls.Add(this.lblVehicleWeaponAPLabel, 5, 1);
            this.tlpVehicles.Controls.Add(this.tlpVehicleWeapon, 1, 13);
            this.tlpVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVehicles.Location = new System.Drawing.Point(3, 3);
            this.tlpVehicles.Name = "tlpVehicles";
            this.tlpVehicles.RowCount = 15;
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicles.Size = new System.Drawing.Size(835, 625);
            this.tlpVehicles.TabIndex = 245;
            // 
            // lblVehicleWeaponAccuracyLabel
            // 
            this.lblVehicleWeaponAccuracyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAccuracyLabel.AutoSize = true;
            this.lblVehicleWeaponAccuracyLabel.Location = new System.Drawing.Point(711, 35);
            this.lblVehicleWeaponAccuracyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAccuracyLabel.Name = "lblVehicleWeaponAccuracyLabel";
            this.lblVehicleWeaponAccuracyLabel.Size = new System.Drawing.Size(55, 13);
            this.lblVehicleWeaponAccuracyLabel.TabIndex = 243;
            this.lblVehicleWeaponAccuracyLabel.Tag = "Label_Accuracy";
            this.lblVehicleWeaponAccuracyLabel.Text = "Accuracy:";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpVehicles.SetColumnSpan(this.flowLayoutPanel8, 9);
            this.flowLayoutPanel8.Controls.Add(this.cmdAddVehicle);
            this.flowLayoutPanel8.Controls.Add(this.cmdDeleteVehicle);
            this.flowLayoutPanel8.Controls.Add(this.cmdAddVehicleLocation);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(270, 29);
            this.flowLayoutPanel8.TabIndex = 0;
            // 
            // cmdAddVehicle
            // 
            this.cmdAddVehicle.AutoSize = true;
            this.cmdAddVehicle.ContextMenuStrip = this.cmsVehicle;
            this.cmdAddVehicle.Location = new System.Drawing.Point(3, 3);
            this.cmdAddVehicle.Name = "cmdAddVehicle";
            this.cmdAddVehicle.Size = new System.Drawing.Size(92, 23);
            this.cmdAddVehicle.SplitMenuStrip = this.cmsVehicle;
            this.cmdAddVehicle.TabIndex = 185;
            this.cmdAddVehicle.Tag = "Button_AddVehicle";
            this.cmdAddVehicle.Text = "&Add Vehicle";
            this.cmdAddVehicle.UseVisualStyleBackColor = true;
            this.cmdAddVehicle.Click += new System.EventHandler(this.cmdAddVehicle_Click);
            // 
            // cmdDeleteVehicle
            // 
            this.cmdDeleteVehicle.AutoSize = true;
            this.cmdDeleteVehicle.Location = new System.Drawing.Point(101, 3);
            this.cmdDeleteVehicle.Name = "cmdDeleteVehicle";
            this.cmdDeleteVehicle.Size = new System.Drawing.Size(80, 23);
            this.cmdDeleteVehicle.TabIndex = 32;
            this.cmdDeleteVehicle.Tag = "String_Delete";
            this.cmdDeleteVehicle.Text = "Delete";
            this.cmdDeleteVehicle.UseVisualStyleBackColor = true;
            this.cmdDeleteVehicle.Click += new System.EventHandler(this.cmdDeleteVehicle_Click);
            // 
            // cmdAddVehicleLocation
            // 
            this.cmdAddVehicleLocation.AutoSize = true;
            this.cmdAddVehicleLocation.Location = new System.Drawing.Point(187, 3);
            this.cmdAddVehicleLocation.Name = "cmdAddVehicleLocation";
            this.cmdAddVehicleLocation.Size = new System.Drawing.Size(80, 23);
            this.cmdAddVehicleLocation.TabIndex = 128;
            this.cmdAddVehicleLocation.Tag = "Button_AddLocation";
            this.cmdAddVehicleLocation.Text = "Add Location";
            this.cmdAddVehicleLocation.UseVisualStyleBackColor = true;
            this.cmdAddVehicleLocation.Click += new System.EventHandler(this.cmdAddVehicleLocation_Click);
            // 
            // lblVehicleWeaponAccuracy
            // 
            this.lblVehicleWeaponAccuracy.AutoSize = true;
            this.lblVehicleWeaponAccuracy.Location = new System.Drawing.Point(772, 35);
            this.lblVehicleWeaponAccuracy.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAccuracy.Name = "lblVehicleWeaponAccuracy";
            this.lblVehicleWeaponAccuracy.Size = new System.Drawing.Size(58, 13);
            this.lblVehicleWeaponAccuracy.TabIndex = 244;
            this.lblVehicleWeaponAccuracy.Text = "[Accuracy]";
            // 
            // lblVehicleNameLabel
            // 
            this.lblVehicleNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleNameLabel.AutoSize = true;
            this.lblVehicleNameLabel.Location = new System.Drawing.Point(329, 35);
            this.lblVehicleNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleNameLabel.Name = "lblVehicleNameLabel";
            this.lblVehicleNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblVehicleNameLabel.TabIndex = 51;
            this.lblVehicleNameLabel.Tag = "Label_Name";
            this.lblVehicleNameLabel.Text = "Name:";
            // 
            // cmdVehicleCyberwareChangeMount
            // 
            this.cmdVehicleCyberwareChangeMount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVehicleCyberwareChangeMount.AutoSize = true;
            this.tlpVehicles.SetColumnSpan(this.cmdVehicleCyberwareChangeMount, 3);
            this.cmdVehicleCyberwareChangeMount.Location = new System.Drawing.Point(304, 311);
            this.cmdVehicleCyberwareChangeMount.Name = "cmdVehicleCyberwareChangeMount";
            this.cmdVehicleCyberwareChangeMount.Size = new System.Drawing.Size(196, 23);
            this.cmdVehicleCyberwareChangeMount.TabIndex = 241;
            this.cmdVehicleCyberwareChangeMount.Tag = "Button_ChangeMountedLocation";
            this.cmdVehicleCyberwareChangeMount.Text = "Change Mounted Location";
            this.cmdVehicleCyberwareChangeMount.UseVisualStyleBackColor = true;
            this.cmdVehicleCyberwareChangeMount.Visible = false;
            this.cmdVehicleCyberwareChangeMount.Click += new System.EventHandler(this.cmdVehicleCyberwareChangeMount_Click);
            // 
            // chkVehicleActiveCommlink
            // 
            this.chkVehicleActiveCommlink.AutoSize = true;
            this.tlpVehicles.SetColumnSpan(this.chkVehicleActiveCommlink, 2);
            this.chkVehicleActiveCommlink.Location = new System.Drawing.Point(703, 287);
            this.chkVehicleActiveCommlink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkVehicleActiveCommlink.Name = "chkVehicleActiveCommlink";
            this.chkVehicleActiveCommlink.Size = new System.Drawing.Size(104, 17);
            this.chkVehicleActiveCommlink.TabIndex = 242;
            this.chkVehicleActiveCommlink.Tag = "Checkbox_ActiveCommlink";
            this.chkVehicleActiveCommlink.Text = "Active Commlink";
            this.chkVehicleActiveCommlink.UseVisualStyleBackColor = true;
            this.chkVehicleActiveCommlink.Visible = false;
            this.chkVehicleActiveCommlink.CheckedChanged += new System.EventHandler(this.chkVehicleActiveCommlink_CheckedChanged);
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.Location = new System.Drawing.Point(373, 35);
            this.lblVehicleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(41, 13);
            this.lblVehicleName.TabIndex = 52;
            this.lblVehicleName.Text = "[Name]";
            // 
            // lblVehicleCategoryLabel
            // 
            this.lblVehicleCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleCategoryLabel.AutoSize = true;
            this.lblVehicleCategoryLabel.Location = new System.Drawing.Point(315, 60);
            this.lblVehicleCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCategoryLabel.Name = "lblVehicleCategoryLabel";
            this.lblVehicleCategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.lblVehicleCategoryLabel.TabIndex = 53;
            this.lblVehicleCategoryLabel.Tag = "Label_Category";
            this.lblVehicleCategoryLabel.Text = "Category:";
            // 
            // lblVehicleCategory
            // 
            this.lblVehicleCategory.AutoSize = true;
            this.lblVehicleCategory.Location = new System.Drawing.Point(373, 60);
            this.lblVehicleCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCategory.Name = "lblVehicleCategory";
            this.lblVehicleCategory.Size = new System.Drawing.Size(55, 13);
            this.lblVehicleCategory.TabIndex = 54;
            this.lblVehicleCategory.Text = "[Category]";
            // 
            // lblVehicleHandlingLabel
            // 
            this.lblVehicleHandlingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleHandlingLabel.AutoSize = true;
            this.lblVehicleHandlingLabel.Location = new System.Drawing.Point(315, 85);
            this.lblVehicleHandlingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleHandlingLabel.Name = "lblVehicleHandlingLabel";
            this.lblVehicleHandlingLabel.Size = new System.Drawing.Size(52, 13);
            this.lblVehicleHandlingLabel.TabIndex = 33;
            this.lblVehicleHandlingLabel.Tag = "Label_Handling";
            this.lblVehicleHandlingLabel.Text = "Handling:";
            // 
            // lblVehicleHandling
            // 
            this.lblVehicleHandling.AutoSize = true;
            this.lblVehicleHandling.Location = new System.Drawing.Point(373, 85);
            this.lblVehicleHandling.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleHandling.Name = "lblVehicleHandling";
            this.lblVehicleHandling.Size = new System.Drawing.Size(55, 13);
            this.lblVehicleHandling.TabIndex = 34;
            this.lblVehicleHandling.Text = "[Handling]";
            // 
            // lblVehicleAccelLabel
            // 
            this.lblVehicleAccelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleAccelLabel.AutoSize = true;
            this.lblVehicleAccelLabel.Location = new System.Drawing.Point(463, 85);
            this.lblVehicleAccelLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleAccelLabel.Name = "lblVehicleAccelLabel";
            this.lblVehicleAccelLabel.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleAccelLabel.TabIndex = 35;
            this.lblVehicleAccelLabel.Tag = "Label_Accel";
            this.lblVehicleAccelLabel.Text = "Accel:";
            // 
            // lblVehicleAccel
            // 
            this.lblVehicleAccel.AutoSize = true;
            this.lblVehicleAccel.Location = new System.Drawing.Point(506, 85);
            this.lblVehicleAccel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleAccel.Name = "lblVehicleAccel";
            this.lblVehicleAccel.Size = new System.Drawing.Size(40, 13);
            this.lblVehicleAccel.TabIndex = 36;
            this.lblVehicleAccel.Text = "[Accel]";
            // 
            // lblVehicleSpeedLabel
            // 
            this.lblVehicleSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSpeedLabel.AutoSize = true;
            this.lblVehicleSpeedLabel.Location = new System.Drawing.Point(592, 85);
            this.lblVehicleSpeedLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSpeedLabel.Name = "lblVehicleSpeedLabel";
            this.lblVehicleSpeedLabel.Size = new System.Drawing.Size(41, 13);
            this.lblVehicleSpeedLabel.TabIndex = 37;
            this.lblVehicleSpeedLabel.Tag = "Label_Speed";
            this.lblVehicleSpeedLabel.Text = "Speed:";
            // 
            // lblVehicleSpeed
            // 
            this.lblVehicleSpeed.AutoSize = true;
            this.lblVehicleSpeed.Location = new System.Drawing.Point(639, 85);
            this.lblVehicleSpeed.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSpeed.Name = "lblVehicleSpeed";
            this.lblVehicleSpeed.Size = new System.Drawing.Size(44, 13);
            this.lblVehicleSpeed.TabIndex = 38;
            this.lblVehicleSpeed.Text = "[Speed]";
            // 
            // lblVehicleWeaponAmmoLabel
            // 
            this.lblVehicleWeaponAmmoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAmmoLabel.AutoSize = true;
            this.lblVehicleWeaponAmmoLabel.Location = new System.Drawing.Point(727, 85);
            this.lblVehicleWeaponAmmoLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAmmoLabel.Name = "lblVehicleWeaponAmmoLabel";
            this.lblVehicleWeaponAmmoLabel.Size = new System.Drawing.Size(39, 13);
            this.lblVehicleWeaponAmmoLabel.TabIndex = 140;
            this.lblVehicleWeaponAmmoLabel.Tag = "Label_Ammo";
            this.lblVehicleWeaponAmmoLabel.Text = "Ammo:";
            // 
            // lblVehicleCosmetic
            // 
            this.lblVehicleCosmetic.AutoSize = true;
            this.lblVehicleCosmetic.Location = new System.Drawing.Point(639, 212);
            this.lblVehicleCosmetic.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCosmetic.Name = "lblVehicleCosmetic";
            this.lblVehicleCosmetic.Size = new System.Drawing.Size(56, 13);
            this.lblVehicleCosmetic.TabIndex = 208;
            this.lblVehicleCosmetic.Text = "[Cosmetic]";
            // 
            // treVehicles
            // 
            this.treVehicles.AllowDrop = true;
            this.treVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treVehicles.HideSelection = false;
            this.treVehicles.Location = new System.Drawing.Point(3, 32);
            this.treVehicles.Name = "treVehicles";
            treeNode3.Name = "nodVehiclesRoot";
            treeNode3.Tag = "Node_SelectedVehicles";
            treeNode3.Text = "Selected Vehicles";
            this.treVehicles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tlpVehicles.SetRowSpan(this.treVehicles, 14);
            this.treVehicles.ShowNodeToolTips = true;
            this.treVehicles.ShowRootLines = false;
            this.treVehicles.Size = new System.Drawing.Size(295, 590);
            this.treVehicles.TabIndex = 30;
            this.treVehicles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treVehicles_AfterSelect);
            this.treVehicles.DragOver += new System.Windows.Forms.DragEventHandler(this.treVehicles_DragOver);
            this.treVehicles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treVehicles_KeyDown);
            this.treVehicles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            // 
            // lblVehicleWeaponMode
            // 
            this.lblVehicleWeaponMode.AutoSize = true;
            this.lblVehicleWeaponMode.Location = new System.Drawing.Point(506, 60);
            this.lblVehicleWeaponMode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponMode.Name = "lblVehicleWeaponMode";
            this.lblVehicleWeaponMode.Size = new System.Drawing.Size(40, 13);
            this.lblVehicleWeaponMode.TabIndex = 139;
            this.lblVehicleWeaponMode.Text = "[Mode]";
            // 
            // lblVehicleDroneModSlots
            // 
            this.lblVehicleDroneModSlots.AutoSize = true;
            this.lblVehicleDroneModSlots.Location = new System.Drawing.Point(772, 187);
            this.lblVehicleDroneModSlots.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleDroneModSlots.Name = "lblVehicleDroneModSlots";
            this.lblVehicleDroneModSlots.Size = new System.Drawing.Size(57, 13);
            this.lblVehicleDroneModSlots.TabIndex = 210;
            this.lblVehicleDroneModSlots.Text = "[ModSlots]";
            this.lblVehicleDroneModSlots.Visible = false;
            // 
            // lblVehicleWeaponModeLabel
            // 
            this.lblVehicleWeaponModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponModeLabel.AutoSize = true;
            this.lblVehicleWeaponModeLabel.Location = new System.Drawing.Point(463, 60);
            this.lblVehicleWeaponModeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponModeLabel.Name = "lblVehicleWeaponModeLabel";
            this.lblVehicleWeaponModeLabel.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleWeaponModeLabel.TabIndex = 138;
            this.lblVehicleWeaponModeLabel.Tag = "Label_Mode";
            this.lblVehicleWeaponModeLabel.Text = "Mode:";
            // 
            // lblVehicleCosmeticLabel
            // 
            this.lblVehicleCosmeticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleCosmeticLabel.AutoSize = true;
            this.lblVehicleCosmeticLabel.Location = new System.Drawing.Point(580, 212);
            this.lblVehicleCosmeticLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCosmeticLabel.Name = "lblVehicleCosmeticLabel";
            this.lblVehicleCosmeticLabel.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleCosmeticLabel.TabIndex = 202;
            this.lblVehicleCosmeticLabel.Tag = "Label_Cosmetic";
            this.lblVehicleCosmeticLabel.Text = "Cosmetic:";
            // 
            // lblVehicleElectromagnetic
            // 
            this.lblVehicleElectromagnetic.AutoSize = true;
            this.lblVehicleElectromagnetic.Location = new System.Drawing.Point(506, 212);
            this.lblVehicleElectromagnetic.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleElectromagnetic.Name = "lblVehicleElectromagnetic";
            this.lblVehicleElectromagnetic.Size = new System.Drawing.Size(34, 13);
            this.lblVehicleElectromagnetic.TabIndex = 207;
            this.lblVehicleElectromagnetic.Text = "[Elec]";
            // 
            // lblVehicleSeats
            // 
            this.lblVehicleSeats.AutoSize = true;
            this.lblVehicleSeats.Location = new System.Drawing.Point(772, 162);
            this.lblVehicleSeats.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSeats.Name = "lblVehicleSeats";
            this.lblVehicleSeats.Size = new System.Drawing.Size(40, 13);
            this.lblVehicleSeats.TabIndex = 212;
            this.lblVehicleSeats.Text = "[Seats]";
            // 
            // lblVehicleBodymod
            // 
            this.lblVehicleBodymod.AutoSize = true;
            this.lblVehicleBodymod.Location = new System.Drawing.Point(373, 212);
            this.lblVehicleBodymod.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleBodymod.Name = "lblVehicleBodymod";
            this.lblVehicleBodymod.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleBodymod.TabIndex = 206;
            this.lblVehicleBodymod.Text = "[Body]";
            // 
            // lblVehicleElectromagneticLabel
            // 
            this.lblVehicleElectromagneticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleElectromagneticLabel.AutoSize = true;
            this.lblVehicleElectromagneticLabel.Location = new System.Drawing.Point(469, 212);
            this.lblVehicleElectromagneticLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleElectromagneticLabel.Name = "lblVehicleElectromagneticLabel";
            this.lblVehicleElectromagneticLabel.Size = new System.Drawing.Size(31, 13);
            this.lblVehicleElectromagneticLabel.TabIndex = 201;
            this.lblVehicleElectromagneticLabel.Tag = "Label_Electromagnetic";
            this.lblVehicleElectromagneticLabel.Text = "Elec:";
            // 
            // lblVehicleWeaponAP
            // 
            this.lblVehicleWeaponAP.AutoSize = true;
            this.lblVehicleWeaponAP.Location = new System.Drawing.Point(639, 35);
            this.lblVehicleWeaponAP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAP.Name = "lblVehicleWeaponAP";
            this.lblVehicleWeaponAP.Size = new System.Drawing.Size(27, 13);
            this.lblVehicleWeaponAP.TabIndex = 137;
            this.lblVehicleWeaponAP.Text = "[AP]";
            // 
            // lblVehicleDroneModSlotsLabel
            // 
            this.lblVehicleDroneModSlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleDroneModSlotsLabel.AutoSize = true;
            this.lblVehicleDroneModSlotsLabel.Location = new System.Drawing.Point(709, 187);
            this.lblVehicleDroneModSlotsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleDroneModSlotsLabel.Name = "lblVehicleDroneModSlotsLabel";
            this.lblVehicleDroneModSlotsLabel.Size = new System.Drawing.Size(57, 13);
            this.lblVehicleDroneModSlotsLabel.TabIndex = 209;
            this.lblVehicleDroneModSlotsLabel.Tag = "Label_DroneModSlots";
            this.lblVehicleDroneModSlotsLabel.Text = "Mod Slots:";
            this.lblVehicleDroneModSlotsLabel.Visible = false;
            // 
            // lblVehiclePowertrain
            // 
            this.lblVehiclePowertrain.AutoSize = true;
            this.lblVehiclePowertrain.Location = new System.Drawing.Point(639, 187);
            this.lblVehiclePowertrain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehiclePowertrain.Name = "lblVehiclePowertrain";
            this.lblVehiclePowertrain.Size = new System.Drawing.Size(43, 13);
            this.lblVehiclePowertrain.TabIndex = 203;
            this.lblVehiclePowertrain.Text = "[Power]";
            // 
            // lblVehicleWeaponDamage
            // 
            this.lblVehicleWeaponDamage.AutoSize = true;
            this.lblVehicleWeaponDamage.Location = new System.Drawing.Point(506, 35);
            this.lblVehicleWeaponDamage.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponDamage.Name = "lblVehicleWeaponDamage";
            this.lblVehicleWeaponDamage.Size = new System.Drawing.Size(53, 13);
            this.lblVehicleWeaponDamage.TabIndex = 135;
            this.lblVehicleWeaponDamage.Text = "[Damage]";
            // 
            // lblVehicleWeaponDamageLabel
            // 
            this.lblVehicleWeaponDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponDamageLabel.AutoSize = true;
            this.lblVehicleWeaponDamageLabel.Location = new System.Drawing.Point(450, 35);
            this.lblVehicleWeaponDamageLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponDamageLabel.Name = "lblVehicleWeaponDamageLabel";
            this.lblVehicleWeaponDamageLabel.Size = new System.Drawing.Size(50, 13);
            this.lblVehicleWeaponDamageLabel.TabIndex = 134;
            this.lblVehicleWeaponDamageLabel.Tag = "Label_Damage";
            this.lblVehicleWeaponDamageLabel.Text = "Damage:";
            // 
            // lblVehicleProtection
            // 
            this.lblVehicleProtection.AutoSize = true;
            this.lblVehicleProtection.Location = new System.Drawing.Point(506, 187);
            this.lblVehicleProtection.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleProtection.Name = "lblVehicleProtection";
            this.lblVehicleProtection.Size = new System.Drawing.Size(32, 13);
            this.lblVehicleProtection.TabIndex = 204;
            this.lblVehicleProtection.Text = "[Prot]";
            // 
            // lblVehicleBodymodLabel
            // 
            this.lblVehicleBodymodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleBodymodLabel.AutoSize = true;
            this.lblVehicleBodymodLabel.Location = new System.Drawing.Point(304, 212);
            this.lblVehicleBodymodLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleBodymodLabel.Name = "lblVehicleBodymodLabel";
            this.lblVehicleBodymodLabel.Size = new System.Drawing.Size(63, 13);
            this.lblVehicleBodymodLabel.TabIndex = 200;
            this.lblVehicleBodymodLabel.Tag = "Label_Bodymod";
            this.lblVehicleBodymodLabel.Text = "Body Mods:";
            // 
            // lblVehicleWeaponsmod
            // 
            this.lblVehicleWeaponsmod.AutoSize = true;
            this.lblVehicleWeaponsmod.Location = new System.Drawing.Point(373, 187);
            this.lblVehicleWeaponsmod.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponsmod.Name = "lblVehicleWeaponsmod";
            this.lblVehicleWeaponsmod.Size = new System.Drawing.Size(42, 13);
            this.lblVehicleWeaponsmod.TabIndex = 205;
            this.lblVehicleWeaponsmod.Text = "[Weap]";
            // 
            // lblVehicleWeaponAmmo
            // 
            this.lblVehicleWeaponAmmo.AutoSize = true;
            this.lblVehicleWeaponAmmo.Location = new System.Drawing.Point(772, 85);
            this.lblVehicleWeaponAmmo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAmmo.Name = "lblVehicleWeaponAmmo";
            this.lblVehicleWeaponAmmo.Size = new System.Drawing.Size(42, 13);
            this.lblVehicleWeaponAmmo.TabIndex = 141;
            this.lblVehicleWeaponAmmo.Text = "[Ammo]";
            // 
            // lblVehicleSource
            // 
            this.lblVehicleSource.AutoSize = true;
            this.lblVehicleSource.Location = new System.Drawing.Point(373, 289);
            this.lblVehicleSource.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSource.Name = "lblVehicleSource";
            this.lblVehicleSource.Size = new System.Drawing.Size(47, 13);
            this.lblVehicleSource.TabIndex = 60;
            this.lblVehicleSource.Text = "[Source]";
            this.lblVehicleSource.Click += new System.EventHandler(this.OpenSourceFromLabel);
            // 
            // nudVehicleGearQty
            // 
            this.nudVehicleGearQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpVehicles.SetColumnSpan(this.nudVehicleGearQty, 2);
            this.nudVehicleGearQty.Enabled = false;
            this.nudVehicleGearQty.Location = new System.Drawing.Point(373, 260);
            this.nudVehicleGearQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVehicleGearQty.Name = "nudVehicleGearQty";
            this.nudVehicleGearQty.Size = new System.Drawing.Size(127, 20);
            this.nudVehicleGearQty.TabIndex = 79;
            this.nudVehicleGearQty.ValueChanged += new System.EventHandler(this.nudVehicleGearQty_ValueChanged);
            // 
            // lblVehicleSourceLabel
            // 
            this.lblVehicleSourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSourceLabel.AutoSize = true;
            this.lblVehicleSourceLabel.Location = new System.Drawing.Point(323, 289);
            this.lblVehicleSourceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSourceLabel.Name = "lblVehicleSourceLabel";
            this.lblVehicleSourceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblVehicleSourceLabel.TabIndex = 59;
            this.lblVehicleSourceLabel.Tag = "Label_Source";
            this.lblVehicleSourceLabel.Text = "Source:";
            // 
            // lblVehicleSeatsLabel
            // 
            this.lblVehicleSeatsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSeatsLabel.AutoSize = true;
            this.lblVehicleSeatsLabel.Location = new System.Drawing.Point(729, 162);
            this.lblVehicleSeatsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSeatsLabel.Name = "lblVehicleSeatsLabel";
            this.lblVehicleSeatsLabel.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleSeatsLabel.TabIndex = 211;
            this.lblVehicleSeatsLabel.Tag = "Label_VehicleSeats";
            this.lblVehicleSeatsLabel.Text = "Seats:";
            // 
            // lblVehicleGearQtyLabel
            // 
            this.lblVehicleGearQtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleGearQtyLabel.AutoSize = true;
            this.lblVehicleGearQtyLabel.Location = new System.Drawing.Point(315, 263);
            this.lblVehicleGearQtyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleGearQtyLabel.Name = "lblVehicleGearQtyLabel";
            this.lblVehicleGearQtyLabel.Size = new System.Drawing.Size(52, 13);
            this.lblVehicleGearQtyLabel.TabIndex = 78;
            this.lblVehicleGearQtyLabel.Tag = "Label_GearQty";
            this.lblVehicleGearQtyLabel.Text = "Gear Qty:";
            // 
            // lblVehiclePowertrainLabel
            // 
            this.lblVehiclePowertrainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehiclePowertrainLabel.AutoSize = true;
            this.lblVehiclePowertrainLabel.Location = new System.Drawing.Point(593, 187);
            this.lblVehiclePowertrainLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehiclePowertrainLabel.Name = "lblVehiclePowertrainLabel";
            this.lblVehiclePowertrainLabel.Size = new System.Drawing.Size(40, 13);
            this.lblVehiclePowertrainLabel.TabIndex = 197;
            this.lblVehiclePowertrainLabel.Tag = "Label_Powertrain";
            this.lblVehiclePowertrainLabel.Text = "Power:";
            // 
            // chkVehicleHomeNode
            // 
            this.chkVehicleHomeNode.AutoSize = true;
            this.tlpVehicles.SetColumnSpan(this.chkVehicleHomeNode, 2);
            this.chkVehicleHomeNode.Location = new System.Drawing.Point(703, 261);
            this.chkVehicleHomeNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkVehicleHomeNode.Name = "chkVehicleHomeNode";
            this.chkVehicleHomeNode.Size = new System.Drawing.Size(83, 17);
            this.chkVehicleHomeNode.TabIndex = 127;
            this.chkVehicleHomeNode.Tag = "Checkbox_HomeNode";
            this.chkVehicleHomeNode.Text = "Home Node";
            this.chkVehicleHomeNode.UseVisualStyleBackColor = true;
            this.chkVehicleHomeNode.Visible = false;
            this.chkVehicleHomeNode.CheckedChanged += new System.EventHandler(this.chkVehicleHomeNode_CheckedChanged);
            // 
            // lblVehiclePilotLabel
            // 
            this.lblVehiclePilotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehiclePilotLabel.AutoSize = true;
            this.lblVehiclePilotLabel.Location = new System.Drawing.Point(337, 110);
            this.lblVehiclePilotLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehiclePilotLabel.Name = "lblVehiclePilotLabel";
            this.lblVehiclePilotLabel.Size = new System.Drawing.Size(30, 13);
            this.lblVehiclePilotLabel.TabIndex = 39;
            this.lblVehiclePilotLabel.Tag = "Label_Pilot";
            this.lblVehiclePilotLabel.Text = "Pilot:";
            // 
            // lblVehiclePilot
            // 
            this.lblVehiclePilot.AutoSize = true;
            this.lblVehiclePilot.Location = new System.Drawing.Point(373, 110);
            this.lblVehiclePilot.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehiclePilot.Name = "lblVehiclePilot";
            this.lblVehiclePilot.Size = new System.Drawing.Size(33, 13);
            this.lblVehiclePilot.TabIndex = 40;
            this.lblVehiclePilot.Text = "[Pilot]";
            // 
            // lblVehicleProtectionLabel
            // 
            this.lblVehicleProtectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleProtectionLabel.AutoSize = true;
            this.lblVehicleProtectionLabel.Location = new System.Drawing.Point(471, 187);
            this.lblVehicleProtectionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleProtectionLabel.Name = "lblVehicleProtectionLabel";
            this.lblVehicleProtectionLabel.Size = new System.Drawing.Size(29, 13);
            this.lblVehicleProtectionLabel.TabIndex = 198;
            this.lblVehicleProtectionLabel.Tag = "Label_Protection";
            this.lblVehicleProtectionLabel.Text = "Prot:";
            // 
            // chkVehicleIncludedInWeapon
            // 
            this.chkVehicleIncludedInWeapon.AutoSize = true;
            this.tlpVehicles.SetColumnSpan(this.chkVehicleIncludedInWeapon, 2);
            this.chkVehicleIncludedInWeapon.Enabled = false;
            this.chkVehicleIncludedInWeapon.Location = new System.Drawing.Point(506, 235);
            this.chkVehicleIncludedInWeapon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkVehicleIncludedInWeapon.Name = "chkVehicleIncludedInWeapon";
            this.chkVehicleIncludedInWeapon.Size = new System.Drawing.Size(127, 17);
            this.chkVehicleIncludedInWeapon.TabIndex = 75;
            this.chkVehicleIncludedInWeapon.Tag = "Checkbox_BaseWeapon";
            this.chkVehicleIncludedInWeapon.Text = "Part of base Weapon";
            this.chkVehicleIncludedInWeapon.UseVisualStyleBackColor = true;
            // 
            // lblVehicleBodyLabel
            // 
            this.lblVehicleBodyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleBodyLabel.AutoSize = true;
            this.lblVehicleBodyLabel.Location = new System.Drawing.Point(466, 110);
            this.lblVehicleBodyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleBodyLabel.Name = "lblVehicleBodyLabel";
            this.lblVehicleBodyLabel.Size = new System.Drawing.Size(34, 13);
            this.lblVehicleBodyLabel.TabIndex = 41;
            this.lblVehicleBodyLabel.Tag = "Label_Body";
            this.lblVehicleBodyLabel.Text = "Body:";
            // 
            // lblVehicleBody
            // 
            this.lblVehicleBody.AutoSize = true;
            this.lblVehicleBody.Location = new System.Drawing.Point(506, 110);
            this.lblVehicleBody.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleBody.Name = "lblVehicleBody";
            this.lblVehicleBody.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleBody.TabIndex = 42;
            this.lblVehicleBody.Text = "[Body]";
            // 
            // lblVehicleWeaponsmodLabel
            // 
            this.lblVehicleWeaponsmodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponsmodLabel.AutoSize = true;
            this.lblVehicleWeaponsmodLabel.Location = new System.Drawing.Point(311, 187);
            this.lblVehicleWeaponsmodLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponsmodLabel.Name = "lblVehicleWeaponsmodLabel";
            this.lblVehicleWeaponsmodLabel.Size = new System.Drawing.Size(56, 13);
            this.lblVehicleWeaponsmodLabel.TabIndex = 199;
            this.lblVehicleWeaponsmodLabel.Tag = "Label_Weapons";
            this.lblVehicleWeaponsmodLabel.Text = "Weapons:";
            // 
            // lblVehicleArmorLabel
            // 
            this.lblVehicleArmorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleArmorLabel.AutoSize = true;
            this.lblVehicleArmorLabel.Location = new System.Drawing.Point(596, 110);
            this.lblVehicleArmorLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleArmorLabel.Name = "lblVehicleArmorLabel";
            this.lblVehicleArmorLabel.Size = new System.Drawing.Size(37, 13);
            this.lblVehicleArmorLabel.TabIndex = 43;
            this.lblVehicleArmorLabel.Tag = "Label_Armor";
            this.lblVehicleArmorLabel.Text = "Armor:";
            // 
            // nudVehicleRating
            // 
            this.nudVehicleRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpVehicles.SetColumnSpan(this.nudVehicleRating, 2);
            this.nudVehicleRating.Enabled = false;
            this.nudVehicleRating.Location = new System.Drawing.Point(373, 234);
            this.nudVehicleRating.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudVehicleRating.Name = "nudVehicleRating";
            this.nudVehicleRating.Size = new System.Drawing.Size(127, 20);
            this.nudVehicleRating.TabIndex = 56;
            this.nudVehicleRating.ValueChanged += new System.EventHandler(this.nudVehicleRating_ValueChanged);
            // 
            // lblVehicleSlots
            // 
            this.lblVehicleSlots.AutoSize = true;
            this.lblVehicleSlots.Location = new System.Drawing.Point(772, 212);
            this.lblVehicleSlots.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSlots.Name = "lblVehicleSlots";
            this.lblVehicleSlots.Size = new System.Drawing.Size(36, 13);
            this.lblVehicleSlots.TabIndex = 58;
            this.lblVehicleSlots.Text = "[Slots]";
            this.lblVehicleSlots.Visible = false;
            // 
            // lblVehicleRatingLabel
            // 
            this.lblVehicleRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleRatingLabel.AutoSize = true;
            this.lblVehicleRatingLabel.Location = new System.Drawing.Point(326, 237);
            this.lblVehicleRatingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleRatingLabel.Name = "lblVehicleRatingLabel";
            this.lblVehicleRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.lblVehicleRatingLabel.TabIndex = 55;
            this.lblVehicleRatingLabel.Tag = "Label_Rating";
            this.lblVehicleRatingLabel.Text = "Rating:";
            // 
            // lblVehicleArmor
            // 
            this.lblVehicleArmor.AutoSize = true;
            this.lblVehicleArmor.Location = new System.Drawing.Point(639, 110);
            this.lblVehicleArmor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleArmor.Name = "lblVehicleArmor";
            this.lblVehicleArmor.Size = new System.Drawing.Size(40, 13);
            this.lblVehicleArmor.TabIndex = 44;
            this.lblVehicleArmor.Text = "[Armor]";
            // 
            // lblVehicleSlotsLabel
            // 
            this.lblVehicleSlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSlotsLabel.AutoSize = true;
            this.lblVehicleSlotsLabel.Location = new System.Drawing.Point(733, 212);
            this.lblVehicleSlotsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSlotsLabel.Name = "lblVehicleSlotsLabel";
            this.lblVehicleSlotsLabel.Size = new System.Drawing.Size(33, 13);
            this.lblVehicleSlotsLabel.TabIndex = 57;
            this.lblVehicleSlotsLabel.Tag = "Label_Slots";
            this.lblVehicleSlotsLabel.Text = "Slots:";
            this.lblVehicleSlotsLabel.Visible = false;
            // 
            // lblVehicleSensorLabel
            // 
            this.lblVehicleSensorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSensorLabel.AutoSize = true;
            this.lblVehicleSensorLabel.Location = new System.Drawing.Point(723, 110);
            this.lblVehicleSensorLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSensorLabel.Name = "lblVehicleSensorLabel";
            this.lblVehicleSensorLabel.Size = new System.Drawing.Size(43, 13);
            this.lblVehicleSensorLabel.TabIndex = 45;
            this.lblVehicleSensorLabel.Tag = "Label_Sensor";
            this.lblVehicleSensorLabel.Text = "Sensor:";
            // 
            // lblVehicleSensor
            // 
            this.lblVehicleSensor.AutoSize = true;
            this.lblVehicleSensor.Location = new System.Drawing.Point(772, 110);
            this.lblVehicleSensor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSensor.Name = "lblVehicleSensor";
            this.lblVehicleSensor.Size = new System.Drawing.Size(46, 13);
            this.lblVehicleSensor.TabIndex = 46;
            this.lblVehicleSensor.Text = "[Sensor]";
            // 
            // lblVehicleAttackLabel
            // 
            this.lblVehicleAttackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleAttackLabel.AutoSize = true;
            this.lblVehicleAttackLabel.Location = new System.Drawing.Point(326, 135);
            this.lblVehicleAttackLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleAttackLabel.Name = "lblVehicleAttackLabel";
            this.lblVehicleAttackLabel.Size = new System.Drawing.Size(41, 13);
            this.lblVehicleAttackLabel.TabIndex = 186;
            this.lblVehicleAttackLabel.Tag = "Label_Attack";
            this.lblVehicleAttackLabel.Text = "Attack:";
            // 
            // cboVehicleGearAttack
            // 
            this.cboVehicleGearAttack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVehicleGearAttack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleGearAttack.FormattingEnabled = true;
            this.cboVehicleGearAttack.Location = new System.Drawing.Point(373, 132);
            this.cboVehicleGearAttack.Name = "cboVehicleGearAttack";
            this.cboVehicleGearAttack.Size = new System.Drawing.Size(58, 21);
            this.cboVehicleGearAttack.TabIndex = 193;
            this.cboVehicleGearAttack.TooltipText = "";
            this.cboVehicleGearAttack.Visible = false;
            this.cboVehicleGearAttack.SelectedIndexChanged += new System.EventHandler(this.cboVehicleGearAttack_SelectedIndexChanged);
            // 
            // cboVehicleGearSleaze
            // 
            this.cboVehicleGearSleaze.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVehicleGearSleaze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleGearSleaze.FormattingEnabled = true;
            this.cboVehicleGearSleaze.Location = new System.Drawing.Point(506, 132);
            this.cboVehicleGearSleaze.Name = "cboVehicleGearSleaze";
            this.cboVehicleGearSleaze.Size = new System.Drawing.Size(58, 21);
            this.cboVehicleGearSleaze.TabIndex = 194;
            this.cboVehicleGearSleaze.TooltipText = "";
            this.cboVehicleGearSleaze.Visible = false;
            this.cboVehicleGearSleaze.SelectedIndexChanged += new System.EventHandler(this.cboVehicleGearSleaze_SelectedIndexChanged);
            // 
            // lblVehicleSleazeLabel
            // 
            this.lblVehicleSleazeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleSleazeLabel.AutoSize = true;
            this.lblVehicleSleazeLabel.Location = new System.Drawing.Point(458, 135);
            this.lblVehicleSleazeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleSleazeLabel.Name = "lblVehicleSleazeLabel";
            this.lblVehicleSleazeLabel.Size = new System.Drawing.Size(42, 13);
            this.lblVehicleSleazeLabel.TabIndex = 188;
            this.lblVehicleSleazeLabel.Tag = "Label_Sleaze";
            this.lblVehicleSleazeLabel.Text = "Sleaze:";
            // 
            // lblVehicleDataProcessingLabel
            // 
            this.lblVehicleDataProcessingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleDataProcessingLabel.AutoSize = true;
            this.lblVehicleDataProcessingLabel.Location = new System.Drawing.Point(575, 135);
            this.lblVehicleDataProcessingLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleDataProcessingLabel.Name = "lblVehicleDataProcessingLabel";
            this.lblVehicleDataProcessingLabel.Size = new System.Drawing.Size(58, 13);
            this.lblVehicleDataProcessingLabel.TabIndex = 190;
            this.lblVehicleDataProcessingLabel.Tag = "Label_DataProcessing";
            this.lblVehicleDataProcessingLabel.Text = "Data Proc:";
            // 
            // cboVehicleGearDataProcessing
            // 
            this.cboVehicleGearDataProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVehicleGearDataProcessing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleGearDataProcessing.FormattingEnabled = true;
            this.cboVehicleGearDataProcessing.Location = new System.Drawing.Point(639, 132);
            this.cboVehicleGearDataProcessing.Name = "cboVehicleGearDataProcessing";
            this.cboVehicleGearDataProcessing.Size = new System.Drawing.Size(58, 21);
            this.cboVehicleGearDataProcessing.TabIndex = 196;
            this.cboVehicleGearDataProcessing.TooltipText = "";
            this.cboVehicleGearDataProcessing.Visible = false;
            this.cboVehicleGearDataProcessing.SelectedIndexChanged += new System.EventHandler(this.cboVehicleGearDataProcessing_SelectedIndexChanged);
            // 
            // lblVehicleFirewallLabel
            // 
            this.lblVehicleFirewallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleFirewallLabel.AutoSize = true;
            this.lblVehicleFirewallLabel.Location = new System.Drawing.Point(721, 135);
            this.lblVehicleFirewallLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleFirewallLabel.Name = "lblVehicleFirewallLabel";
            this.lblVehicleFirewallLabel.Size = new System.Drawing.Size(45, 13);
            this.lblVehicleFirewallLabel.TabIndex = 192;
            this.lblVehicleFirewallLabel.Tag = "Label_Firewall";
            this.lblVehicleFirewallLabel.Text = "Firewall:";
            // 
            // cboVehicleGearFirewall
            // 
            this.cboVehicleGearFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboVehicleGearFirewall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleGearFirewall.FormattingEnabled = true;
            this.cboVehicleGearFirewall.Location = new System.Drawing.Point(772, 132);
            this.cboVehicleGearFirewall.Name = "cboVehicleGearFirewall";
            this.cboVehicleGearFirewall.Size = new System.Drawing.Size(60, 21);
            this.cboVehicleGearFirewall.TabIndex = 195;
            this.cboVehicleGearFirewall.TooltipText = "";
            this.cboVehicleGearFirewall.Visible = false;
            this.cboVehicleGearFirewall.SelectedIndexChanged += new System.EventHandler(this.cboVehicleGearFirewall_SelectedIndexChanged);
            // 
            // lblVehicleDeviceLabel
            // 
            this.lblVehicleDeviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleDeviceLabel.AutoSize = true;
            this.lblVehicleDeviceLabel.Location = new System.Drawing.Point(589, 162);
            this.lblVehicleDeviceLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleDeviceLabel.Name = "lblVehicleDeviceLabel";
            this.lblVehicleDeviceLabel.Size = new System.Drawing.Size(44, 13);
            this.lblVehicleDeviceLabel.TabIndex = 117;
            this.lblVehicleDeviceLabel.Tag = "Label_Device";
            this.lblVehicleDeviceLabel.Text = "Device:";
            // 
            // lblVehicleDevice
            // 
            this.lblVehicleDevice.AutoSize = true;
            this.lblVehicleDevice.Location = new System.Drawing.Point(639, 162);
            this.lblVehicleDevice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleDevice.Name = "lblVehicleDevice";
            this.lblVehicleDevice.Size = new System.Drawing.Size(47, 13);
            this.lblVehicleDevice.TabIndex = 118;
            this.lblVehicleDevice.Text = "[Device]";
            // 
            // lblVehicleCostLabel
            // 
            this.lblVehicleCostLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleCostLabel.AutoSize = true;
            this.lblVehicleCostLabel.Location = new System.Drawing.Point(469, 162);
            this.lblVehicleCostLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCostLabel.Name = "lblVehicleCostLabel";
            this.lblVehicleCostLabel.Size = new System.Drawing.Size(31, 13);
            this.lblVehicleCostLabel.TabIndex = 49;
            this.lblVehicleCostLabel.Tag = "Label_Cost";
            this.lblVehicleCostLabel.Text = "Cost:";
            // 
            // lblVehicleCost
            // 
            this.lblVehicleCost.AutoSize = true;
            this.lblVehicleCost.Location = new System.Drawing.Point(506, 162);
            this.lblVehicleCost.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleCost.Name = "lblVehicleCost";
            this.lblVehicleCost.Size = new System.Drawing.Size(34, 13);
            this.lblVehicleCost.TabIndex = 50;
            this.lblVehicleCost.Text = "[Cost]";
            // 
            // lblVehicleAvailLabel
            // 
            this.lblVehicleAvailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleAvailLabel.AutoSize = true;
            this.lblVehicleAvailLabel.Location = new System.Drawing.Point(334, 162);
            this.lblVehicleAvailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleAvailLabel.Name = "lblVehicleAvailLabel";
            this.lblVehicleAvailLabel.Size = new System.Drawing.Size(33, 13);
            this.lblVehicleAvailLabel.TabIndex = 47;
            this.lblVehicleAvailLabel.Tag = "Label_Avail";
            this.lblVehicleAvailLabel.Text = "Avail:";
            // 
            // lblVehicleAvail
            // 
            this.lblVehicleAvail.AutoSize = true;
            this.lblVehicleAvail.Location = new System.Drawing.Point(373, 162);
            this.lblVehicleAvail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleAvail.Name = "lblVehicleAvail";
            this.lblVehicleAvail.Size = new System.Drawing.Size(36, 13);
            this.lblVehicleAvail.TabIndex = 48;
            this.lblVehicleAvail.Text = "[Avail]";
            // 
            // lblVehicleWeaponAPLabel
            // 
            this.lblVehicleWeaponAPLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAPLabel.AutoSize = true;
            this.lblVehicleWeaponAPLabel.Location = new System.Drawing.Point(609, 35);
            this.lblVehicleWeaponAPLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAPLabel.Name = "lblVehicleWeaponAPLabel";
            this.lblVehicleWeaponAPLabel.Size = new System.Drawing.Size(24, 13);
            this.lblVehicleWeaponAPLabel.TabIndex = 136;
            this.lblVehicleWeaponAPLabel.Tag = "Label_AP";
            this.lblVehicleWeaponAPLabel.Text = "AP:";
            // 
            // tlpVehicleWeapon
            // 
            this.tlpVehicleWeapon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpVehicleWeapon.AutoSize = true;
            this.tlpVehicleWeapon.ColumnCount = 5;
            this.tlpVehicles.SetColumnSpan(this.tlpVehicleWeapon, 8);
            this.tlpVehicleWeapon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehicleWeapon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehicleWeapon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehicleWeapon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehicleWeapon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponAlternateRangeExtreme, 4, 2);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponDicePool, 1, 3);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeExtreme, 4, 1);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponAlternateRangeLong, 3, 2);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeExtremeLabel, 4, 0);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeLabel, 0, 0);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponAlternateRangeMedium, 2, 2);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeLong, 3, 1);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponDicePoolLabel, 0, 3);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponAlternateRangeShort, 1, 2);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeLongLabel, 3, 0);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeShortLabel, 1, 0);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeMedium, 2, 1);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeAlternate, 0, 2);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeMain, 0, 1);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeMediumLabel, 2, 0);
            this.tlpVehicleWeapon.Controls.Add(this.lblVehicleWeaponRangeShort, 1, 1);
            this.tlpVehicleWeapon.Location = new System.Drawing.Point(301, 337);
            this.tlpVehicleWeapon.Margin = new System.Windows.Forms.Padding(0);
            this.tlpVehicleWeapon.Name = "tlpVehicleWeapon";
            this.tlpVehicleWeapon.RowCount = 4;
            this.tlpVehicleWeapon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicleWeapon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicleWeapon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicleWeapon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpVehicleWeapon.Size = new System.Drawing.Size(534, 113);
            this.tlpVehicleWeapon.TabIndex = 245;
            // 
            // lblVehicleWeaponAlternateRangeExtreme
            // 
            this.lblVehicleWeaponAlternateRangeExtreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAlternateRangeExtreme.Location = new System.Drawing.Point(427, 56);
            this.lblVehicleWeaponAlternateRangeExtreme.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAlternateRangeExtreme.Name = "lblVehicleWeaponAlternateRangeExtreme";
            this.lblVehicleWeaponAlternateRangeExtreme.Size = new System.Drawing.Size(104, 13);
            this.lblVehicleWeaponAlternateRangeExtreme.TabIndex = 236;
            this.lblVehicleWeaponAlternateRangeExtreme.Text = "[0]";
            this.lblVehicleWeaponAlternateRangeExtreme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponDicePool
            // 
            this.lblVehicleWeaponDicePool.AutoSize = true;
            this.lblVehicleWeaponDicePool.Location = new System.Drawing.Point(109, 81);
            this.lblVehicleWeaponDicePool.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponDicePool.Name = "lblVehicleWeaponDicePool";
            this.lblVehicleWeaponDicePool.Size = new System.Drawing.Size(34, 13);
            this.lblVehicleWeaponDicePool.TabIndex = 240;
            this.lblVehicleWeaponDicePool.Text = "[Pool]";
            // 
            // lblVehicleWeaponRangeExtreme
            // 
            this.lblVehicleWeaponRangeExtreme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeExtreme.Location = new System.Drawing.Point(427, 31);
            this.lblVehicleWeaponRangeExtreme.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeExtreme.Name = "lblVehicleWeaponRangeExtreme";
            this.lblVehicleWeaponRangeExtreme.Size = new System.Drawing.Size(104, 13);
            this.lblVehicleWeaponRangeExtreme.TabIndex = 150;
            this.lblVehicleWeaponRangeExtreme.Text = "[0]";
            this.lblVehicleWeaponRangeExtreme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponAlternateRangeLong
            // 
            this.lblVehicleWeaponAlternateRangeLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAlternateRangeLong.Location = new System.Drawing.Point(321, 56);
            this.lblVehicleWeaponAlternateRangeLong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAlternateRangeLong.Name = "lblVehicleWeaponAlternateRangeLong";
            this.lblVehicleWeaponAlternateRangeLong.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponAlternateRangeLong.TabIndex = 235;
            this.lblVehicleWeaponAlternateRangeLong.Text = "[0]";
            this.lblVehicleWeaponAlternateRangeLong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeExtremeLabel
            // 
            this.lblVehicleWeaponRangeExtremeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeExtremeLabel.AutoSize = true;
            this.lblVehicleWeaponRangeExtremeLabel.Location = new System.Drawing.Point(427, 6);
            this.lblVehicleWeaponRangeExtremeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeExtremeLabel.Name = "lblVehicleWeaponRangeExtremeLabel";
            this.lblVehicleWeaponRangeExtremeLabel.Size = new System.Drawing.Size(104, 13);
            this.lblVehicleWeaponRangeExtremeLabel.TabIndex = 146;
            this.lblVehicleWeaponRangeExtremeLabel.Tag = "Label_RangeExtreme";
            this.lblVehicleWeaponRangeExtremeLabel.Text = "Extreme (-6)";
            this.lblVehicleWeaponRangeExtremeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeLabel
            // 
            this.lblVehicleWeaponRangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeLabel.AutoSize = true;
            this.lblVehicleWeaponRangeLabel.Location = new System.Drawing.Point(64, 6);
            this.lblVehicleWeaponRangeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeLabel.Name = "lblVehicleWeaponRangeLabel";
            this.lblVehicleWeaponRangeLabel.Size = new System.Drawing.Size(39, 13);
            this.lblVehicleWeaponRangeLabel.TabIndex = 142;
            this.lblVehicleWeaponRangeLabel.Tag = "Label_RangeHeading";
            this.lblVehicleWeaponRangeLabel.Text = "Range";
            // 
            // lblVehicleWeaponAlternateRangeMedium
            // 
            this.lblVehicleWeaponAlternateRangeMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAlternateRangeMedium.Location = new System.Drawing.Point(215, 56);
            this.lblVehicleWeaponAlternateRangeMedium.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAlternateRangeMedium.Name = "lblVehicleWeaponAlternateRangeMedium";
            this.lblVehicleWeaponAlternateRangeMedium.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponAlternateRangeMedium.TabIndex = 234;
            this.lblVehicleWeaponAlternateRangeMedium.Text = "[0]";
            this.lblVehicleWeaponAlternateRangeMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeLong
            // 
            this.lblVehicleWeaponRangeLong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeLong.Location = new System.Drawing.Point(321, 31);
            this.lblVehicleWeaponRangeLong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeLong.Name = "lblVehicleWeaponRangeLong";
            this.lblVehicleWeaponRangeLong.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeLong.TabIndex = 149;
            this.lblVehicleWeaponRangeLong.Text = "[0]";
            this.lblVehicleWeaponRangeLong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponDicePoolLabel
            // 
            this.lblVehicleWeaponDicePoolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponDicePoolLabel.AutoSize = true;
            this.lblVehicleWeaponDicePoolLabel.Location = new System.Drawing.Point(47, 81);
            this.lblVehicleWeaponDicePoolLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponDicePoolLabel.Name = "lblVehicleWeaponDicePoolLabel";
            this.lblVehicleWeaponDicePoolLabel.Size = new System.Drawing.Size(56, 13);
            this.lblVehicleWeaponDicePoolLabel.TabIndex = 239;
            this.lblVehicleWeaponDicePoolLabel.Tag = "Label_DicePool";
            this.lblVehicleWeaponDicePoolLabel.Text = "Dice Pool:";
            // 
            // lblVehicleWeaponAlternateRangeShort
            // 
            this.lblVehicleWeaponAlternateRangeShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponAlternateRangeShort.Location = new System.Drawing.Point(109, 56);
            this.lblVehicleWeaponAlternateRangeShort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponAlternateRangeShort.Name = "lblVehicleWeaponAlternateRangeShort";
            this.lblVehicleWeaponAlternateRangeShort.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponAlternateRangeShort.TabIndex = 233;
            this.lblVehicleWeaponAlternateRangeShort.Text = "[0]";
            this.lblVehicleWeaponAlternateRangeShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeLongLabel
            // 
            this.lblVehicleWeaponRangeLongLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeLongLabel.AutoSize = true;
            this.lblVehicleWeaponRangeLongLabel.Location = new System.Drawing.Point(321, 6);
            this.lblVehicleWeaponRangeLongLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeLongLabel.Name = "lblVehicleWeaponRangeLongLabel";
            this.lblVehicleWeaponRangeLongLabel.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeLongLabel.TabIndex = 145;
            this.lblVehicleWeaponRangeLongLabel.Tag = "Label_RangeLong";
            this.lblVehicleWeaponRangeLongLabel.Text = "Long (-3)";
            this.lblVehicleWeaponRangeLongLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeShortLabel
            // 
            this.lblVehicleWeaponRangeShortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeShortLabel.AutoSize = true;
            this.lblVehicleWeaponRangeShortLabel.Location = new System.Drawing.Point(109, 6);
            this.lblVehicleWeaponRangeShortLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeShortLabel.Name = "lblVehicleWeaponRangeShortLabel";
            this.lblVehicleWeaponRangeShortLabel.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeShortLabel.TabIndex = 143;
            this.lblVehicleWeaponRangeShortLabel.Tag = "Label_RangeShort";
            this.lblVehicleWeaponRangeShortLabel.Text = "Short (-0)";
            this.lblVehicleWeaponRangeShortLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeMedium
            // 
            this.lblVehicleWeaponRangeMedium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeMedium.Location = new System.Drawing.Point(215, 31);
            this.lblVehicleWeaponRangeMedium.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeMedium.Name = "lblVehicleWeaponRangeMedium";
            this.lblVehicleWeaponRangeMedium.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeMedium.TabIndex = 148;
            this.lblVehicleWeaponRangeMedium.Text = "[0]";
            this.lblVehicleWeaponRangeMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeAlternate
            // 
            this.lblVehicleWeaponRangeAlternate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeAlternate.AutoSize = true;
            this.lblVehicleWeaponRangeAlternate.Location = new System.Drawing.Point(13, 56);
            this.lblVehicleWeaponRangeAlternate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeAlternate.Name = "lblVehicleWeaponRangeAlternate";
            this.lblVehicleWeaponRangeAlternate.Size = new System.Drawing.Size(90, 13);
            this.lblVehicleWeaponRangeAlternate.TabIndex = 238;
            this.lblVehicleWeaponRangeAlternate.Tag = "";
            this.lblVehicleWeaponRangeAlternate.Text = "[Alternate Range]";
            // 
            // lblVehicleWeaponRangeMain
            // 
            this.lblVehicleWeaponRangeMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeMain.AutoSize = true;
            this.lblVehicleWeaponRangeMain.Location = new System.Drawing.Point(32, 31);
            this.lblVehicleWeaponRangeMain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeMain.Name = "lblVehicleWeaponRangeMain";
            this.lblVehicleWeaponRangeMain.Size = new System.Drawing.Size(71, 13);
            this.lblVehicleWeaponRangeMain.TabIndex = 237;
            this.lblVehicleWeaponRangeMain.Tag = "";
            this.lblVehicleWeaponRangeMain.Text = "[Main Range]";
            // 
            // lblVehicleWeaponRangeMediumLabel
            // 
            this.lblVehicleWeaponRangeMediumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeMediumLabel.AutoSize = true;
            this.lblVehicleWeaponRangeMediumLabel.Location = new System.Drawing.Point(215, 6);
            this.lblVehicleWeaponRangeMediumLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeMediumLabel.Name = "lblVehicleWeaponRangeMediumLabel";
            this.lblVehicleWeaponRangeMediumLabel.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeMediumLabel.TabIndex = 144;
            this.lblVehicleWeaponRangeMediumLabel.Tag = "Label_RangeMedium";
            this.lblVehicleWeaponRangeMediumLabel.Text = "Medium (-1)";
            this.lblVehicleWeaponRangeMediumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVehicleWeaponRangeShort
            // 
            this.lblVehicleWeaponRangeShort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehicleWeaponRangeShort.Location = new System.Drawing.Point(109, 31);
            this.lblVehicleWeaponRangeShort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblVehicleWeaponRangeShort.Name = "lblVehicleWeaponRangeShort";
            this.lblVehicleWeaponRangeShort.Size = new System.Drawing.Size(100, 13);
            this.lblVehicleWeaponRangeShort.TabIndex = 147;
            this.lblVehicleWeaponRangeShort.Text = "[0]";
            this.lblVehicleWeaponRangeShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabCharacterInfo
            // 
            this.tabCharacterInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabCharacterInfo.Controls.Add(this.tlpCharacterInfo);
            this.tabCharacterInfo.Location = new System.Drawing.Point(4, 22);
            this.tabCharacterInfo.Name = "tabCharacterInfo";
            this.tabCharacterInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharacterInfo.Size = new System.Drawing.Size(841, 631);
            this.tabCharacterInfo.TabIndex = 9;
            this.tabCharacterInfo.Tag = "Tab_CharacterInfo";
            this.tabCharacterInfo.Text = "Character Info";
            // 
            // tlpCharacterInfo
            // 
            this.tlpCharacterInfo.ColumnCount = 12;
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpCharacterInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCharacterInfo.Controls.Add(this.picMugshot, 8, 11);
            this.tlpCharacterInfo.Controls.Add(this.chkIsMainMugshot, 8, 10);
            this.tlpCharacterInfo.Controls.Add(this.cboPrimaryArm, 10, 2);
            this.tlpCharacterInfo.Controls.Add(this.lblNumMugshots, 11, 8);
            this.tlpCharacterInfo.Controls.Add(this.lblSex, 0, 0);
            this.tlpCharacterInfo.Controls.Add(this.nudMugshotIndex, 10, 8);
            this.tlpCharacterInfo.Controls.Add(this.lblHandedness, 8, 2);
            this.tlpCharacterInfo.Controls.Add(this.btnCreateBackstory, 9, 6);
            this.tlpCharacterInfo.Controls.Add(this.txtSex, 1, 0);
            this.tlpCharacterInfo.Controls.Add(this.txtNotes, 0, 15);
            this.tlpCharacterInfo.Controls.Add(this.lblPublicAwareTotal, 11, 5);
            this.tlpCharacterInfo.Controls.Add(this.lblNotes, 0, 14);
            this.tlpCharacterInfo.Controls.Add(this.lblAge, 2, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblNotorietyTotal, 11, 4);
            this.tlpCharacterInfo.Controls.Add(this.txtAge, 3, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblStreetCredTotal, 11, 3);
            this.tlpCharacterInfo.Controls.Add(this.txtConcept, 0, 13);
            this.tlpCharacterInfo.Controls.Add(this.lblEyes, 4, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblConcept, 0, 12);
            this.tlpCharacterInfo.Controls.Add(this.lblPublicAware, 8, 5);
            this.tlpCharacterInfo.Controls.Add(this.txtBackground, 0, 8);
            this.tlpCharacterInfo.Controls.Add(this.txtEyes, 5, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblBackground, 0, 7);
            this.tlpCharacterInfo.Controls.Add(this.lblNotoriety, 8, 4);
            this.tlpCharacterInfo.Controls.Add(this.lblHair, 6, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblStreetCred, 8, 3);
            this.tlpCharacterInfo.Controls.Add(this.txtHair, 7, 0);
            this.tlpCharacterInfo.Controls.Add(this.chkCharacterCreated, 9, 0);
            this.tlpCharacterInfo.Controls.Add(this.lblHeight, 0, 1);
            this.tlpCharacterInfo.Controls.Add(this.txtHeight, 1, 1);
            this.tlpCharacterInfo.Controls.Add(this.lblWeight, 2, 1);
            this.tlpCharacterInfo.Controls.Add(this.txtPlayerName, 10, 1);
            this.tlpCharacterInfo.Controls.Add(this.txtCharacterName, 7, 1);
            this.tlpCharacterInfo.Controls.Add(this.lblPlayerName, 9, 1);
            this.tlpCharacterInfo.Controls.Add(this.lblCharacterName, 6, 1);
            this.tlpCharacterInfo.Controls.Add(this.txtWeight, 3, 1);
            this.tlpCharacterInfo.Controls.Add(this.lblSkin, 4, 1);
            this.tlpCharacterInfo.Controls.Add(this.txtSkin, 5, 1);
            this.tlpCharacterInfo.Controls.Add(this.lblDescription, 0, 2);
            this.tlpCharacterInfo.Controls.Add(this.txtDescription, 0, 3);
            this.tlpCharacterInfo.Controls.Add(this.lblMugshot, 8, 8);
            this.tlpCharacterInfo.Controls.Add(this.flowLayoutPanel10, 8, 9);
            this.tlpCharacterInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharacterInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpCharacterInfo.Name = "tlpCharacterInfo";
            this.tlpCharacterInfo.RowCount = 16;
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCharacterInfo.Size = new System.Drawing.Size(835, 625);
            this.tlpCharacterInfo.TabIndex = 96;
            // 
            // picMugshot
            // 
            this.picMugshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.picMugshot, 4);
            this.picMugshot.Location = new System.Drawing.Point(634, 294);
            this.picMugshot.MinimumSize = new System.Drawing.Size(21, 31);
            this.picMugshot.Name = "picMugshot";
            this.tlpCharacterInfo.SetRowSpan(this.picMugshot, 5);
            this.picMugshot.Size = new System.Drawing.Size(198, 328);
            this.picMugshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMugshot.TabIndex = 20;
            this.picMugshot.TabStop = false;
            this.picMugshot.SizeChanged += new System.EventHandler(this.picMugshot_SizeChanged);
            // 
            // chkIsMainMugshot
            // 
            this.chkIsMainMugshot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsMainMugshot.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.chkIsMainMugshot, 4);
            this.chkIsMainMugshot.Location = new System.Drawing.Point(634, 270);
            this.chkIsMainMugshot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIsMainMugshot.Name = "chkIsMainMugshot";
            this.chkIsMainMugshot.Size = new System.Drawing.Size(198, 17);
            this.chkIsMainMugshot.TabIndex = 95;
            this.chkIsMainMugshot.Tag = "Checkbox_IsMainMugshot";
            this.chkIsMainMugshot.Text = "Is Main Mugshot";
            this.chkIsMainMugshot.UseVisualStyleBackColor = true;
            this.chkIsMainMugshot.CheckedChanged += new System.EventHandler(this.chkIsMainMugshot_CheckedChanged);
            // 
            // cboPrimaryArm
            // 
            this.cboPrimaryArm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.cboPrimaryArm, 2);
            this.cboPrimaryArm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimaryArm.FormattingEnabled = true;
            this.cboPrimaryArm.Location = new System.Drawing.Point(721, 55);
            this.cboPrimaryArm.Name = "cboPrimaryArm";
            this.cboPrimaryArm.Size = new System.Drawing.Size(111, 21);
            this.cboPrimaryArm.TabIndex = 93;
            this.cboPrimaryArm.TooltipText = "";
            this.cboPrimaryArm.SelectedIndexChanged += new System.EventHandler(this.cboPrimaryArm_SelectedIndexChanged);
            // 
            // lblNumMugshots
            // 
            this.lblNumMugshots.AutoSize = true;
            this.lblNumMugshots.Location = new System.Drawing.Point(775, 217);
            this.lblNumMugshots.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNumMugshots.Name = "lblNumMugshots";
            this.lblNumMugshots.Size = new System.Drawing.Size(21, 13);
            this.lblNumMugshots.TabIndex = 94;
            this.lblNumMugshots.Tag = "";
            this.lblNumMugshots.Text = "/ 0";
            // 
            // lblSex
            // 
            this.lblSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(23, 6);
            this.lblSex.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 0;
            this.lblSex.Tag = "Label_Sex";
            this.lblSex.Text = "Sex:";
            // 
            // nudMugshotIndex
            // 
            this.nudMugshotIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMugshotIndex.Location = new System.Drawing.Point(721, 214);
            this.nudMugshotIndex.Name = "nudMugshotIndex";
            this.nudMugshotIndex.Size = new System.Drawing.Size(48, 20);
            this.nudMugshotIndex.TabIndex = 93;
            this.nudMugshotIndex.ValueChanged += new System.EventHandler(this.nudMugshotIndex_ValueChanged);
            // 
            // lblHandedness
            // 
            this.lblHandedness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHandedness.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblHandedness, 2);
            this.lblHandedness.Location = new System.Drawing.Point(645, 58);
            this.lblHandedness.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHandedness.Name = "lblHandedness";
            this.lblHandedness.Size = new System.Drawing.Size(70, 13);
            this.lblHandedness.TabIndex = 92;
            this.lblHandedness.Tag = "Label_Handedness";
            this.lblHandedness.Text = "Handedness:";
            // 
            // btnCreateBackstory
            // 
            this.btnCreateBackstory.AutoSize = true;
            this.btnCreateBackstory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCharacterInfo.SetColumnSpan(this.btnCreateBackstory, 3);
            this.btnCreateBackstory.Location = new System.Drawing.Point(667, 157);
            this.btnCreateBackstory.Name = "btnCreateBackstory";
            this.btnCreateBackstory.Size = new System.Drawing.Size(98, 23);
            this.btnCreateBackstory.TabIndex = 91;
            this.btnCreateBackstory.Text = "Create Backstory";
            this.btnCreateBackstory.UseVisualStyleBackColor = true;
            this.btnCreateBackstory.Visible = false;
            this.btnCreateBackstory.Click += new System.EventHandler(this.btnCreateBackstory_Click);
            // 
            // txtSex
            // 
            this.txtSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSex.Location = new System.Drawing.Point(57, 3);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(106, 20);
            this.txtSex.TabIndex = 1;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtNotes, 8);
            this.txtNotes.Location = new System.Drawing.Point(3, 466);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(625, 156);
            this.txtNotes.TabIndex = 25;
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            // 
            // lblPublicAwareTotal
            // 
            this.lblPublicAwareTotal.AutoSize = true;
            this.lblPublicAwareTotal.Location = new System.Drawing.Point(775, 135);
            this.lblPublicAwareTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPublicAwareTotal.Name = "lblPublicAwareTotal";
            this.lblPublicAwareTotal.Size = new System.Drawing.Size(19, 13);
            this.lblPublicAwareTotal.TabIndex = 90;
            this.lblPublicAwareTotal.Tag = "Label_StreetCred";
            this.lblPublicAwareTotal.Text = "[0]";
            this.lblPublicAwareTotal.ToolTipText = "";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblNotes, 3);
            this.lblNotes.Location = new System.Drawing.Point(3, 444);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 24;
            this.lblNotes.Tag = "Label_Notes";
            this.lblNotes.Text = "Notes:";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(188, 6);
            this.lblAge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(29, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Tag = "Label_Age";
            this.lblAge.Text = "Age:";
            // 
            // lblNotorietyTotal
            // 
            this.lblNotorietyTotal.AutoSize = true;
            this.lblNotorietyTotal.Location = new System.Drawing.Point(775, 110);
            this.lblNotorietyTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotorietyTotal.Name = "lblNotorietyTotal";
            this.lblNotorietyTotal.Size = new System.Drawing.Size(19, 13);
            this.lblNotorietyTotal.TabIndex = 89;
            this.lblNotorietyTotal.Tag = "Label_StreetCred";
            this.lblNotorietyTotal.Text = "[0]";
            this.lblNotorietyTotal.ToolTipText = "";
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Location = new System.Drawing.Point(223, 3);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(106, 20);
            this.txtAge.TabIndex = 3;
            // 
            // lblStreetCredTotal
            // 
            this.lblStreetCredTotal.AutoSize = true;
            this.lblStreetCredTotal.Location = new System.Drawing.Point(775, 85);
            this.lblStreetCredTotal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblStreetCredTotal.Name = "lblStreetCredTotal";
            this.lblStreetCredTotal.Size = new System.Drawing.Size(19, 13);
            this.lblStreetCredTotal.TabIndex = 88;
            this.lblStreetCredTotal.Tag = "Label_StreetCred";
            this.lblStreetCredTotal.Text = "[0]";
            this.lblStreetCredTotal.ToolTipText = "";
            // 
            // txtConcept
            // 
            this.txtConcept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtConcept, 8);
            this.txtConcept.Location = new System.Drawing.Point(3, 341);
            this.txtConcept.Multiline = true;
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConcept.Size = new System.Drawing.Size(625, 94);
            this.txtConcept.TabIndex = 19;
            this.txtConcept.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            // 
            // lblEyes
            // 
            this.lblEyes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEyes.AutoSize = true;
            this.lblEyes.Location = new System.Drawing.Point(350, 6);
            this.lblEyes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEyes.Name = "lblEyes";
            this.lblEyes.Size = new System.Drawing.Size(33, 13);
            this.lblEyes.TabIndex = 4;
            this.lblEyes.Tag = "Label_Eyes";
            this.lblEyes.Text = "Eyes:";
            // 
            // lblConcept
            // 
            this.lblConcept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConcept.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblConcept, 3);
            this.lblConcept.Location = new System.Drawing.Point(3, 319);
            this.lblConcept.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblConcept.Name = "lblConcept";
            this.lblConcept.Size = new System.Drawing.Size(50, 13);
            this.lblConcept.TabIndex = 18;
            this.lblConcept.Tag = "Label_Concept";
            this.lblConcept.Text = "Concept:";
            // 
            // txtBackground
            // 
            this.txtBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtBackground, 8);
            this.txtBackground.Location = new System.Drawing.Point(3, 214);
            this.txtBackground.Multiline = true;
            this.txtBackground.Name = "txtBackground";
            this.tlpCharacterInfo.SetRowSpan(this.txtBackground, 4);
            this.txtBackground.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBackground.Size = new System.Drawing.Size(625, 96);
            this.txtBackground.TabIndex = 17;
            this.txtBackground.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            this.txtBackground.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBackground_KeyPress);
            // 
            // txtEyes
            // 
            this.txtEyes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEyes.Location = new System.Drawing.Point(389, 3);
            this.txtEyes.Name = "txtEyes";
            this.txtEyes.Size = new System.Drawing.Size(106, 20);
            this.txtEyes.TabIndex = 5;
            // 
            // lblBackground
            // 
            this.lblBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBackground.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblBackground, 3);
            this.lblBackground.Location = new System.Drawing.Point(3, 192);
            this.lblBackground.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBackground.Name = "lblBackground";
            this.lblBackground.Size = new System.Drawing.Size(68, 13);
            this.lblBackground.TabIndex = 16;
            this.lblBackground.Tag = "Label_Background";
            this.lblBackground.Text = "Background:";
            // 
            // lblHair
            // 
            this.lblHair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHair.AutoSize = true;
            this.lblHair.Location = new System.Drawing.Point(520, 6);
            this.lblHair.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHair.Name = "lblHair";
            this.lblHair.Size = new System.Drawing.Size(29, 13);
            this.lblHair.TabIndex = 6;
            this.lblHair.Tag = "Label_Hair";
            this.lblHair.Text = "Hair:";
            // 
            // txtHair
            // 
            this.txtHair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtHair, 2);
            this.txtHair.Location = new System.Drawing.Point(555, 3);
            this.txtHair.Name = "txtHair";
            this.txtHair.Size = new System.Drawing.Size(106, 20);
            this.txtHair.TabIndex = 7;
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(10, 32);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(41, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Tag = "Label_Height";
            this.lblHeight.Text = "Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeight.Location = new System.Drawing.Point(57, 29);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(106, 20);
            this.txtHeight.TabIndex = 9;
            // 
            // lblWeight
            // 
            this.lblWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(173, 32);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Tag = "Label_Weight";
            this.lblWeight.Text = "Weight:";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtPlayerName, 2);
            this.txtPlayerName.Location = new System.Drawing.Point(721, 29);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(111, 20);
            this.txtPlayerName.TabIndex = 64;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtCharacterName, 2);
            this.txtCharacterName.Location = new System.Drawing.Point(555, 29);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(106, 20);
            this.txtCharacterName.TabIndex = 66;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(676, 32);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(39, 13);
            this.lblPlayerName.TabIndex = 63;
            this.lblPlayerName.Tag = "Label_Player";
            this.lblPlayerName.Text = "Player:";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(511, 32);
            this.lblCharacterName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(38, 13);
            this.lblCharacterName.TabIndex = 65;
            this.lblCharacterName.Tag = "Label_CharacterName";
            this.lblCharacterName.Text = "Name:";
            // 
            // txtWeight
            // 
            this.txtWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeight.Location = new System.Drawing.Point(223, 29);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(106, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // lblSkin
            // 
            this.lblSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSkin.AutoSize = true;
            this.lblSkin.Location = new System.Drawing.Point(352, 32);
            this.lblSkin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(31, 13);
            this.lblSkin.TabIndex = 12;
            this.lblSkin.Tag = "Label_Skin";
            this.lblSkin.Text = "Skin:";
            // 
            // txtSkin
            // 
            this.txtSkin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkin.Location = new System.Drawing.Point(389, 29);
            this.txtSkin.Name = "txtSkin";
            this.txtSkin.Size = new System.Drawing.Size(106, 20);
            this.txtSkin.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescription.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblDescription, 3);
            this.lblDescription.Location = new System.Drawing.Point(3, 60);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Tag = "Label_Description";
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCharacterInfo.SetColumnSpan(this.txtDescription, 8);
            this.txtDescription.Location = new System.Drawing.Point(3, 82);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.tlpCharacterInfo.SetRowSpan(this.txtDescription, 4);
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(625, 101);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            // 
            // lblMugshot
            // 
            this.lblMugshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMugshot.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.lblMugshot, 2);
            this.lblMugshot.Location = new System.Drawing.Point(664, 217);
            this.lblMugshot.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMugshot.Name = "lblMugshot";
            this.lblMugshot.Size = new System.Drawing.Size(51, 13);
            this.lblMugshot.TabIndex = 21;
            this.lblMugshot.Tag = "Label_Mugshot";
            this.lblMugshot.Text = "Mugshot:";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel10.AutoSize = true;
            this.tlpCharacterInfo.SetColumnSpan(this.flowLayoutPanel10, 4);
            this.flowLayoutPanel10.Controls.Add(this.cmdAddMugshot);
            this.flowLayoutPanel10.Controls.Add(this.cmdDeleteMugshot);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(631, 237);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(204, 29);
            this.flowLayoutPanel10.TabIndex = 95;
            // 
            // cmdAddMugshot
            // 
            this.cmdAddMugshot.Location = new System.Drawing.Point(3, 3);
            this.cmdAddMugshot.Name = "cmdAddMugshot";
            this.cmdAddMugshot.Size = new System.Drawing.Size(75, 23);
            this.cmdAddMugshot.TabIndex = 22;
            this.cmdAddMugshot.Tag = "Button_AddMugshot";
            this.cmdAddMugshot.Text = "Add";
            this.cmdAddMugshot.UseVisualStyleBackColor = true;
            this.cmdAddMugshot.Click += new System.EventHandler(this.cmdAddMugshot_Click);
            // 
            // cmdDeleteMugshot
            // 
            this.cmdDeleteMugshot.Location = new System.Drawing.Point(84, 3);
            this.cmdDeleteMugshot.Name = "cmdDeleteMugshot";
            this.cmdDeleteMugshot.Size = new System.Drawing.Size(75, 23);
            this.cmdDeleteMugshot.TabIndex = 23;
            this.cmdDeleteMugshot.Tag = "String_Delete";
            this.cmdDeleteMugshot.Text = "Delete";
            this.cmdDeleteMugshot.UseVisualStyleBackColor = true;
            this.cmdDeleteMugshot.Click += new System.EventHandler(this.cmdDeleteMugshot_Click);
            // 
            // tabRelationships
            // 
            this.tabRelationships.Controls.Add(this.tabPeople);
            this.tabRelationships.Location = new System.Drawing.Point(4, 22);
            this.tabRelationships.Name = "tabRelationships";
            this.tabRelationships.Size = new System.Drawing.Size(841, 631);
            this.tabRelationships.TabIndex = 16;
            this.tabRelationships.Tag = "String_Relationships";
            this.tabRelationships.Text = "Relationships";
            this.tabRelationships.UseVisualStyleBackColor = true;
            // 
            // tabPeople
            // 
            this.tabPeople.Controls.Add(this.tabContacts);
            this.tabPeople.Controls.Add(this.tabEnemies);
            this.tabPeople.Controls.Add(this.tabPets);
            this.tabPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPeople.Location = new System.Drawing.Point(0, 0);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.SelectedIndex = 0;
            this.tabPeople.Size = new System.Drawing.Size(841, 631);
            this.tabPeople.TabIndex = 94;
            // 
            // tabContacts
            // 
            this.tabContacts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabContacts.Controls.Add(this.tlpContacts);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(833, 605);
            this.tabContacts.TabIndex = 0;
            this.tabContacts.Tag = "Label_Contacts";
            this.tabContacts.Text = "Contacts";
            // 
            // tlpContacts
            // 
            this.tlpContacts.ColumnCount = 4;
            this.tlpContacts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpContacts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpContacts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpContacts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContacts.Controls.Add(this.panContacts, 0, 2);
            this.tlpContacts.Controls.Add(this.lblContactArchtypeLabel, 3, 1);
            this.tlpContacts.Controls.Add(this.flowLayoutPanel9, 0, 0);
            this.tlpContacts.Controls.Add(this.lblContactLocationLabel, 2, 1);
            this.tlpContacts.Controls.Add(this.lblContactNameLabel, 1, 1);
            this.tlpContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContacts.Location = new System.Drawing.Point(3, 3);
            this.tlpContacts.Name = "tlpContacts";
            this.tlpContacts.RowCount = 3;
            this.tlpContacts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContacts.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContacts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpContacts.Size = new System.Drawing.Size(827, 599);
            this.tlpContacts.TabIndex = 52;
            // 
            // panContacts
            // 
            this.panContacts.AllowDrop = true;
            this.panContacts.AutoScroll = true;
            this.tlpContacts.SetColumnSpan(this.panContacts, 4);
            this.panContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContacts.Location = new System.Drawing.Point(3, 51);
            this.panContacts.Name = "panContacts";
            this.panContacts.Size = new System.Drawing.Size(821, 545);
            this.panContacts.TabIndex = 25;
            this.panContacts.Click += new System.EventHandler(this.panContacts_Click);
            this.panContacts.DragDrop += new System.Windows.Forms.DragEventHandler(this.panContacts_DragDrop);
            this.panContacts.DragEnter += new System.Windows.Forms.DragEventHandler(this.panContacts_DragEnter);
            this.panContacts.DragOver += new System.Windows.Forms.DragEventHandler(this.panContacts_DragOver);
            // 
            // lblContactArchtypeLabel
            // 
            this.lblContactArchtypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContactArchtypeLabel.AutoSize = true;
            this.lblContactArchtypeLabel.Location = new System.Drawing.Point(287, 32);
            this.lblContactArchtypeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lblContactArchtypeLabel.Name = "lblContactArchtypeLabel";
            this.lblContactArchtypeLabel.Size = new System.Drawing.Size(52, 13);
            this.lblContactArchtypeLabel.TabIndex = 44;
            this.lblContactArchtypeLabel.Tag = "Label_Archtype";
            this.lblContactArchtypeLabel.Text = "Archtype:";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContacts.SetColumnSpan(this.flowLayoutPanel9, 4);
            this.flowLayoutPanel9.Controls.Add(this.cmdAddContact);
            this.flowLayoutPanel9.Controls.Add(this.cmdContactsExpansionToggle);
            this.flowLayoutPanel9.Controls.Add(this.cmdSwapContactOrder);
            this.flowLayoutPanel9.Controls.Add(this.lblContactPoints_Label);
            this.flowLayoutPanel9.Controls.Add(this.lblContactPoints);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(498, 29);
            this.flowLayoutPanel9.TabIndex = 51;
            // 
            // cmdAddContact
            // 
            this.cmdAddContact.AutoSize = true;
            this.cmdAddContact.ContextMenuStrip = this.cmsAddContact;
            this.cmdAddContact.Location = new System.Drawing.Point(3, 3);
            this.cmdAddContact.Name = "cmdAddContact";
            this.cmdAddContact.Size = new System.Drawing.Size(94, 23);
            this.cmdAddContact.SplitMenuStrip = this.cmsAddContact;
            this.cmdAddContact.TabIndex = 24;
            this.cmdAddContact.Tag = "Button_AddContact";
            this.cmdAddContact.Text = "&Add Contact";
            this.cmdAddContact.UseVisualStyleBackColor = true;
            this.cmdAddContact.Click += new System.EventHandler(this.cmdAddContact_Click);
            // 
            // cmsAddContact
            // 
            this.cmsAddContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddFromFile});
            this.cmsAddContact.Name = "cmsAddContact";
            this.cmsAddContact.Size = new System.Drawing.Size(149, 26);
            // 
            // tsAddFromFile
            // 
            this.tsAddFromFile.Name = "tsAddFromFile";
            this.tsAddFromFile.Size = new System.Drawing.Size(148, 22);
            this.tsAddFromFile.Tag = "Menu_AddFromFile";
            this.tsAddFromFile.Text = "&Add From File";
            this.tsAddFromFile.Click += new System.EventHandler(this.tsAddFromFile_Click);
            // 
            // cmdContactsExpansionToggle
            // 
            this.cmdContactsExpansionToggle.AutoSize = true;
            this.cmdContactsExpansionToggle.Location = new System.Drawing.Point(103, 3);
            this.cmdContactsExpansionToggle.Name = "cmdContactsExpansionToggle";
            this.cmdContactsExpansionToggle.Size = new System.Drawing.Size(112, 23);
            this.cmdContactsExpansionToggle.TabIndex = 49;
            this.cmdContactsExpansionToggle.Tag = "Button_ContactsExpansionToggle";
            this.cmdContactsExpansionToggle.Text = "&Expand/Collapse All";
            this.cmdContactsExpansionToggle.UseVisualStyleBackColor = true;
            this.cmdContactsExpansionToggle.Click += new System.EventHandler(this.cmdContactsExpansionToggle_Click);
            // 
            // cmdSwapContactOrder
            // 
            this.cmdSwapContactOrder.AutoSize = true;
            this.cmdSwapContactOrder.Location = new System.Drawing.Point(221, 3);
            this.cmdSwapContactOrder.Name = "cmdSwapContactOrder";
            this.cmdSwapContactOrder.Size = new System.Drawing.Size(87, 23);
            this.cmdSwapContactOrder.TabIndex = 50;
            this.cmdSwapContactOrder.Tag = "Button_SwapOrdering";
            this.cmdSwapContactOrder.Text = "&Swap Ordering";
            this.cmdSwapContactOrder.UseVisualStyleBackColor = true;
            this.cmdSwapContactOrder.Click += new System.EventHandler(this.cmdSwapContactOrder_Click);
            // 
            // lblContactPoints_Label
            // 
            this.lblContactPoints_Label.AutoSize = true;
            this.lblContactPoints_Label.Location = new System.Drawing.Point(314, 8);
            this.lblContactPoints_Label.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblContactPoints_Label.Name = "lblContactPoints_Label";
            this.lblContactPoints_Label.Size = new System.Drawing.Size(156, 13);
            this.lblContactPoints_Label.TabIndex = 47;
            this.lblContactPoints_Label.Tag = "Label_FreeContactPoints";
            this.lblContactPoints_Label.Text = "Free Contact Points Remaining:";
            // 
            // lblContactPoints
            // 
            this.lblContactPoints.AutoSize = true;
            this.lblContactPoints.Location = new System.Drawing.Point(476, 8);
            this.lblContactPoints.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.lblContactPoints.Name = "lblContactPoints";
            this.lblContactPoints.Size = new System.Drawing.Size(19, 13);
            this.lblContactPoints.TabIndex = 48;
            this.lblContactPoints.Text = "[0]";
            // 
            // lblContactLocationLabel
            // 
            this.lblContactLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContactLocationLabel.AutoSize = true;
            this.lblContactLocationLabel.Location = new System.Drawing.Point(159, 32);
            this.lblContactLocationLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lblContactLocationLabel.Name = "lblContactLocationLabel";
            this.lblContactLocationLabel.Size = new System.Drawing.Size(51, 13);
            this.lblContactLocationLabel.TabIndex = 43;
            this.lblContactLocationLabel.Tag = "Label_Location";
            this.lblContactLocationLabel.Text = "Location:";
            // 
            // lblContactNameLabel
            // 
            this.lblContactNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblContactNameLabel.AutoSize = true;
            this.lblContactNameLabel.Location = new System.Drawing.Point(31, 32);
            this.lblContactNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lblContactNameLabel.Name = "lblContactNameLabel";
            this.lblContactNameLabel.Size = new System.Drawing.Size(38, 13);
            this.lblContactNameLabel.TabIndex = 42;
            this.lblContactNameLabel.Tag = "Label_Name";
            this.lblContactNameLabel.Text = "Name:";
            // 
            // tabEnemies
            // 
            this.tabEnemies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabEnemies.Controls.Add(this.tlpEnemies);
            this.tabEnemies.Location = new System.Drawing.Point(4, 22);
            this.tabEnemies.Name = "tabEnemies";
            this.tabEnemies.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnemies.Size = new System.Drawing.Size(184, 48);
            this.tabEnemies.TabIndex = 1;
            this.tabEnemies.Tag = "Label_Enemies";
            this.tabEnemies.Text = "Enemies";
            // 
            // tlpEnemies
            // 
            this.tlpEnemies.ColumnCount = 3;
            this.tlpEnemies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpEnemies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpEnemies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEnemies.Controls.Add(this.panEnemies, 0, 2);
            this.tlpEnemies.Controls.Add(this.label6, 2, 1);
            this.tlpEnemies.Controls.Add(this.label15, 1, 1);
            this.tlpEnemies.Controls.Add(this.label16, 0, 1);
            this.tlpEnemies.Controls.Add(this.flowLayoutPanel16, 0, 0);
            this.tlpEnemies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEnemies.Location = new System.Drawing.Point(3, 3);
            this.tlpEnemies.Name = "tlpEnemies";
            this.tlpEnemies.RowCount = 3;
            this.tlpEnemies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEnemies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEnemies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpEnemies.Size = new System.Drawing.Size(178, 42);
            this.tlpEnemies.TabIndex = 50;
            // 
            // panEnemies
            // 
            this.panEnemies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panEnemies.AutoScroll = true;
            this.tlpEnemies.SetColumnSpan(this.panEnemies, 3);
            this.panEnemies.Location = new System.Drawing.Point(3, 51);
            this.panEnemies.Name = "panEnemies";
            this.panEnemies.Size = new System.Drawing.Size(172, 548);
            this.panEnemies.TabIndex = 41;
            this.panEnemies.Click += new System.EventHandler(this.panEnemies_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 13);
            this.label6.TabIndex = 49;
            this.label6.Tag = "Label_Archtype";
            this.label6.Text = "Archtype:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(131, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 48;
            this.label15.Tag = "Label_Location";
            this.label15.Text = "Location:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 47;
            this.label16.Tag = "Label_Name";
            this.label16.Text = "Name:";
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.AutoSize = true;
            this.tlpEnemies.SetColumnSpan(this.flowLayoutPanel16, 2);
            this.flowLayoutPanel16.Controls.Add(this.cmdAddEnemy);
            this.flowLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(95, 29);
            this.flowLayoutPanel16.TabIndex = 50;
            // 
            // cmdAddEnemy
            // 
            this.cmdAddEnemy.AutoSize = true;
            this.cmdAddEnemy.ContextMenuStrip = this.cmsAddContact;
            this.cmdAddEnemy.Location = new System.Drawing.Point(3, 3);
            this.cmdAddEnemy.Name = "cmdAddEnemy";
            this.cmdAddEnemy.Size = new System.Drawing.Size(89, 23);
            this.cmdAddEnemy.SplitMenuStrip = this.cmsAddContact;
            this.cmdAddEnemy.TabIndex = 40;
            this.cmdAddEnemy.Tag = "Button_AddEnemy";
            this.cmdAddEnemy.Text = "A&dd Enemy";
            this.cmdAddEnemy.UseVisualStyleBackColor = true;
            this.cmdAddEnemy.Click += new System.EventHandler(this.cmdAddEnemy_Click);
            // 
            // tabPets
            // 
            this.tabPets.BackColor = System.Drawing.SystemColors.Control;
            this.tabPets.Controls.Add(this.tlpPets);
            this.tabPets.Location = new System.Drawing.Point(4, 22);
            this.tabPets.Name = "tabPets";
            this.tabPets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPets.Size = new System.Drawing.Size(184, 48);
            this.tabPets.TabIndex = 4;
            this.tabPets.Tag = "Tab_Pets";
            this.tabPets.Text = "Pets and Cohorts";
            // 
            // tlpPets
            // 
            this.tlpPets.ColumnCount = 1;
            this.tlpPets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPets.Controls.Add(this.panPets, 0, 1);
            this.tlpPets.Controls.Add(this.flowLayoutPanel17, 0, 0);
            this.tlpPets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPets.Location = new System.Drawing.Point(3, 3);
            this.tlpPets.Name = "tlpPets";
            this.tlpPets.RowCount = 2;
            this.tlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPets.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPets.Size = new System.Drawing.Size(178, 42);
            this.tlpPets.TabIndex = 25;
            // 
            // panPets
            // 
            this.panPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPets.AutoScroll = true;
            this.panPets.Location = new System.Drawing.Point(0, 29);
            this.panPets.Margin = new System.Windows.Forms.Padding(0);
            this.panPets.Name = "panPets";
            this.panPets.Size = new System.Drawing.Size(178, 573);
            this.panPets.TabIndex = 24;
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.AutoSize = true;
            this.flowLayoutPanel17.Controls.Add(this.cmdAddPet);
            this.flowLayoutPanel17.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(79, 29);
            this.flowLayoutPanel17.TabIndex = 25;
            // 
            // cmdAddPet
            // 
            this.cmdAddPet.AutoSize = true;
            this.cmdAddPet.ContextMenuStrip = this.cmsAddContact;
            this.cmdAddPet.Location = new System.Drawing.Point(3, 3);
            this.cmdAddPet.Name = "cmdAddPet";
            this.cmdAddPet.Size = new System.Drawing.Size(73, 23);
            this.cmdAddPet.SplitMenuStrip = this.cmsAddContact;
            this.cmdAddPet.TabIndex = 23;
            this.cmdAddPet.Tag = "Button_AddPet";
            this.cmdAddPet.Text = "&Add Pet";
            this.cmdAddPet.UseVisualStyleBackColor = true;
            this.cmdAddPet.Click += new System.EventHandler(this.cmdAddPet_Click);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabBPSummary);
            this.tabInfo.Controls.Add(this.tabOtherInfo);
            this.tabInfo.Controls.Add(this.tabDefences);
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(0, 0);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(232, 657);
            this.tabInfo.TabIndex = 50;
            // 
            // tabBPSummary
            // 
            this.tabBPSummary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabBPSummary.Controls.Add(this.tlpKarmaSummary);
            this.tabBPSummary.Location = new System.Drawing.Point(4, 22);
            this.tabBPSummary.Name = "tabBPSummary";
            this.tabBPSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabBPSummary.Size = new System.Drawing.Size(224, 631);
            this.tabBPSummary.TabIndex = 0;
            this.tabBPSummary.Tag = "Tab_BPSummary";
            this.tabBPSummary.Text = "Karma Summary";
            // 
            // tlpKarmaSummary
            // 
            this.tlpKarmaSummary.AutoSize = true;
            this.tlpKarmaSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpKarmaSummary.ColumnCount = 2;
            this.tlpKarmaSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpKarmaSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpKarmaSummary.Controls.Add(this.lblAINormalProgramsBP, 1, 20);
            this.tlpKarmaSummary.Controls.Add(this.lblAIAdvancedProgramsBP, 1, 21);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildAIAdvancedPrograms, 0, 21);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildRitualsBP, 1, 13);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildAINormalPrograms, 0, 20);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildRitualsBPLabel, 0, 13);
            this.tlpKarmaSummary.Controls.Add(this.lblPBuildSpecial, 1, 2);
            this.tlpKarmaSummary.Controls.Add(this.lblSummaryMetatype, 0, 0);
            this.tlpKarmaSummary.Controls.Add(this.lblInitiationBP, 1, 18);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildMartialArts, 0, 19);
            this.tlpKarmaSummary.Controls.Add(this.lblMartialArtsBP, 1, 19);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildPrepsBP, 1, 12);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildInitiation, 0, 18);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildPrepsBPLabel, 0, 12);
            this.tlpKarmaSummary.Controls.Add(this.lblFociBP, 1, 14);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildFoci, 0, 14);
            this.tlpKarmaSummary.Controls.Add(this.lblComplexFormsBP, 1, 17);
            this.tlpKarmaSummary.Controls.Add(this.lblPBuildSpecialLabel, 0, 2);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildComplexForms, 0, 17);
            this.tlpKarmaSummary.Controls.Add(this.lblKarmaMetatypeBP, 1, 0);
            this.tlpKarmaSummary.Controls.Add(this.lblSpritesBP, 1, 16);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildSprites, 0, 16);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildPrimaryAttributes, 0, 1);
            this.tlpKarmaSummary.Controls.Add(this.lblSpiritsBP, 1, 15);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildSpirits, 0, 15);
            this.tlpKarmaSummary.Controls.Add(this.lblAttributesBP, 1, 1);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildPositiveQualities, 0, 3);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildNegativeQualities, 0, 4);
            this.tlpKarmaSummary.Controls.Add(this.lblPositiveQualitiesBP, 1, 3);
            this.tlpKarmaSummary.Controls.Add(this.lblNegativeQualitiesBP, 1, 4);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildContacts, 0, 5);
            this.tlpKarmaSummary.Controls.Add(this.lblContactsBP, 1, 5);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildEnemies, 0, 6);
            this.tlpKarmaSummary.Controls.Add(this.lblEnemiesBP, 1, 6);
            this.tlpKarmaSummary.Controls.Add(this.lblNuyenBP, 1, 7);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildNuyen, 0, 7);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildSkillGroups, 0, 8);
            this.tlpKarmaSummary.Controls.Add(this.lblSkillGroupsBP, 1, 8);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildActiveSkills, 0, 9);
            this.tlpKarmaSummary.Controls.Add(this.lblActiveSkillsBP, 1, 9);
            this.tlpKarmaSummary.Controls.Add(this.lblSpellsBP, 1, 11);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildSpells, 0, 11);
            this.tlpKarmaSummary.Controls.Add(this.lblBuildKnowledgeSkills, 0, 10);
            this.tlpKarmaSummary.Controls.Add(this.lblKnowledgeSkillsBP, 1, 10);
            this.tlpKarmaSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKarmaSummary.Location = new System.Drawing.Point(3, 3);
            this.tlpKarmaSummary.Margin = new System.Windows.Forms.Padding(0);
            this.tlpKarmaSummary.Name = "tlpKarmaSummary";
            this.tlpKarmaSummary.RowCount = 22;
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpKarmaSummary.Size = new System.Drawing.Size(218, 625);
            this.tlpKarmaSummary.TabIndex = 99;
            // 
            // lblAINormalProgramsBP
            // 
            this.lblAINormalProgramsBP.AutoSize = true;
            this.lblAINormalProgramsBP.Location = new System.Drawing.Point(133, 506);
            this.lblAINormalProgramsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAINormalProgramsBP.Name = "lblAINormalProgramsBP";
            this.lblAINormalProgramsBP.Size = new System.Drawing.Size(30, 13);
            this.lblAINormalProgramsBP.TabIndex = 88;
            this.lblAINormalProgramsBP.Text = "0 BP";
            // 
            // lblAIAdvancedProgramsBP
            // 
            this.lblAIAdvancedProgramsBP.AutoSize = true;
            this.lblAIAdvancedProgramsBP.Location = new System.Drawing.Point(133, 531);
            this.lblAIAdvancedProgramsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAIAdvancedProgramsBP.Name = "lblAIAdvancedProgramsBP";
            this.lblAIAdvancedProgramsBP.Size = new System.Drawing.Size(30, 13);
            this.lblAIAdvancedProgramsBP.TabIndex = 86;
            this.lblAIAdvancedProgramsBP.Text = "0 BP";
            // 
            // lblBuildRitualsBP
            // 
            this.lblBuildRitualsBP.AutoSize = true;
            this.lblBuildRitualsBP.Location = new System.Drawing.Point(133, 331);
            this.lblBuildRitualsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildRitualsBP.Name = "lblBuildRitualsBP";
            this.lblBuildRitualsBP.Size = new System.Drawing.Size(30, 13);
            this.lblBuildRitualsBP.TabIndex = 132;
            this.lblBuildRitualsBP.Text = "0 BP";
            // 
            // lblBuildAINormalPrograms
            // 
            this.lblBuildAINormalPrograms.AutoSize = true;
            this.lblBuildAINormalPrograms.Location = new System.Drawing.Point(3, 506);
            this.lblBuildAINormalPrograms.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildAINormalPrograms.Name = "lblBuildAINormalPrograms";
            this.lblBuildAINormalPrograms.Size = new System.Drawing.Size(87, 13);
            this.lblBuildAINormalPrograms.TabIndex = 89;
            this.lblBuildAINormalPrograms.Tag = "Label_SummaryAINormalPrograms";
            this.lblBuildAINormalPrograms.Text = "Normal Programs";
            // 
            // lblPBuildSpecial
            // 
            this.lblPBuildSpecial.AutoSize = true;
            this.lblPBuildSpecial.Location = new System.Drawing.Point(133, 56);
            this.lblPBuildSpecial.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPBuildSpecial.Name = "lblPBuildSpecial";
            this.lblPBuildSpecial.Size = new System.Drawing.Size(34, 13);
            this.lblPBuildSpecial.TabIndex = 135;
            this.lblPBuildSpecial.Text = "0 of 0";
            // 
            // lblSummaryMetatype
            // 
            this.lblSummaryMetatype.AutoSize = true;
            this.lblSummaryMetatype.Location = new System.Drawing.Point(3, 6);
            this.lblSummaryMetatype.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSummaryMetatype.Name = "lblSummaryMetatype";
            this.lblSummaryMetatype.Size = new System.Drawing.Size(51, 13);
            this.lblSummaryMetatype.TabIndex = 73;
            this.lblSummaryMetatype.Tag = "Label_SummaryMetatype";
            this.lblSummaryMetatype.Text = "Metatype";
            // 
            // lblInitiationBP
            // 
            this.lblInitiationBP.AutoSize = true;
            this.lblInitiationBP.Location = new System.Drawing.Point(133, 456);
            this.lblInitiationBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblInitiationBP.Name = "lblInitiationBP";
            this.lblInitiationBP.Size = new System.Drawing.Size(30, 13);
            this.lblInitiationBP.TabIndex = 82;
            this.lblInitiationBP.Text = "0 BP";
            // 
            // lblMartialArtsBP
            // 
            this.lblMartialArtsBP.AutoSize = true;
            this.lblMartialArtsBP.Location = new System.Drawing.Point(133, 481);
            this.lblMartialArtsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMartialArtsBP.Name = "lblMartialArtsBP";
            this.lblMartialArtsBP.Size = new System.Drawing.Size(30, 13);
            this.lblMartialArtsBP.TabIndex = 82;
            this.lblMartialArtsBP.Text = "0 BP";
            // 
            // lblBuildPrepsBP
            // 
            this.lblBuildPrepsBP.AutoSize = true;
            this.lblBuildPrepsBP.Location = new System.Drawing.Point(133, 306);
            this.lblBuildPrepsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildPrepsBP.Name = "lblBuildPrepsBP";
            this.lblBuildPrepsBP.Size = new System.Drawing.Size(30, 13);
            this.lblBuildPrepsBP.TabIndex = 130;
            this.lblBuildPrepsBP.Text = "0 BP";
            // 
            // lblBuildInitiation
            // 
            this.lblBuildInitiation.AutoSize = true;
            this.lblBuildInitiation.Location = new System.Drawing.Point(3, 456);
            this.lblBuildInitiation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBuildInitiation.Name = "lblBuildInitiation";
            this.lblBuildInitiation.Size = new System.Drawing.Size(106, 13);
            this.lblBuildInitiation.TabIndex = 83;
            this.lblBuildInitiation.Tag = "Label_SummaryInitiation";
            this.lblBuildInitiation.Text = "Initiation/Submersion";
            // 
            // lblFociBP
            // 
            this.lblFociBP.AutoSize = true;
            this.lblFociBP.Location = new System.Drawing.Point(133, 356);
            this.lblFociBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFociBP.Name = "lblFociBP";
            this.lblFociBP.Size = new System.Drawing.Size(30, 13);
            this.lblFociBP.TabIndex = 80;
            this.lblFociBP.Text = "0 BP";
            // 
            // lblComplexFormsBP
            // 
            this.lblComplexFormsBP.AutoSize = true;
            this.lblComplexFormsBP.Location = new System.Drawing.Point(133, 431);
            this.lblComplexFormsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComplexFormsBP.Name = "lblComplexFormsBP";
            this.lblComplexFormsBP.Size = new System.Drawing.Size(30, 13);
            this.lblComplexFormsBP.TabIndex = 61;
            this.lblComplexFormsBP.Text = "0 BP";
            // 
            // lblPBuildSpecialLabel
            // 
            this.lblPBuildSpecialLabel.AutoSize = true;
            this.lblPBuildSpecialLabel.Location = new System.Drawing.Point(3, 56);
            this.lblPBuildSpecialLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPBuildSpecialLabel.Name = "lblPBuildSpecialLabel";
            this.lblPBuildSpecialLabel.Size = new System.Drawing.Size(89, 13);
            this.lblPBuildSpecialLabel.TabIndex = 134;
            this.lblPBuildSpecialLabel.Tag = "String_Special";
            this.lblPBuildSpecialLabel.Text = "Special Attributes";
            // 
            // lblKarmaMetatypeBP
            // 
            this.lblKarmaMetatypeBP.AutoSize = true;
            this.lblKarmaMetatypeBP.Location = new System.Drawing.Point(133, 6);
            this.lblKarmaMetatypeBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblKarmaMetatypeBP.Name = "lblKarmaMetatypeBP";
            this.lblKarmaMetatypeBP.Size = new System.Drawing.Size(30, 13);
            this.lblKarmaMetatypeBP.TabIndex = 74;
            this.lblKarmaMetatypeBP.Text = "0 BP";
            // 
            // lblSpritesBP
            // 
            this.lblSpritesBP.AutoSize = true;
            this.lblSpritesBP.Location = new System.Drawing.Point(133, 406);
            this.lblSpritesBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpritesBP.Name = "lblSpritesBP";
            this.lblSpritesBP.Size = new System.Drawing.Size(30, 13);
            this.lblSpritesBP.TabIndex = 58;
            this.lblSpritesBP.Text = "0 BP";
            // 
            // lblSpiritsBP
            // 
            this.lblSpiritsBP.AutoSize = true;
            this.lblSpiritsBP.Location = new System.Drawing.Point(133, 381);
            this.lblSpiritsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpiritsBP.Name = "lblSpiritsBP";
            this.lblSpiritsBP.Size = new System.Drawing.Size(30, 13);
            this.lblSpiritsBP.TabIndex = 52;
            this.lblSpiritsBP.Text = "0 BP";
            // 
            // lblAttributesBP
            // 
            this.lblAttributesBP.AutoSize = true;
            this.lblAttributesBP.Location = new System.Drawing.Point(133, 31);
            this.lblAttributesBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAttributesBP.Name = "lblAttributesBP";
            this.lblAttributesBP.Size = new System.Drawing.Size(30, 13);
            this.lblAttributesBP.TabIndex = 56;
            this.lblAttributesBP.Text = "0 BP";
            // 
            // lblPositiveQualitiesBP
            // 
            this.lblPositiveQualitiesBP.AutoSize = true;
            this.lblPositiveQualitiesBP.Location = new System.Drawing.Point(133, 81);
            this.lblPositiveQualitiesBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPositiveQualitiesBP.Name = "lblPositiveQualitiesBP";
            this.lblPositiveQualitiesBP.Size = new System.Drawing.Size(30, 13);
            this.lblPositiveQualitiesBP.TabIndex = 53;
            this.lblPositiveQualitiesBP.Text = "0 BP";
            // 
            // lblNegativeQualitiesBP
            // 
            this.lblNegativeQualitiesBP.AutoSize = true;
            this.lblNegativeQualitiesBP.Location = new System.Drawing.Point(133, 106);
            this.lblNegativeQualitiesBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNegativeQualitiesBP.Name = "lblNegativeQualitiesBP";
            this.lblNegativeQualitiesBP.Size = new System.Drawing.Size(30, 13);
            this.lblNegativeQualitiesBP.TabIndex = 55;
            this.lblNegativeQualitiesBP.Text = "0 BP";
            // 
            // lblContactsBP
            // 
            this.lblContactsBP.AutoSize = true;
            this.lblContactsBP.Location = new System.Drawing.Point(133, 131);
            this.lblContactsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblContactsBP.Name = "lblContactsBP";
            this.lblContactsBP.Size = new System.Drawing.Size(46, 13);
            this.lblContactsBP.TabIndex = 60;
            this.lblContactsBP.Text = "0 Karma";
            // 
            // lblEnemiesBP
            // 
            this.lblEnemiesBP.AutoSize = true;
            this.lblEnemiesBP.Location = new System.Drawing.Point(133, 156);
            this.lblEnemiesBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEnemiesBP.Name = "lblEnemiesBP";
            this.lblEnemiesBP.Size = new System.Drawing.Size(30, 13);
            this.lblEnemiesBP.TabIndex = 66;
            this.lblEnemiesBP.Text = "0 BP";
            // 
            // lblNuyenBP
            // 
            this.lblNuyenBP.AutoSize = true;
            this.lblNuyenBP.Location = new System.Drawing.Point(133, 181);
            this.lblNuyenBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNuyenBP.Name = "lblNuyenBP";
            this.lblNuyenBP.Size = new System.Drawing.Size(30, 13);
            this.lblNuyenBP.TabIndex = 77;
            this.lblNuyenBP.Text = "0 BP";
            // 
            // lblSkillGroupsBP
            // 
            this.lblSkillGroupsBP.AutoSize = true;
            this.lblSkillGroupsBP.Location = new System.Drawing.Point(133, 206);
            this.lblSkillGroupsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSkillGroupsBP.Name = "lblSkillGroupsBP";
            this.lblSkillGroupsBP.Size = new System.Drawing.Size(30, 13);
            this.lblSkillGroupsBP.TabIndex = 65;
            this.lblSkillGroupsBP.Text = "0 BP";
            // 
            // lblActiveSkillsBP
            // 
            this.lblActiveSkillsBP.AutoSize = true;
            this.lblActiveSkillsBP.Location = new System.Drawing.Point(133, 231);
            this.lblActiveSkillsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblActiveSkillsBP.Name = "lblActiveSkillsBP";
            this.lblActiveSkillsBP.Size = new System.Drawing.Size(30, 13);
            this.lblActiveSkillsBP.TabIndex = 67;
            this.lblActiveSkillsBP.Text = "0 BP";
            // 
            // lblSpellsBP
            // 
            this.lblSpellsBP.AutoSize = true;
            this.lblSpellsBP.Location = new System.Drawing.Point(133, 281);
            this.lblSpellsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellsBP.Name = "lblSpellsBP";
            this.lblSpellsBP.Size = new System.Drawing.Size(30, 13);
            this.lblSpellsBP.TabIndex = 51;
            this.lblSpellsBP.Text = "0 BP";
            // 
            // lblKnowledgeSkillsBP
            // 
            this.lblKnowledgeSkillsBP.AutoSize = true;
            this.lblKnowledgeSkillsBP.Location = new System.Drawing.Point(133, 256);
            this.lblKnowledgeSkillsBP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblKnowledgeSkillsBP.Name = "lblKnowledgeSkillsBP";
            this.lblKnowledgeSkillsBP.Size = new System.Drawing.Size(30, 13);
            this.lblKnowledgeSkillsBP.TabIndex = 68;
            this.lblKnowledgeSkillsBP.Text = "0 BP";
            // 
            // tabOtherInfo
            // 
            this.tabOtherInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabOtherInfo.Controls.Add(this.tlpOtherInfo);
            this.tabOtherInfo.Location = new System.Drawing.Point(4, 22);
            this.tabOtherInfo.Name = "tabOtherInfo";
            this.tabOtherInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherInfo.Size = new System.Drawing.Size(224, 631);
            this.tabOtherInfo.TabIndex = 1;
            this.tabOtherInfo.Tag = "Tab_OtherInfo";
            this.tabOtherInfo.Text = "Other Info";
            // 
            // tlpOtherInfo
            // 
            this.tlpOtherInfo.AutoSize = true;
            this.tlpOtherInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOtherInfo.ColumnCount = 2;
            this.tlpOtherInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpOtherInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOtherInfo.Controls.Add(this.lblFly, 1, 17);
            this.tlpOtherInfo.Controls.Add(this.lblRiggingINI, 1, 7);
            this.tlpOtherInfo.Controls.Add(this.lblFlyLabel, 0, 17);
            this.tlpOtherInfo.Controls.Add(this.lblCMPhysicalLabel, 0, 0);
            this.tlpOtherInfo.Controls.Add(this.lblSwim, 1, 16);
            this.tlpOtherInfo.Controls.Add(this.lblRiggingINILabel, 0, 7);
            this.tlpOtherInfo.Controls.Add(this.lblSwimLabel, 0, 16);
            this.tlpOtherInfo.Controls.Add(this.lblCMPhysical, 1, 0);
            this.tlpOtherInfo.Controls.Add(this.lblMovement, 1, 15);
            this.tlpOtherInfo.Controls.Add(this.lblMemory, 1, 14);
            this.tlpOtherInfo.Controls.Add(this.lblMovementLabel, 0, 15);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINIHot, 1, 6);
            this.tlpOtherInfo.Controls.Add(this.lblMemoryLabel, 0, 14);
            this.tlpOtherInfo.Controls.Add(this.lblCMStunLabel, 0, 1);
            this.tlpOtherInfo.Controls.Add(this.lblLiftCarry, 1, 13);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINICold, 1, 5);
            this.tlpOtherInfo.Controls.Add(this.lblLiftCarryLabel, 0, 13);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINIHotLabel, 0, 6);
            this.tlpOtherInfo.Controls.Add(this.lblJudgeIntentions, 1, 12);
            this.tlpOtherInfo.Controls.Add(this.lblCMStun, 1, 1);
            this.tlpOtherInfo.Controls.Add(this.lblJudgeIntentionsLabel, 0, 12);
            this.tlpOtherInfo.Controls.Add(this.lblINILabel, 0, 2);
            this.tlpOtherInfo.Controls.Add(this.lblComposure, 1, 11);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINIColdLabel, 0, 5);
            this.tlpOtherInfo.Controls.Add(this.lblComposureLabel, 0, 11);
            this.tlpOtherInfo.Controls.Add(this.lblINI, 1, 2);
            this.tlpOtherInfo.Controls.Add(this.lblAstralINILabel, 0, 3);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINILabel, 0, 4);
            this.tlpOtherInfo.Controls.Add(this.lblRemainingNuyen, 1, 10);
            this.tlpOtherInfo.Controls.Add(this.lblAstralINI, 1, 3);
            this.tlpOtherInfo.Controls.Add(this.lblRemainingNuyenLabel, 0, 10);
            this.tlpOtherInfo.Controls.Add(this.lblMatrixINI, 1, 4);
            this.tlpOtherInfo.Controls.Add(this.lblESSMax, 1, 9);
            this.tlpOtherInfo.Controls.Add(this.lblArmorLabel, 0, 8);
            this.tlpOtherInfo.Controls.Add(this.lblArmor, 1, 8);
            this.tlpOtherInfo.Controls.Add(this.lblESS, 0, 9);
            this.tlpOtherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOtherInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpOtherInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpOtherInfo.Name = "tlpOtherInfo";
            this.tlpOtherInfo.RowCount = 18;
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOtherInfo.Size = new System.Drawing.Size(218, 625);
            this.tlpOtherInfo.TabIndex = 99;
            // 
            // lblFly
            // 
            this.lblFly.AutoSize = true;
            this.lblFly.Location = new System.Drawing.Point(148, 431);
            this.lblFly.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFly.Name = "lblFly";
            this.lblFly.Size = new System.Drawing.Size(13, 13);
            this.lblFly.TabIndex = 55;
            this.lblFly.Text = "0";
            // 
            // lblRiggingINI
            // 
            this.lblRiggingINI.AutoSize = true;
            this.lblRiggingINI.Location = new System.Drawing.Point(148, 181);
            this.lblRiggingINI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRiggingINI.Name = "lblRiggingINI";
            this.lblRiggingINI.Size = new System.Drawing.Size(13, 13);
            this.lblRiggingINI.TabIndex = 76;
            this.lblRiggingINI.Text = "0";
            // 
            // lblFlyLabel
            // 
            this.lblFlyLabel.AutoSize = true;
            this.lblFlyLabel.Location = new System.Drawing.Point(3, 431);
            this.lblFlyLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFlyLabel.Name = "lblFlyLabel";
            this.lblFlyLabel.Size = new System.Drawing.Size(23, 13);
            this.lblFlyLabel.TabIndex = 54;
            this.lblFlyLabel.Tag = "Label_OtherFly";
            this.lblFlyLabel.Text = "Fly:";
            // 
            // lblSwim
            // 
            this.lblSwim.AutoSize = true;
            this.lblSwim.Location = new System.Drawing.Point(148, 406);
            this.lblSwim.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSwim.Name = "lblSwim";
            this.lblSwim.Size = new System.Drawing.Size(13, 13);
            this.lblSwim.TabIndex = 53;
            this.lblSwim.Text = "0";
            // 
            // lblSwimLabel
            // 
            this.lblSwimLabel.AutoSize = true;
            this.lblSwimLabel.Location = new System.Drawing.Point(3, 406);
            this.lblSwimLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSwimLabel.Name = "lblSwimLabel";
            this.lblSwimLabel.Size = new System.Drawing.Size(35, 13);
            this.lblSwimLabel.TabIndex = 52;
            this.lblSwimLabel.Tag = "Label_OtherSwim";
            this.lblSwimLabel.Text = "Swim:";
            // 
            // lblCMPhysical
            // 
            this.lblCMPhysical.AutoSize = true;
            this.lblCMPhysical.Location = new System.Drawing.Point(148, 6);
            this.lblCMPhysical.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCMPhysical.Name = "lblCMPhysical";
            this.lblCMPhysical.Size = new System.Drawing.Size(13, 13);
            this.lblCMPhysical.TabIndex = 24;
            this.lblCMPhysical.Text = "0";
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Location = new System.Drawing.Point(148, 381);
            this.lblMovement.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(13, 13);
            this.lblMovement.TabIndex = 43;
            this.lblMovement.Text = "0";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(148, 356);
            this.lblMemory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(13, 13);
            this.lblMemory.TabIndex = 51;
            this.lblMemory.Text = "0";
            this.lblMemory.ToolTipText = "";
            // 
            // lblMovementLabel
            // 
            this.lblMovementLabel.AutoSize = true;
            this.lblMovementLabel.Location = new System.Drawing.Point(3, 381);
            this.lblMovementLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMovementLabel.Name = "lblMovementLabel";
            this.lblMovementLabel.Size = new System.Drawing.Size(60, 13);
            this.lblMovementLabel.TabIndex = 42;
            this.lblMovementLabel.Tag = "Label_OtherMovement";
            this.lblMovementLabel.Text = "Movement:";
            // 
            // lblMatrixINIHot
            // 
            this.lblMatrixINIHot.AutoSize = true;
            this.lblMatrixINIHot.Location = new System.Drawing.Point(148, 156);
            this.lblMatrixINIHot.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINIHot.Name = "lblMatrixINIHot";
            this.lblMatrixINIHot.Size = new System.Drawing.Size(13, 13);
            this.lblMatrixINIHot.TabIndex = 74;
            this.lblMatrixINIHot.Text = "0";
            // 
            // lblLiftCarry
            // 
            this.lblLiftCarry.AutoSize = true;
            this.lblLiftCarry.Location = new System.Drawing.Point(148, 331);
            this.lblLiftCarry.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblLiftCarry.Name = "lblLiftCarry";
            this.lblLiftCarry.Size = new System.Drawing.Size(13, 13);
            this.lblLiftCarry.TabIndex = 49;
            this.lblLiftCarry.Text = "0";
            this.lblLiftCarry.ToolTipText = "";
            // 
            // lblMatrixINICold
            // 
            this.lblMatrixINICold.AutoSize = true;
            this.lblMatrixINICold.Location = new System.Drawing.Point(148, 131);
            this.lblMatrixINICold.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINICold.Name = "lblMatrixINICold";
            this.lblMatrixINICold.Size = new System.Drawing.Size(13, 13);
            this.lblMatrixINICold.TabIndex = 72;
            this.lblMatrixINICold.Text = "0";
            // 
            // lblJudgeIntentions
            // 
            this.lblJudgeIntentions.AutoSize = true;
            this.lblJudgeIntentions.Location = new System.Drawing.Point(148, 306);
            this.lblJudgeIntentions.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblJudgeIntentions.Name = "lblJudgeIntentions";
            this.lblJudgeIntentions.Size = new System.Drawing.Size(13, 13);
            this.lblJudgeIntentions.TabIndex = 47;
            this.lblJudgeIntentions.Text = "0";
            this.lblJudgeIntentions.ToolTipText = "";
            // 
            // lblCMStun
            // 
            this.lblCMStun.AutoSize = true;
            this.lblCMStun.Location = new System.Drawing.Point(148, 31);
            this.lblCMStun.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCMStun.Name = "lblCMStun";
            this.lblCMStun.Size = new System.Drawing.Size(13, 13);
            this.lblCMStun.TabIndex = 25;
            this.lblCMStun.Text = "0";
            // 
            // lblComposure
            // 
            this.lblComposure.AutoSize = true;
            this.lblComposure.Location = new System.Drawing.Point(148, 281);
            this.lblComposure.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblComposure.Name = "lblComposure";
            this.lblComposure.Size = new System.Drawing.Size(13, 13);
            this.lblComposure.TabIndex = 45;
            this.lblComposure.Text = "0";
            this.lblComposure.ToolTipText = "";
            // 
            // lblINI
            // 
            this.lblINI.AutoSize = true;
            this.lblINI.Location = new System.Drawing.Point(148, 56);
            this.lblINI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblINI.Name = "lblINI";
            this.lblINI.Size = new System.Drawing.Size(13, 13);
            this.lblINI.TabIndex = 26;
            this.lblINI.Text = "0";
            // 
            // lblRemainingNuyen
            // 
            this.lblRemainingNuyen.AutoSize = true;
            this.lblRemainingNuyen.Location = new System.Drawing.Point(148, 256);
            this.lblRemainingNuyen.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblRemainingNuyen.Name = "lblRemainingNuyen";
            this.lblRemainingNuyen.Size = new System.Drawing.Size(13, 13);
            this.lblRemainingNuyen.TabIndex = 37;
            this.lblRemainingNuyen.Text = "0";
            // 
            // lblAstralINI
            // 
            this.lblAstralINI.AutoSize = true;
            this.lblAstralINI.Location = new System.Drawing.Point(148, 81);
            this.lblAstralINI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAstralINI.Name = "lblAstralINI";
            this.lblAstralINI.Size = new System.Drawing.Size(13, 13);
            this.lblAstralINI.TabIndex = 29;
            this.lblAstralINI.Text = "0";
            // 
            // lblMatrixINI
            // 
            this.lblMatrixINI.AutoSize = true;
            this.lblMatrixINI.Location = new System.Drawing.Point(148, 106);
            this.lblMatrixINI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMatrixINI.Name = "lblMatrixINI";
            this.lblMatrixINI.Size = new System.Drawing.Size(13, 13);
            this.lblMatrixINI.TabIndex = 28;
            this.lblMatrixINI.Text = "0";
            // 
            // lblESSMax
            // 
            this.lblESSMax.AutoSize = true;
            this.lblESSMax.Location = new System.Drawing.Point(148, 231);
            this.lblESSMax.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblESSMax.Name = "lblESSMax";
            this.lblESSMax.Size = new System.Drawing.Size(13, 13);
            this.lblESSMax.TabIndex = 35;
            this.lblESSMax.Text = "0";
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Location = new System.Drawing.Point(148, 206);
            this.lblArmor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(13, 13);
            this.lblArmor.TabIndex = 31;
            this.lblArmor.Text = "0";
            this.lblArmor.ToolTipText = "";
            // 
            // tabDefences
            // 
            this.tabDefences.BackColor = System.Drawing.SystemColors.Control;
            this.tabDefences.Controls.Add(this.tlpSpellDefense);
            this.tabDefences.Location = new System.Drawing.Point(4, 22);
            this.tabDefences.Name = "tabDefences";
            this.tabDefences.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefences.Size = new System.Drawing.Size(224, 631);
            this.tabDefences.TabIndex = 3;
            this.tabDefences.Tag = "String_SpellDefense";
            this.tabDefences.Text = "Spell Defence";
            // 
            // tlpSpellDefense
            // 
            this.tlpSpellDefense.AutoSize = true;
            this.tlpSpellDefense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSpellDefense.ColumnCount = 2;
            this.tlpSpellDefense.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpSpellDefense.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceManipPhysical, 1, 17);
            this.tlpSpellDefense.Controls.Add(this.nudCounterspellingDice, 1, 0);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceManipMental, 1, 16);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceManipPhysicalLabel, 0, 17);
            this.tlpSpellDefense.Controls.Add(this.lblCounterspellingDiceLabel, 0, 0);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIndirectDodgeLabel, 0, 1);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceManipMentalLabel, 0, 16);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIndirectSoakLabel, 0, 2);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIllusionPhysical, 1, 15);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIndirectDodge, 1, 1);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIllusionMana, 1, 14);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIllusionPhysicalLabel, 0, 15);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIndirectSoak, 1, 2);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDirectSoakManaLabel, 0, 3);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceIllusionManaLabel, 0, 14);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDirectSoakPhysicalLabel, 0, 4);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttWIL, 1, 13);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDetectionLabel, 0, 5);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttLOG, 1, 12);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDirectSoakMana, 1, 3);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttWILLabel, 0, 13);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttINT, 1, 11);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttLOGLabel, 0, 12);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDirectSoakPhysical, 1, 4);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttCHA, 1, 10);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDetection, 1, 5);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttSTR, 1, 9);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttBOD, 1, 6);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttINTLabel, 0, 11);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttBODLabel, 0, 6);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttCHALabel, 0, 10);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttAGILabel, 0, 7);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttAGI, 1, 7);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttREALabel, 0, 8);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttSTRLabel, 0, 9);
            this.tlpSpellDefense.Controls.Add(this.lblSpellDefenceDecAttREA, 1, 8);
            this.tlpSpellDefense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSpellDefense.Location = new System.Drawing.Point(3, 3);
            this.tlpSpellDefense.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSpellDefense.Name = "tlpSpellDefense";
            this.tlpSpellDefense.RowCount = 18;
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSpellDefense.Size = new System.Drawing.Size(218, 625);
            this.tlpSpellDefense.TabIndex = 99;
            // 
            // lblSpellDefenceManipPhysical
            // 
            this.lblSpellDefenceManipPhysical.AutoSize = true;
            this.lblSpellDefenceManipPhysical.Location = new System.Drawing.Point(148, 432);
            this.lblSpellDefenceManipPhysical.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceManipPhysical.Name = "lblSpellDefenceManipPhysical";
            this.lblSpellDefenceManipPhysical.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceManipPhysical.TabIndex = 60;
            this.lblSpellDefenceManipPhysical.Text = "0";
            this.lblSpellDefenceManipPhysical.ToolTipText = "";
            // 
            // nudCounterspellingDice
            // 
            this.nudCounterspellingDice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCounterspellingDice.Location = new System.Drawing.Point(148, 3);
            this.nudCounterspellingDice.Name = "nudCounterspellingDice";
            this.nudCounterspellingDice.Size = new System.Drawing.Size(67, 20);
            this.nudCounterspellingDice.TabIndex = 61;
            // 
            // lblSpellDefenceManipMental
            // 
            this.lblSpellDefenceManipMental.AutoSize = true;
            this.lblSpellDefenceManipMental.Location = new System.Drawing.Point(148, 407);
            this.lblSpellDefenceManipMental.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceManipMental.Name = "lblSpellDefenceManipMental";
            this.lblSpellDefenceManipMental.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceManipMental.TabIndex = 58;
            this.lblSpellDefenceManipMental.Text = "0";
            this.lblSpellDefenceManipMental.ToolTipText = "";
            // 
            // lblSpellDefenceIllusionPhysical
            // 
            this.lblSpellDefenceIllusionPhysical.AutoSize = true;
            this.lblSpellDefenceIllusionPhysical.Location = new System.Drawing.Point(148, 382);
            this.lblSpellDefenceIllusionPhysical.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIllusionPhysical.Name = "lblSpellDefenceIllusionPhysical";
            this.lblSpellDefenceIllusionPhysical.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceIllusionPhysical.TabIndex = 56;
            this.lblSpellDefenceIllusionPhysical.Text = "0";
            this.lblSpellDefenceIllusionPhysical.ToolTipText = "";
            // 
            // lblSpellDefenceIndirectDodge
            // 
            this.lblSpellDefenceIndirectDodge.AutoSize = true;
            this.lblSpellDefenceIndirectDodge.Location = new System.Drawing.Point(148, 32);
            this.lblSpellDefenceIndirectDodge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIndirectDodge.Name = "lblSpellDefenceIndirectDodge";
            this.lblSpellDefenceIndirectDodge.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceIndirectDodge.TabIndex = 26;
            this.lblSpellDefenceIndirectDodge.Text = "0";
            this.lblSpellDefenceIndirectDodge.ToolTipText = "";
            // 
            // lblSpellDefenceIllusionMana
            // 
            this.lblSpellDefenceIllusionMana.AutoSize = true;
            this.lblSpellDefenceIllusionMana.Location = new System.Drawing.Point(148, 357);
            this.lblSpellDefenceIllusionMana.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIllusionMana.Name = "lblSpellDefenceIllusionMana";
            this.lblSpellDefenceIllusionMana.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceIllusionMana.TabIndex = 54;
            this.lblSpellDefenceIllusionMana.Text = "0";
            this.lblSpellDefenceIllusionMana.ToolTipText = "";
            // 
            // lblSpellDefenceIndirectSoak
            // 
            this.lblSpellDefenceIndirectSoak.AutoSize = true;
            this.lblSpellDefenceIndirectSoak.Location = new System.Drawing.Point(148, 57);
            this.lblSpellDefenceIndirectSoak.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceIndirectSoak.Name = "lblSpellDefenceIndirectSoak";
            this.lblSpellDefenceIndirectSoak.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceIndirectSoak.TabIndex = 28;
            this.lblSpellDefenceIndirectSoak.Text = "0";
            this.lblSpellDefenceIndirectSoak.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttWIL
            // 
            this.lblSpellDefenceDecAttWIL.AutoSize = true;
            this.lblSpellDefenceDecAttWIL.Location = new System.Drawing.Point(148, 332);
            this.lblSpellDefenceDecAttWIL.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttWIL.Name = "lblSpellDefenceDecAttWIL";
            this.lblSpellDefenceDecAttWIL.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttWIL.TabIndex = 52;
            this.lblSpellDefenceDecAttWIL.Text = "0";
            this.lblSpellDefenceDecAttWIL.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttLOG
            // 
            this.lblSpellDefenceDecAttLOG.AutoSize = true;
            this.lblSpellDefenceDecAttLOG.Location = new System.Drawing.Point(148, 307);
            this.lblSpellDefenceDecAttLOG.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttLOG.Name = "lblSpellDefenceDecAttLOG";
            this.lblSpellDefenceDecAttLOG.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttLOG.TabIndex = 51;
            this.lblSpellDefenceDecAttLOG.Text = "0";
            this.lblSpellDefenceDecAttLOG.ToolTipText = "";
            // 
            // lblSpellDefenceDirectSoakMana
            // 
            this.lblSpellDefenceDirectSoakMana.AutoSize = true;
            this.lblSpellDefenceDirectSoakMana.Location = new System.Drawing.Point(148, 82);
            this.lblSpellDefenceDirectSoakMana.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDirectSoakMana.Name = "lblSpellDefenceDirectSoakMana";
            this.lblSpellDefenceDirectSoakMana.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDirectSoakMana.TabIndex = 30;
            this.lblSpellDefenceDirectSoakMana.Text = "0";
            this.lblSpellDefenceDirectSoakMana.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttINT
            // 
            this.lblSpellDefenceDecAttINT.AutoSize = true;
            this.lblSpellDefenceDecAttINT.Location = new System.Drawing.Point(148, 282);
            this.lblSpellDefenceDecAttINT.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttINT.Name = "lblSpellDefenceDecAttINT";
            this.lblSpellDefenceDecAttINT.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttINT.TabIndex = 50;
            this.lblSpellDefenceDecAttINT.Text = "0";
            this.lblSpellDefenceDecAttINT.ToolTipText = "";
            // 
            // lblSpellDefenceDirectSoakPhysical
            // 
            this.lblSpellDefenceDirectSoakPhysical.AutoSize = true;
            this.lblSpellDefenceDirectSoakPhysical.Location = new System.Drawing.Point(148, 107);
            this.lblSpellDefenceDirectSoakPhysical.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDirectSoakPhysical.Name = "lblSpellDefenceDirectSoakPhysical";
            this.lblSpellDefenceDirectSoakPhysical.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDirectSoakPhysical.TabIndex = 32;
            this.lblSpellDefenceDirectSoakPhysical.Text = "0";
            this.lblSpellDefenceDirectSoakPhysical.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttCHA
            // 
            this.lblSpellDefenceDecAttCHA.AutoSize = true;
            this.lblSpellDefenceDecAttCHA.Location = new System.Drawing.Point(148, 257);
            this.lblSpellDefenceDecAttCHA.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttCHA.Name = "lblSpellDefenceDecAttCHA";
            this.lblSpellDefenceDecAttCHA.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttCHA.TabIndex = 49;
            this.lblSpellDefenceDecAttCHA.Text = "0";
            this.lblSpellDefenceDecAttCHA.ToolTipText = "";
            // 
            // lblSpellDefenceDetection
            // 
            this.lblSpellDefenceDetection.AutoSize = true;
            this.lblSpellDefenceDetection.Location = new System.Drawing.Point(148, 132);
            this.lblSpellDefenceDetection.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDetection.Name = "lblSpellDefenceDetection";
            this.lblSpellDefenceDetection.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDetection.TabIndex = 34;
            this.lblSpellDefenceDetection.Text = "0";
            this.lblSpellDefenceDetection.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttSTR
            // 
            this.lblSpellDefenceDecAttSTR.AutoSize = true;
            this.lblSpellDefenceDecAttSTR.Location = new System.Drawing.Point(148, 232);
            this.lblSpellDefenceDecAttSTR.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttSTR.Name = "lblSpellDefenceDecAttSTR";
            this.lblSpellDefenceDecAttSTR.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttSTR.TabIndex = 48;
            this.lblSpellDefenceDecAttSTR.Text = "0";
            this.lblSpellDefenceDecAttSTR.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttBOD
            // 
            this.lblSpellDefenceDecAttBOD.AutoSize = true;
            this.lblSpellDefenceDecAttBOD.Location = new System.Drawing.Point(148, 157);
            this.lblSpellDefenceDecAttBOD.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttBOD.Name = "lblSpellDefenceDecAttBOD";
            this.lblSpellDefenceDecAttBOD.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttBOD.TabIndex = 36;
            this.lblSpellDefenceDecAttBOD.Text = "0";
            this.lblSpellDefenceDecAttBOD.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttAGI
            // 
            this.lblSpellDefenceDecAttAGI.AutoSize = true;
            this.lblSpellDefenceDecAttAGI.Location = new System.Drawing.Point(148, 182);
            this.lblSpellDefenceDecAttAGI.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttAGI.Name = "lblSpellDefenceDecAttAGI";
            this.lblSpellDefenceDecAttAGI.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttAGI.TabIndex = 38;
            this.lblSpellDefenceDecAttAGI.Text = "0";
            this.lblSpellDefenceDecAttAGI.ToolTipText = "";
            // 
            // lblSpellDefenceDecAttREA
            // 
            this.lblSpellDefenceDecAttREA.AutoSize = true;
            this.lblSpellDefenceDecAttREA.Location = new System.Drawing.Point(148, 207);
            this.lblSpellDefenceDecAttREA.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpellDefenceDecAttREA.Name = "lblSpellDefenceDecAttREA";
            this.lblSpellDefenceDecAttREA.Size = new System.Drawing.Size(13, 13);
            this.lblSpellDefenceDecAttREA.TabIndex = 40;
            this.lblSpellDefenceDecAttREA.Text = "0";
            this.lblSpellDefenceDecAttREA.ToolTipText = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(9, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 156);
            this.panel1.TabIndex = 110;
            // 
            // cmsInitiationNotes
            // 
            this.cmsInitiationNotes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsInitiationNotes});
            this.cmsInitiationNotes.Name = "cmsMetamagic";
            this.cmsInitiationNotes.Size = new System.Drawing.Size(106, 26);
            // 
            // tsInitiationNotes
            // 
            this.tsInitiationNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsInitiationNotes.Name = "tsInitiationNotes";
            this.tsInitiationNotes.Size = new System.Drawing.Size(105, 22);
            this.tsInitiationNotes.Tag = "Menu_Notes";
            this.tsInitiationNotes.Text = "&Notes";
            this.tsInitiationNotes.Click += new System.EventHandler(this.tsInitiationNotes_Click);
            // 
            // cmsMetamagic
            // 
            this.cmsMetamagic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMetamagicAddArt,
            this.tsMetamagicAddEnchantment,
            this.tsMetamagicAddEnhancement,
            this.tsMetamagicAddMetamagic,
            this.tsMetamagicAddRitual,
            this.tsMetamagicNotes});
            this.cmsMetamagic.Name = "cmsMetamagic";
            this.cmsMetamagic.Size = new System.Drawing.Size(173, 136);
            // 
            // tsMetamagicAddArt
            // 
            this.tsMetamagicAddArt.Name = "tsMetamagicAddArt";
            this.tsMetamagicAddArt.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicAddArt.Text = "Add Art";
            this.tsMetamagicAddArt.Click += new System.EventHandler(this.tsMetamagicAddArt_Click);
            // 
            // tsMetamagicAddEnchantment
            // 
            this.tsMetamagicAddEnchantment.Name = "tsMetamagicAddEnchantment";
            this.tsMetamagicAddEnchantment.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicAddEnchantment.Text = "Add Enchantment";
            this.tsMetamagicAddEnchantment.Click += new System.EventHandler(this.tsMetamagicAddEnchantment_Click);
            // 
            // tsMetamagicAddEnhancement
            // 
            this.tsMetamagicAddEnhancement.Name = "tsMetamagicAddEnhancement";
            this.tsMetamagicAddEnhancement.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicAddEnhancement.Text = "Add Enhancement";
            this.tsMetamagicAddEnhancement.Click += new System.EventHandler(this.tsMetamagicAddEnhancement_Click);
            // 
            // tsMetamagicAddMetamagic
            // 
            this.tsMetamagicAddMetamagic.Name = "tsMetamagicAddMetamagic";
            this.tsMetamagicAddMetamagic.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicAddMetamagic.Text = "Add Metamagic";
            this.tsMetamagicAddMetamagic.Click += new System.EventHandler(this.tsMetamagicAddMetamagic_Click);
            // 
            // tsMetamagicAddRitual
            // 
            this.tsMetamagicAddRitual.Name = "tsMetamagicAddRitual";
            this.tsMetamagicAddRitual.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicAddRitual.Text = "Add Ritual";
            this.tsMetamagicAddRitual.Click += new System.EventHandler(this.tsMetamagicAddRitual_Click);
            // 
            // tsMetamagicNotes
            // 
            this.tsMetamagicNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsMetamagicNotes.Name = "tsMetamagicNotes";
            this.tsMetamagicNotes.Size = new System.Drawing.Size(172, 22);
            this.tsMetamagicNotes.Tag = "Menu_Notes";
            this.tsMetamagicNotes.Text = "&Notes";
            this.tsMetamagicNotes.Click += new System.EventHandler(this.tsMetamagicNotes_Click);
            // 
            // cmsTechnique
            // 
            this.cmsTechnique.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddTechniqueNotes});
            this.cmsTechnique.Name = "cmsWeapon";
            this.cmsTechnique.Size = new System.Drawing.Size(106, 26);
            // 
            // tsAddTechniqueNotes
            // 
            this.tsAddTechniqueNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsAddTechniqueNotes.Name = "tsAddTechniqueNotes";
            this.tsAddTechniqueNotes.Size = new System.Drawing.Size(105, 22);
            this.tsAddTechniqueNotes.Tag = "Menu_Notes";
            this.tsAddTechniqueNotes.Text = "&Notes";
            this.tsAddTechniqueNotes.Click += new System.EventHandler(this.tsAddTechniqueNotes_Click);
            // 
            // cmsAdvancedProgram
            // 
            this.cmsAdvancedProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddAdvancedProgramOption,
            this.tsAIProgramNotes});
            this.cmsAdvancedProgram.Name = "cmsAdvancedProgram";
            this.cmsAdvancedProgram.Size = new System.Drawing.Size(137, 48);
            // 
            // tsAddAdvancedProgramOption
            // 
            this.tsAddAdvancedProgramOption.Image = global::Chummer.Properties.Resources.plugin_add;
            this.tsAddAdvancedProgramOption.Name = "tsAddAdvancedProgramOption";
            this.tsAddAdvancedProgramOption.Size = new System.Drawing.Size(136, 22);
            this.tsAddAdvancedProgramOption.Tag = "Menu_AddOption";
            this.tsAddAdvancedProgramOption.Text = "&Add Option";
            // 
            // tsAIProgramNotes
            // 
            this.tsAIProgramNotes.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsAIProgramNotes.Name = "tsAIProgramNotes";
            this.tsAIProgramNotes.Size = new System.Drawing.Size(136, 22);
            this.tsAIProgramNotes.Tag = "Menu_Notes";
            this.tsAIProgramNotes.Text = "&Notes";
            this.tsAIProgramNotes.Click += new System.EventHandler(this.tsAIProgramNotes_Click);
            // 
            // cmsGearAllowRename
            // 
            this.cmsGearAllowRename.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGearAllowRenameAddAsPlugin,
            this.tsGearAllowRenameName,
            this.tsGearAllowRenameNotes,
            this.tsGearAllowRenameExtra});
            this.cmsGearAllowRename.Name = "cmsGearAllowRename";
            this.cmsGearAllowRename.Size = new System.Drawing.Size(170, 92);
            // 
            // tsGearAllowRenameExtra
            // 
            this.tsGearAllowRenameExtra.Image = global::Chummer.Properties.Resources.note_edit;
            this.tsGearAllowRenameExtra.Name = "tsGearAllowRenameExtra";
            this.tsGearAllowRenameExtra.Size = new System.Drawing.Size(169, 22);
            this.tsGearAllowRenameExtra.Tag = "Menu_RenameExtraText";
            this.tsGearAllowRenameExtra.Text = "&Rename Extra Text";
            this.tsGearAllowRenameExtra.Click += new System.EventHandler(this.tsGearRename_Click);
            // 
            // frmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1085, 681);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.mnuCreateMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuCreateMenu;
            this.Name = "frmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chummer - Create New Character";
            this.Activated += new System.EventHandler(this.frmCreate_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreate_FormClosing);
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.cmsMartialArts.ResumeLayout(false);
            this.cmsSpellButton.ResumeLayout(false);
            this.cmsComplexForm.ResumeLayout(false);
            this.cmsCyberware.ResumeLayout(false);
            this.cmsVehicleCyberware.ResumeLayout(false);
            this.cmsLifestyle.ResumeLayout(false);
            this.cmsArmor.ResumeLayout(false);
            this.cmsWeapon.ResumeLayout(false);
            this.cmsGearButton.ResumeLayout(false);
            this.cmsVehicle.ResumeLayout(false);
            this.cmsWeaponMount.ResumeLayout(false);
            this.mnuCreateMenu.ResumeLayout(false);
            this.mnuCreateMenu.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.cmsGear.ResumeLayout(false);
            this.cmsVehicleWeapon.ResumeLayout(false);
            this.cmsVehicleGear.ResumeLayout(false);
            this.cmsArmorGear.ResumeLayout(false);
            this.cmsArmorMod.ResumeLayout(false);
            this.cmsQuality.ResumeLayout(false);
            this.cmsSpell.ResumeLayout(false);
            this.cmsCritterPowers.ResumeLayout(false);
            this.cmsLifestyleNotes.ResumeLayout(false);
            this.cmsWeaponAccessory.ResumeLayout(false);
            this.cmsGearPlugin.ResumeLayout(false);
            this.cmsComplexFormPlugin.ResumeLayout(false);
            this.cmsBioware.ResumeLayout(false);
            this.cmsAdvancedLifestyle.ResumeLayout(false);
            this.cmsGearLocation.ResumeLayout(false);
            this.cmsArmorLocation.ResumeLayout(false);
            this.cmsCyberwareGear.ResumeLayout(false);
            this.cmsVehicleCyberwareGear.ResumeLayout(false);
            this.cmsWeaponAccessoryGear.ResumeLayout(false);
            this.cmsVehicleLocation.ResumeLayout(false);
            this.cmsVehicleWeaponAccessory.ResumeLayout(false);
            this.cmsVehicleWeaponAccessoryGear.ResumeLayout(false);
            this.cmsWeaponLocation.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabCharacterTabs.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabCommon.PerformLayout();
            this.tlpCommon.ResumeLayout(false);
            this.tlpCommon.PerformLayout();
            this.tlpCommonLeftSide.ResumeLayout(false);
            this.tlpCommonLeftSide.PerformLayout();
            this.tlpCommonBottomLeftSide.ResumeLayout(false);
            this.tlpCommonBottomLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQualityLevel)).EndInit();
            this.flpNuyen.ResumeLayout(false);
            this.flpNuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMysticAdeptMAGMagician)).EndInit();
            this.tabSkills.ResumeLayout(false);
            this.tabLimits.ResumeLayout(false);
            this.tabMartialArts.ResumeLayout(false);
            this.tabMartialArts.PerformLayout();
            this.tlpMartialArts.ResumeLayout(false);
            this.tlpMartialArts.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabMagician.ResumeLayout(false);
            this.tlpMagician.ResumeLayout(false);
            this.tlpMagician.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tabAdept.ResumeLayout(false);
            this.tabTechnomancer.ResumeLayout(false);
            this.tlpTechnomancer.ResumeLayout(false);
            this.tlpTechnomancer.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tabAdvancedPrograms.ResumeLayout(false);
            this.tabAdvancedPrograms.PerformLayout();
            this.tlpAdvancedPrograms.ResumeLayout(false);
            this.tlpAdvancedPrograms.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.tabCritter.ResumeLayout(false);
            this.tlpCritter.ResumeLayout(false);
            this.tlpCritter.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabInitiation.ResumeLayout(false);
            this.tlpInitiation.ResumeLayout(false);
            this.tlpInitiation.PerformLayout();
            this.flpInitiationCheckBoxes.ResumeLayout(false);
            this.flpInitiationCheckBoxes.PerformLayout();
            this.flpInitiationButtons.ResumeLayout(false);
            this.flpInitiationButtons.PerformLayout();
            this.tabCyberware.ResumeLayout(false);
            this.tlpCyberware.ResumeLayout(false);
            this.tlpCyberware.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flpCyberware.ResumeLayout(false);
            this.flpCyberware.PerformLayout();
            this.gpbEssenceConsumption.ResumeLayout(false);
            this.gpbEssenceConsumption.PerformLayout();
            this.tlpCyberwareEssenceConsumption.ResumeLayout(false);
            this.tlpCyberwareEssenceConsumption.PerformLayout();
            this.tlpCyberwareCommon.ResumeLayout(false);
            this.tlpCyberwareCommon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCyberwareRating)).EndInit();
            this.tlpCyberwareMatrix.ResumeLayout(false);
            this.tlpCyberwareMatrix.PerformLayout();
            this.tabStreetGear.ResumeLayout(false);
            this.tabStreetGearTabs.ResumeLayout(false);
            this.tabGear.ResumeLayout(false);
            this.tlpGear.ResumeLayout(false);
            this.tlpGear.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGearRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGearQty)).EndInit();
            this.tabArmor.ResumeLayout(false);
            this.tlpArmor.ResumeLayout(false);
            this.tlpArmor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudArmorRating)).EndInit();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.tabWeapons.ResumeLayout(false);
            this.tlpWeapons.ResumeLayout(false);
            this.tlpWeapons.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabDrugs.ResumeLayout(false);
            this.tblDrugInfo.ResumeLayout(false);
            this.tblDrugInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrugQty)).EndInit();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.tabLifestyle.ResumeLayout(false);
            this.tabLifestyle.PerformLayout();
            this.tblLifestyleDetails.ResumeLayout(false);
            this.tblLifestyleDetails.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLifestyleMonths)).EndInit();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.tabVehicles.ResumeLayout(false);
            this.tlpVehicles.ResumeLayout(false);
            this.tlpVehicles.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleGearQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleRating)).EndInit();
            this.tlpVehicleWeapon.ResumeLayout(false);
            this.tlpVehicleWeapon.PerformLayout();
            this.tabCharacterInfo.ResumeLayout(false);
            this.tlpCharacterInfo.ResumeLayout(false);
            this.tlpCharacterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMugshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMugshotIndex)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.tabRelationships.ResumeLayout(false);
            this.tabPeople.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.tlpContacts.ResumeLayout(false);
            this.tlpContacts.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.cmsAddContact.ResumeLayout(false);
            this.tabEnemies.ResumeLayout(false);
            this.tlpEnemies.ResumeLayout(false);
            this.tlpEnemies.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            this.flowLayoutPanel16.PerformLayout();
            this.tabPets.ResumeLayout(false);
            this.tlpPets.ResumeLayout(false);
            this.tlpPets.PerformLayout();
            this.flowLayoutPanel17.ResumeLayout(false);
            this.flowLayoutPanel17.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabBPSummary.ResumeLayout(false);
            this.tabBPSummary.PerformLayout();
            this.tlpKarmaSummary.ResumeLayout(false);
            this.tlpKarmaSummary.PerformLayout();
            this.tabOtherInfo.ResumeLayout(false);
            this.tabOtherInfo.PerformLayout();
            this.tlpOtherInfo.ResumeLayout(false);
            this.tlpOtherInfo.PerformLayout();
            this.tabDefences.ResumeLayout(false);
            this.tabDefences.PerformLayout();
            this.tlpSpellDefense.ResumeLayout(false);
            this.tlpSpellDefense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCounterspellingDice)).EndInit();
            this.cmsInitiationNotes.ResumeLayout(false);
            this.cmsMetamagic.ResumeLayout(false);
            this.cmsTechnique.ResumeLayout(false);
            this.cmsAdvancedProgram.ResumeLayout(false);
            this.cmsGearAllowRename.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssBPLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssBP;
        private System.Windows.Forms.ToolStripStatusLabel tssBPRemainLabel;
        private System.Windows.Forms.ToolStripStatusLabel tssBPRemain;
        private System.Windows.Forms.Label lblAttributes;
        private System.Windows.Forms.Label lblNuyen;
        private System.Windows.Forms.NumericUpDown nudNuyen;
        private System.Windows.Forms.Label lblNuyenTotal;
        private System.Windows.Forms.Label lblMetatypeLabel;
        private System.Windows.Forms.Label lblMetatype;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.TabControl tabCharacterTabs;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabMagician;
        private System.Windows.Forms.TabPage tabAdept;
        private System.Windows.Forms.TabPage tabTechnomancer;
        private System.Windows.Forms.TabPage tabCyberware;
        private System.Windows.Forms.TabPage tabStreetGear;
        private System.Windows.Forms.TreeView treQualities;
        private System.Windows.Forms.Button cmdAddSpirit;
        private System.Windows.Forms.Panel panSpirits;
        private System.Windows.Forms.Button cmdAddSprite;
        private System.Windows.Forms.Panel panSprites;
        private System.Windows.Forms.Label lblCyberwareRatingLabel;
        private System.Windows.Forms.Label lblCyberwareCost;
        private System.Windows.Forms.Label lblCyberwareCostLabel;
        private System.Windows.Forms.Label lblCyberwareAvail;
        private System.Windows.Forms.Label lblCyberwareAvailLabel;
        private System.Windows.Forms.Label lblCyberwareGradeLabel;
        private System.Windows.Forms.Label lblCyberwareCapacity;
        private System.Windows.Forms.Label lblCyberwareCapacityLabel;
        private System.Windows.Forms.Label lblCyberwareEssence;
        private System.Windows.Forms.Label lblCyberwareEssenceLabel;
        private System.Windows.Forms.Label lblCyberwareCategory;
        private System.Windows.Forms.Label lblCyberwareCategoryLabel;
        private System.Windows.Forms.Label lblCyberwareName;
        private System.Windows.Forms.Label lblCyberwareNameLabel;
        private System.Windows.Forms.TreeView treCyberware;
        private ElasticComboBox cboCyberwareGrade;
        private System.Windows.Forms.NumericUpDown nudCyberwareRating;
        private System.Windows.Forms.Button cmdDeleteCyberware;
        private System.Windows.Forms.Button cmdAddBioware;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabBPSummary;
        private System.Windows.Forms.Label lblEnemiesBP;
        private System.Windows.Forms.Label lblBuildEnemies;
        private System.Windows.Forms.Label lblKarmaMetatypeBP;
        private System.Windows.Forms.Label lblSummaryMetatype;
        private System.Windows.Forms.Label lblComplexFormsBP;
        private System.Windows.Forms.Label lblBuildComplexForms;
        private System.Windows.Forms.Label lblBuildSprites;
        private System.Windows.Forms.Label lblBuildSpirits;
        private System.Windows.Forms.Label lblSpiritsBP;
        private System.Windows.Forms.Label lblSpritesBP;
        private System.Windows.Forms.Label lblBuildSpells;
        private System.Windows.Forms.Label lblKnowledgeSkillsBP;
        private System.Windows.Forms.Label lblBuildKnowledgeSkills;
        private System.Windows.Forms.Label lblActiveSkillsBP;
        private System.Windows.Forms.Label lblSpellsBP;
        private System.Windows.Forms.Label lblBuildActiveSkills;
        private System.Windows.Forms.Label lblSkillGroupsBP;
        private System.Windows.Forms.Label lblBuildSkillGroups;
        private System.Windows.Forms.Label lblBuildContacts;
        private System.Windows.Forms.Label lblBuildPrimaryAttributes;
        private System.Windows.Forms.Label lblBuildNegativeQualities;
        private System.Windows.Forms.Label lblBuildPositiveQualities;
        private System.Windows.Forms.Label lblPositiveQualitiesBP;
        private System.Windows.Forms.Label lblNegativeQualitiesBP;
        private System.Windows.Forms.Label lblAttributesBP;
        private System.Windows.Forms.Label lblContactsBP;
        private System.Windows.Forms.TabPage tabOtherInfo;
        private System.Windows.Forms.Label lblESSMax;
        private System.Windows.Forms.Label lblESS;
        private LabelWithToolTip lblArmor;
        private System.Windows.Forms.Label lblArmorLabel;
        private System.Windows.Forms.Label lblAstralINI;
        private System.Windows.Forms.Label lblMatrixINI;
        private System.Windows.Forms.Label lblINI;
        private System.Windows.Forms.Label lblCMStun;
        private System.Windows.Forms.Label lblCMPhysical;
        private System.Windows.Forms.Label lblAstralINILabel;
        private System.Windows.Forms.Label lblMatrixINILabel;
        private System.Windows.Forms.Label lblINILabel;
        private System.Windows.Forms.Label lblCMStunLabel;
        private System.Windows.Forms.Label lblCMPhysicalLabel;
        private System.Windows.Forms.Button cmdDeleteWeapon;
        private System.Windows.Forms.TreeView treWeapons;
        private System.Windows.Forms.Label lblWeaponAP;
        private System.Windows.Forms.Label lblWeaponAPLabel;
        private System.Windows.Forms.Label lblWeaponCost;
        private System.Windows.Forms.Label lblWeaponCostLabel;
        private System.Windows.Forms.Label lblWeaponAvail;
        private System.Windows.Forms.Label lblWeaponAvailLabel;
        private System.Windows.Forms.Label lblWeaponRC;
        private System.Windows.Forms.Label lblWeaponRCLabel;
        private System.Windows.Forms.Label lblWeaponDamage;
        private System.Windows.Forms.Label lblWeaponDamageLabel;
        private System.Windows.Forms.Label lblWeaponCategory;
        private System.Windows.Forms.Label lblWeaponCategoryLabel;
        private System.Windows.Forms.Label lblWeaponMode;
        private System.Windows.Forms.Label lblWeaponModeLabel;
        private System.Windows.Forms.Label lblWeaponReach;
        private System.Windows.Forms.Label lblWeaponReachLabel;
        private System.Windows.Forms.Label lblWeaponAmmo;
        private System.Windows.Forms.Label lblWeaponAmmoLabel;
        private System.Windows.Forms.Button cmdDeleteArmor;
        private System.Windows.Forms.TreeView treArmor;
        private System.Windows.Forms.Label lblArmorCost;
        private System.Windows.Forms.Label lblArmorCostLabel;
        private System.Windows.Forms.Label lblArmorAvail;
        private System.Windows.Forms.Label lblArmorAvailLabel;
        private System.Windows.Forms.Label lblRemainingNuyen;
        private System.Windows.Forms.Label lblRemainingNuyenLabel;
        private System.Windows.Forms.MenuStrip mnuCreateMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.Label lblNuyenBP;
        private System.Windows.Forms.Label lblBuildNuyen;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label lblWeaponNameLabel;
        private System.Windows.Forms.ContextMenuStrip cmsCyberware;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleCyberware;
        private System.Windows.Forms.ToolStripMenuItem tsCyberwareAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleCyberwareAddAsPlugin;
        private System.Windows.Forms.Button cmdDeleteLifestyle;
        private System.Windows.Forms.TreeView treLifestyles;
        private System.Windows.Forms.Label lblLifestyleTotalCost;
        private System.Windows.Forms.Label lblLifestyleCostLabel;
        private System.Windows.Forms.Label lblLifestyleCost;
        private System.Windows.Forms.Label lblLifestyleMonthsLabel;
        private System.Windows.Forms.NumericUpDown nudLifestyleMonths;
        private System.Windows.Forms.TabControl tabStreetGearTabs;
        private System.Windows.Forms.TabPage tabLifestyle;
        private System.Windows.Forms.TabPage tabArmor;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.TabPage tabGear;
        private System.Windows.Forms.TreeView treGear;
        private System.Windows.Forms.Button cmdDeleteGear;
        private System.Windows.Forms.NumericUpDown nudGearRating;
        private System.Windows.Forms.Label lblGearRatingLabel;
        private System.Windows.Forms.ContextMenuStrip cmsWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAddAccessory;
        private System.Windows.Forms.TabPage tabVehicles;
        private System.Windows.Forms.ContextMenuStrip cmsArmor;
        private System.Windows.Forms.ToolStripMenuItem tsAddArmorMod;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ContextMenuStrip cmsGear;
        private System.Windows.Forms.ToolStripMenuItem tsGearAddAsPlugin;
        private System.Windows.Forms.Label lblGearCost;
        private System.Windows.Forms.Label lblGearCostLabel;
        private System.Windows.Forms.Label lblGearAvail;
        private System.Windows.Forms.Label lblGearAvailLabel;
        private System.Windows.Forms.Label lblGearCapacity;
        private System.Windows.Forms.Label lblGearCapacityLabel;
        private System.Windows.Forms.Label lblGearCategory;
        private System.Windows.Forms.Label lblGearCategoryLabel;
        private System.Windows.Forms.Label lblGearName;
        private System.Windows.Forms.Label lblGearNameLabel;
        private System.Windows.Forms.NumericUpDown nudGearQty;
        private System.Windows.Forms.Label lblGearQtyLabel;
        private System.Windows.Forms.Button cmdDeleteVehicle;
        private System.Windows.Forms.TreeView treVehicles;
        private System.Windows.Forms.Label lblVehicleNameLabel;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.Label lblVehicleCategoryLabel;
        private System.Windows.Forms.Label lblVehicleCategory;
        private System.Windows.Forms.Label lblVehicleSensor;
        private System.Windows.Forms.Label lblVehicleSensorLabel;
        private System.Windows.Forms.Label lblVehiclePilot;
        private System.Windows.Forms.Label lblVehiclePilotLabel;
        private System.Windows.Forms.Label lblVehicleArmor;
        private System.Windows.Forms.Label lblVehicleArmorLabel;
        private System.Windows.Forms.Label lblVehicleBody;
        private System.Windows.Forms.Label lblVehicleBodyLabel;
        private System.Windows.Forms.Label lblVehicleSpeed;
        private System.Windows.Forms.Label lblVehicleSpeedLabel;
        private System.Windows.Forms.Label lblVehicleCost;
        private System.Windows.Forms.Label lblVehicleCostLabel;
        private System.Windows.Forms.Label lblVehicleAvail;
        private System.Windows.Forms.Label lblVehicleAvailLabel;
        private System.Windows.Forms.Label lblVehicleAccel;
        private System.Windows.Forms.Label lblVehicleAccelLabel;
        private System.Windows.Forms.Label lblVehicleHandling;
        private System.Windows.Forms.Label lblVehicleHandlingLabel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ContextMenuStrip cmsWeaponMount;
        private System.Windows.Forms.ContextMenuStrip cmsVehicle;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddMod;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddWeaponMount;
        private System.Windows.Forms.NumericUpDown nudVehicleRating;
        private System.Windows.Forms.Label lblVehicleRatingLabel;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddWeaponAccessory;
        private System.Windows.Forms.Label lblVehicleSlots;
        private System.Windows.Forms.Label lblVehicleSlotsLabel;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddWeaponAccessoryAlt;
        private System.Windows.Forms.CheckBox chkArmorEquipped;
        private System.Windows.Forms.TabPage tabMartialArts;
        private System.Windows.Forms.TreeView treMartialArts;
        private System.Windows.Forms.Button cmdDeleteMartialArt;
        private System.Windows.Forms.ContextMenuStrip cmsMartialArts;
        private System.Windows.Forms.ToolStripMenuItem tsMartialArtsAddAdvantage;
        private System.Windows.Forms.TabPage tabCharacterInfo;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.Label lblConcept;
        private System.Windows.Forms.TextBox txtBackground;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSkin;
        private System.Windows.Forms.Label lblSkin;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHair;
        private System.Windows.Forms.Label lblHair;
        private System.Windows.Forms.TextBox txtEyes;
        private System.Windows.Forms.Label lblEyes;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssEssence;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tssNuyenRemaining;
        private System.Windows.Forms.Label lblGearDeviceRating;
        private System.Windows.Forms.Label lblGearDeviceRatingLabel;
        private System.Windows.Forms.Label lblBuildMartialArts;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAddModification;
        private System.Windows.Forms.Label lblBuildFoci;
        private System.Windows.Forms.Label lblFociBP;
        private System.Windows.Forms.Label lblMartialArtSource;
        private System.Windows.Forms.Label lblMartialArtSourceLabel;
        private System.Windows.Forms.Label lblCyberwareSource;
        private System.Windows.Forms.Label lblCyberwareSourceLabel;
        private System.Windows.Forms.Label lblLifestyleSource;
        private System.Windows.Forms.Label lblLifestyleSourceLabel;
        private System.Windows.Forms.Label lblArmorSource;
        private System.Windows.Forms.Label lblArmorSourceLabel;
        private System.Windows.Forms.Label lblWeaponSource;
        private System.Windows.Forms.Label lblWeaponSourceLabel;
        private System.Windows.Forms.Label lblGearSource;
        private System.Windows.Forms.Label lblGearSourceLabel;
        private System.Windows.Forms.Label lblVehicleSource;
        private System.Windows.Forms.Label lblVehicleSourceLabel;
        private System.Windows.Forms.Label lblMugshot;
        private System.Windows.Forms.PictureBox picMugshot;
        private System.Windows.Forms.Button cmdDeleteMugshot;
        private System.Windows.Forms.Button cmdAddMugshot;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblAttributesAug;
        private System.Windows.Forms.Label lblAttributesBase;
        private System.Windows.Forms.Label lblAttributesMetatype;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabPage tabInitiation;
        private System.Windows.Forms.Button cmdAddMetamagic;
        private System.Windows.Forms.Button cmdDeleteMetamagic;
        private System.Windows.Forms.Label lblInitiationBP;
        private System.Windows.Forms.Label lblMartialArtsBP;
        private System.Windows.Forms.Label lblBuildInitiation;
        private System.Windows.Forms.Label lblWeaponSlots;
        private System.Windows.Forms.Label lblWeaponSlotsLabel;
        private System.Windows.Forms.NumericUpDown nudMysticAdeptMAGMagician;
        private System.Windows.Forms.Label lblMysticAdeptAssignment;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddSensor;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleGear;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleGearAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleSensorAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateSpecial;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialAddPACKSKit;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialAddCyberwareSuite;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialConfirmValidity;
        private System.Windows.Forms.NumericUpDown nudArmorRating;
        private System.Windows.Forms.Label lblArmorRatingLabel;
        private System.Windows.Forms.Label lblLifestyleStartingNuyenLabel;
        private System.Windows.Forms.Label lblLifestyleStartingNuyen;
        private System.Windows.Forms.ToolStripProgressBar pgbProgress;
        private System.Windows.Forms.CheckBox chkCharacterCreated;
        private System.Windows.Forms.Label lblBaseLifestyle;
        private System.Windows.Forms.Label lblLifestyleComfortsLabel;
        private System.Windows.Forms.Label lblLifestyleQualities;
        private System.Windows.Forms.Label lblLifestyleQualitiesLabel;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.CheckBox chkWeaponAccessoryInstalled;
        private System.Windows.Forms.CheckBox chkIncludedInWeapon;
        private System.Windows.Forms.CheckBox chkVehicleIncludedInWeapon;
        private System.Windows.Forms.CheckBox chkVehicleWeaponAccessoryInstalled;
        private System.Windows.Forms.Label lblWeaponRangeExtreme;
        private System.Windows.Forms.Label lblWeaponRangeLong;
        private System.Windows.Forms.Label lblWeaponRangeMedium;
        private System.Windows.Forms.Label lblWeaponRangeShort;
        private System.Windows.Forms.Label lblWeaponRangeExtremeLabel;
        private System.Windows.Forms.Label lblWeaponRangeLongLabel;
        private System.Windows.Forms.Label lblWeaponRangeMediumLabel;
        private System.Windows.Forms.Label lblWeaponRangeShortLabel;
        private System.Windows.Forms.Label lblWeaponRangeLabel;
        private System.Windows.Forms.TabPage tabCritter;
        private System.Windows.Forms.Label lblCritterPowerSource;
        private System.Windows.Forms.Label lblCritterPowerSourceLabel;
        private System.Windows.Forms.Label lblCritterPowerDuration;
        private System.Windows.Forms.Label lblCritterPowerDurationLabel;
        private System.Windows.Forms.Label lblCritterPowerRange;
        private System.Windows.Forms.Label lblCritterPowerRangeLabel;
        private System.Windows.Forms.Label lblCritterPowerAction;
        private System.Windows.Forms.Label lblCritterPowerActionLabel;
        private System.Windows.Forms.Label lblCritterPowerType;
        private System.Windows.Forms.Label lblCritterPowerTypeLabel;
        private System.Windows.Forms.Label lblCritterPowerCategory;
        private System.Windows.Forms.Label lblCritterPowerCategoryLabel;
        private System.Windows.Forms.Label lblCritterPowerName;
        private System.Windows.Forms.Label lblCritterPowerNameLabel;
        private System.Windows.Forms.Button cmdDeleteCritterPower;
        private System.Windows.Forms.Button cmdAddCritterPower;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponName;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponMountLocation;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAddUnderbarrel;
        private System.Windows.Forms.Button cmdDeleteComplexForm;
        private System.Windows.Forms.Label lblComplexFormSource;
        private System.Windows.Forms.Label lblComplexFormSourceLabel;
        private System.Windows.Forms.TreeView treComplexForms;
        private ElasticComboBox cboStream;
        private LabelWithToolTip lblFadingAttributesValue;
        private System.Windows.Forms.Label lblFadingAttributes;
        private System.Windows.Forms.Label lblFadingAttributesLabel;
        private System.Windows.Forms.Label lblStreamLabel;
        private System.Windows.Forms.ContextMenuStrip cmsComplexForm;
        private System.Windows.Forms.ToolStripMenuItem tsAddComplexFormOption;
        private System.Windows.Forms.NumericUpDown nudVehicleGearQty;
        private System.Windows.Forms.Label lblVehicleGearQtyLabel;
        private System.Windows.Forms.Label lblWeaponConceal;
        private System.Windows.Forms.Label lblWeaponConcealLabel;
        private System.Windows.Forms.ContextMenuStrip cmsGearButton;
        private System.Windows.Forms.ToolStripMenuItem tsGearButtonAddAccessory;
        private System.Windows.Forms.Button cmdDeleteQuality;
        private System.Windows.Forms.Button cmdAddQuality;
        private System.Windows.Forms.Label lblQualitySource;
        private System.Windows.Forms.Label lblQualitySourceLabel;
        private System.Windows.Forms.Label lblQualityBP;
        private System.Windows.Forms.Label lblQualityBPLabel;
        private System.Windows.Forms.CheckBox chkInitiationOrdeal;
        private System.Windows.Forms.CheckBox chkInitiationGroup;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.Label lblMovementLabel;
        private System.Windows.Forms.Label lblCritterPowerPoints;
        private System.Windows.Forms.Label lblCritterPowerPointsLabel;
        private System.Windows.Forms.Label lblCritterPowerPointCost;
        private System.Windows.Forms.Label lblCritterPowerPointCostLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialChangeMetatype;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialChangeOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialCreatePACKSKit;
        private LabelWithToolTip lblMemory;
        private System.Windows.Forms.Label lblMemoryLabel;
        private LabelWithToolTip lblLiftCarry;
        private System.Windows.Forms.Label lblLiftCarryLabel;
        private LabelWithToolTip lblJudgeIntentions;
        private System.Windows.Forms.Label lblJudgeIntentionsLabel;
        private LabelWithToolTip lblComposure;
        private System.Windows.Forms.Label lblComposureLabel;
        private System.Windows.Forms.CheckBox chkGearEquipped;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialMutantCritter;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialToxicCritter;
        private System.Windows.Forms.Label lblArmorCapacity;
        private System.Windows.Forms.Label lblArmorCapacityLabel;
        private System.Windows.Forms.ToolStripMenuItem tsAddArmorGear;
        private System.Windows.Forms.ContextMenuStrip cmsArmorGear;
        private System.Windows.Forms.ToolStripMenuItem tsArmorGearAddAsPlugin;
        private System.Windows.Forms.Label lblMetamagicSource;
        private System.Windows.Forms.Label lblMetamagicSourceLabel;
        private System.Windows.Forms.ToolStripMenuItem tsArmorNotes;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponNotes;
        private System.Windows.Forms.ToolStripMenuItem tsCyberwareNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleCyberwareNotes;
        private System.Windows.Forms.ContextMenuStrip cmsArmorMod;
        private System.Windows.Forms.ToolStripMenuItem tsArmorModNotes;
        private System.Windows.Forms.ContextMenuStrip cmsQuality;
        private System.Windows.Forms.ToolStripMenuItem tsQualityNotes;
        private System.Windows.Forms.ToolStripMenuItem tsMartialArtsNotes;
        private System.Windows.Forms.ContextMenuStrip cmsSpell;
        private System.Windows.Forms.ToolStripMenuItem tsSpellNotes;
        private System.Windows.Forms.ToolStripMenuItem tsComplexFormNotes;
        private System.Windows.Forms.ContextMenuStrip cmsCritterPowers;
        private System.Windows.Forms.ToolStripMenuItem tsCritterPowersNotes;
        private System.Windows.Forms.ToolStripMenuItem tsGearNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleWeaponMountNotes;
        private System.Windows.Forms.ContextMenuStrip cmsLifestyleNotes;
        private System.Windows.Forms.ToolStripMenuItem tsLifestyleNotes;
        private System.Windows.Forms.ToolStripMenuItem tsArmorGearNotes;
        private System.Windows.Forms.ContextMenuStrip cmsWeaponAccessory;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAccessoryNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleWeaponNotes;
        private System.Windows.Forms.ContextMenuStrip cmsGearPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsGearPluginNotes;
        private System.Windows.Forms.ContextMenuStrip cmsComplexFormPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsComplexFormPluginNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddWeaponWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddGear;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialCyberzombie;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddUnderbarrelWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddUnderbarrelWeaponAlt;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleName;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialCreateCyberwareSuite;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleAddCyberware;
        private System.Windows.Forms.Label lblFly;
        private System.Windows.Forms.Label lblFlyLabel;
        private System.Windows.Forms.Label lblSwim;
        private System.Windows.Forms.Label lblSwimLabel;
        private System.Windows.Forms.Button cmdAddLocation;
        private System.Windows.Forms.Label lblGearAP;
        private System.Windows.Forms.Label lblGearAPLabel;
        private System.Windows.Forms.Label lblGearDamage;
        private System.Windows.Forms.Label lblGearDamageLabel;
        private System.Windows.Forms.Label lblVehicleDevice;
        private System.Windows.Forms.Label lblVehicleDeviceLabel;
        private System.Windows.Forms.ToolStripMenuItem tsArmorName;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Label lblMetatypeSource;
        private System.Windows.Forms.Label lblMetatypeSourceLabel;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.ContextMenuStrip cmsBioware;
        private System.Windows.Forms.ToolStripMenuItem tsBiowareNotes;
        private System.Windows.Forms.ContextMenuStrip cmsAdvancedLifestyle;
        private System.Windows.Forms.ToolStripMenuItem tsEditAdvancedLifestyle;
        private System.Windows.Forms.ContextMenuStrip cmsLifestyle;
        private System.Windows.Forms.ToolStripMenuItem tsAdvancedLifestyle;
        private System.Windows.Forms.ToolStripMenuItem tsAdvancedLifestyleNotes;
        private System.Windows.Forms.CheckBox chkVehicleHomeNode;
        private System.Windows.Forms.CheckBox chkGearHomeNode;
        private System.Windows.Forms.ToolStripMenuItem tsLifestyleName;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cmsGearLocation;
        private System.Windows.Forms.ToolStripMenuItem tsGearRenameLocation;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialReapplyImprovements;
        private System.Windows.Forms.ContextMenuStrip cmsSpellButton;
        private System.Windows.Forms.ToolStripMenuItem tsCreateSpell;
        private LabelWithToolTip lblPublicAwareTotal;
        private LabelWithToolTip lblNotorietyTotal;
        private LabelWithToolTip lblStreetCredTotal;
        private System.Windows.Forms.Label lblPublicAware;
        private System.Windows.Forms.Label lblNotoriety;
        private System.Windows.Forms.Label lblStreetCred;
        private System.Windows.Forms.Label lblWeaponDicePool;
        private System.Windows.Forms.Label lblWeaponDicePoolLabel;
        private System.Windows.Forms.ContextMenuStrip cmsArmorLocation;
        private System.Windows.Forms.ToolStripMenuItem tsArmorLocationAddArmor;
        private System.Windows.Forms.ToolStripMenuItem tsArmorRenameLocation;
        private System.Windows.Forms.Button cmdAddArmorBundle;
        private System.Windows.Forms.Button cmdArmorUnEquipAll;
        private System.Windows.Forms.Button cmdArmorEquipAll;
        private System.Windows.Forms.Label lblArmorEquipped;
        private System.Windows.Forms.Label lblArmorEquippedLabel;
        private System.Windows.Forms.ToolStripMenuItem tsEditLifestyle;
        private System.Windows.Forms.ContextMenuStrip cmsCyberwareGear;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleCyberwareGear;
        private System.Windows.Forms.ToolStripMenuItem tsCyberwareGearMenuAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleCyberwareGearMenuAddAsPlugin;
        private System.Windows.Forms.ContextMenuStrip cmsWeaponAccessoryGear;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAccessoryGearMenuAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponAccessoryAddGear;
        private System.Windows.Forms.ToolStripMenuItem tsCyberwareAddGear;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleCyberwareAddGear;
        private System.Windows.Forms.Button cmdAddVehicleLocation;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleLocation;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleRenameLocation;
        private System.Windows.Forms.ToolStripSeparator tsbSeparator;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem tsCreateNaturalWeapon;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWeaponAccessory;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleWeaponAccessoryAddGear;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleWeaponAccessoryNotes;
        private System.Windows.Forms.ContextMenuStrip cmsVehicleWeaponAccessoryGear;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleWeaponAccessoryGearMenuAddAsPlugin;
        private System.Windows.Forms.TabPage tabPets;
        private SplitButton cmdAddPet;
        private System.Windows.Forms.FlowLayoutPanel panPets;
        private System.Windows.Forms.CheckBox chkCritterPowerCount;
        private System.Windows.Forms.CheckBox chkIncludedInArmor;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialAddBiowareSuite;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialCreateBiowareSuite;
        private System.Windows.Forms.Button cmdAddWeaponLocation;
        private System.Windows.Forms.ContextMenuStrip cmsWeaponLocation;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponRenameLocation;
        private System.Windows.Forms.ToolStripMenuItem tsGearName;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleGearNotes;
        private System.Windows.Forms.CheckBox chkCommlinks;
        private System.Windows.Forms.CheckBox chkGearActiveCommlink;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialBPAvailLimit;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialConvertToFreeSprite;
        private System.Windows.Forms.Label lblVehicleWeaponRangeExtreme;
        private System.Windows.Forms.Label lblVehicleWeaponRangeLong;
        private System.Windows.Forms.Label lblVehicleWeaponRangeMedium;
        private System.Windows.Forms.Label lblVehicleWeaponRangeShort;
        private System.Windows.Forms.Label lblVehicleWeaponRangeExtremeLabel;
        private System.Windows.Forms.Label lblVehicleWeaponRangeLongLabel;
        private System.Windows.Forms.Label lblVehicleWeaponRangeMediumLabel;
        private System.Windows.Forms.Label lblVehicleWeaponRangeShortLabel;
        private System.Windows.Forms.Label lblVehicleWeaponRangeLabel;
        private System.Windows.Forms.Label lblVehicleWeaponAmmo;
        private System.Windows.Forms.Label lblVehicleWeaponAmmoLabel;
        private System.Windows.Forms.Label lblVehicleWeaponMode;
        private System.Windows.Forms.Label lblVehicleWeaponModeLabel;
        private System.Windows.Forms.Label lblVehicleWeaponAP;
        private System.Windows.Forms.Label lblVehicleWeaponAPLabel;
        private System.Windows.Forms.Label lblVehicleWeaponDamageLabel;
        private System.Windows.Forms.Label lblVehicleWeaponDamage;
        private System.Windows.Forms.Label lblBiowareESS;
        private System.Windows.Forms.Label lblCyberwareESS;
        private System.Windows.Forms.Label lblBiowareESSLabel;
        private System.Windows.Forms.Label lblCyberwareESSLabel;
        private System.Windows.Forms.Label lblEssenceHoleESS;
        private System.Windows.Forms.Label lblEssenceHoleESSLabel;
        private System.Windows.Forms.Label lblRiggingINI;
        private System.Windows.Forms.Label lblRiggingINILabel;
        private System.Windows.Forms.Label lblMatrixINIHot;
        private System.Windows.Forms.Label lblMatrixINIHotLabel;
        private System.Windows.Forms.Label lblMatrixINICold;
        private System.Windows.Forms.Label lblMatrixINIColdLabel;
        private SplitButton cmdAddLifestyle;
        private System.Windows.Forms.TabPage tabLimits;
        private System.Windows.Forms.Label lblWeaponAccuracy;
        private System.Windows.Forms.Label lblWeaponAccuracyLabel;
        private SplitButton cmdAddMartialArt;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel1;
        private SplitButton cmdAddSpell;
        private System.Windows.Forms.Button cmdAddComplexForm;
        private SplitButton cmdAddCyberware;
        private SplitButton cmdAddArmor;
        private SplitButton cmdAddWeapon;
        private SplitButton cmdAddGear;
        private SplitButton cmdAddVehicle;
        private System.Windows.Forms.Label lblSpellDicePool;
        private System.Windows.Forms.Label lblSpellDicePoolLabel;
        private System.Windows.Forms.Label lblMentorSpirit;
        private System.Windows.Forms.Label lblMentorSpiritLabel;
        private System.Windows.Forms.Label lblMentorSpiritInformation;
        private LabelWithToolTip lblDrainAttributesValue;
        private System.Windows.Forms.Label lblDrainAttributes;
        private System.Windows.Forms.Label lblDrainAttributesLabel;
        private ElasticComboBox cboTradition;
        private System.Windows.Forms.Label lblTraditionLabel;
        private System.Windows.Forms.Label lblSpellSource;
        private System.Windows.Forms.Label lblSpellSourceLabel;
        private System.Windows.Forms.Label lblSpellType;
        private System.Windows.Forms.Label lblSpellTypeLabel;
        private System.Windows.Forms.Label lblSpellDV;
        private System.Windows.Forms.Label lblSpellDVLabel;
        private System.Windows.Forms.Label lblSpellDuration;
        private System.Windows.Forms.Label lblSpellDurationLabel;
        private System.Windows.Forms.Label lblSpellDamage;
        private System.Windows.Forms.Label lblSpellDamageLabel;
        private System.Windows.Forms.Label lblSpellRange;
        private System.Windows.Forms.Label lblSpellRangeLabel;
        private System.Windows.Forms.Label lblSpellCategory;
        private System.Windows.Forms.Label lblSpellCategoryLabel;
        private System.Windows.Forms.Label lblSpellDescriptors;
        private System.Windows.Forms.Label lblSpellDescriptorsLabel;
        private System.Windows.Forms.TreeView treSpells;
        private System.Windows.Forms.Button cmdDeleteSpell;
        private System.Windows.Forms.Label lblFV;
        private System.Windows.Forms.Label lblFVLabel;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationLabel;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTargetLabel;
        private System.Windows.Forms.Label lblArmorValueLabel;
        private System.Windows.Forms.Label lblArmorValue;
        private System.Windows.Forms.Label lblGearFirewallLabel;
        private System.Windows.Forms.Label lblGearDataProcessingLabel;
        private System.Windows.Forms.Label lblGearSleazeLabel;
        private System.Windows.Forms.Label lblGearAttackLabel;
        private System.Windows.Forms.Label lblCyberFirewall;
        private System.Windows.Forms.Label lblCyberFirewallLabel;
        private System.Windows.Forms.Label lblCyberDataProcessing;
        private System.Windows.Forms.Label lblCyberDataProcessingLabel;
        private System.Windows.Forms.Label lblCyberSleaze;
        private System.Windows.Forms.Label lblCyberSleazeLabel;
        private System.Windows.Forms.Label lblCyberAttack;
        private System.Windows.Forms.Label lblCyberAttackLabel;
        private System.Windows.Forms.Label lblCyberDeviceRating;
        private System.Windows.Forms.Label lblCyberDeviceRatingLabel;
        private System.Windows.Forms.Label lblVehicleFirewallLabel;
        private System.Windows.Forms.Label lblVehicleDataProcessingLabel;
        private System.Windows.Forms.Label lblVehicleSleazeLabel;
        private System.Windows.Forms.Label lblVehicleAttackLabel;
        private System.Windows.Forms.Label lblWeaponFirewall;
        private System.Windows.Forms.Label lblWeaponFirewallLabel;
        private System.Windows.Forms.Label lblWeaponDataProcessing;
        private System.Windows.Forms.Label lblWeaponDataProcessingLabel;
        private System.Windows.Forms.Label lblWeaponSleaze;
        private System.Windows.Forms.Label lblWeaponSleazeLabel;
        private System.Windows.Forms.Label lblWeaponAttack;
        private System.Windows.Forms.Label lblWeaponAttackLabel;
        private System.Windows.Forms.Label lblWeaponDeviceRating;
        private System.Windows.Forms.Label lblWeaponDeviceRatingLabel;
        private System.Windows.Forms.Label lblArmorFirewall;
        private System.Windows.Forms.Label lblArmorFirewallLabel;
        private System.Windows.Forms.Label lblArmorDataProcessing;
        private System.Windows.Forms.Label lblArmorDataProcessingLabel;
        private System.Windows.Forms.Label lblArmorSleaze;
        private System.Windows.Forms.Label lblArmorSleazeLabel;
        private System.Windows.Forms.Label lblArmorAttack;
        private System.Windows.Forms.Label lblArmorAttackLabel;
        private System.Windows.Forms.Label lblArmorDeviceRating;
        private System.Windows.Forms.Label lblArmorDeviceRatingLabel;
	    private ElasticComboBox cboDrain;
		private System.Windows.Forms.TextBox txtTraditionName;
        private System.Windows.Forms.Label lblTraditionName;
        private ElasticComboBox cboSpiritCombat;
        private System.Windows.Forms.Label lblSpiritCombat;
        private ElasticComboBox cboSpiritManipulation;
        private System.Windows.Forms.Label lblSpiritManipulation;
        private ElasticComboBox cboSpiritIllusion;
        private System.Windows.Forms.Label lblSpiritIllusion;
        private ElasticComboBox cboSpiritHealth;
        private System.Windows.Forms.Label lblSpiritHealth;
        private ElasticComboBox cboSpiritDetection;
        private System.Windows.Forms.Label lblSpiritDetection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabPeople;
        private System.Windows.Forms.TabPage tabContacts;
        private SplitButton cmdAddContact;
        private System.Windows.Forms.FlowLayoutPanel panContacts;
        private System.Windows.Forms.TabPage tabEnemies;
        private System.Windows.Forms.FlowLayoutPanel panEnemies;
        private SplitButton cmdAddEnemy;
        private System.Windows.Forms.CheckBox chkInitiationSchooling;
        private System.Windows.Forms.ContextMenuStrip cmsInitiationNotes;
        private System.Windows.Forms.ToolStripMenuItem tsInitiationNotes;
        private System.Windows.Forms.ContextMenuStrip cmsMetamagic;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicAddArt;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicAddEnchantment;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicAddEnhancement;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicAddMetamagic;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicAddRitual;
        private System.Windows.Forms.ToolStripMenuItem tsMetamagicNotes;
        private System.Windows.Forms.Label lblContactArchtypeLabel;
        private System.Windows.Forms.Label lblContactLocationLabel;
        private System.Windows.Forms.Label lblContactNameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ContextMenuStrip cmsTechnique;
        private System.Windows.Forms.ToolStripMenuItem tsAddTechniqueNotes;
        private System.Windows.Forms.Label lblContactPoints;
        private System.Windows.Forms.Label lblContactPoints_Label;
        private System.Windows.Forms.Button cmdLifeModule;
        private System.Windows.Forms.TreeView treCritterPowers;
        private System.Windows.Forms.Label lblWeaponRating;
        private System.Windows.Forms.Label lblWeaponRatingLabel;
        private System.Windows.Forms.Button btnCreateBackstory;
        private ElasticComboBox cboGearDataProcessing;
        private ElasticComboBox cboGearFirewall;
        private ElasticComboBox cboGearSleaze;
        private ElasticComboBox cboGearAttack;
        private ElasticComboBox cboVehicleGearDataProcessing;
        private ElasticComboBox cboVehicleGearFirewall;
        private ElasticComboBox cboVehicleGearSleaze;
        private ElasticComboBox cboVehicleGearAttack;
        private System.Windows.Forms.TabPage tabDefences;
        private System.Windows.Forms.Label lblSpellDefenceDirectSoakPhysicalLabel;
        private LabelWithToolTip lblSpellDefenceDirectSoakMana;
        private System.Windows.Forms.Label lblSpellDefenceDirectSoakManaLabel;
        private LabelWithToolTip lblSpellDefenceIndirectSoak;
        private System.Windows.Forms.Label lblSpellDefenceIndirectSoakLabel;
        private LabelWithToolTip lblSpellDefenceIndirectDodge;
        private System.Windows.Forms.Label lblSpellDefenceIndirectDodgeLabel;
        private System.Windows.Forms.Label lblCounterspellingDiceLabel;
        private System.Windows.Forms.NumericUpDown nudCounterspellingDice;
        private LabelWithToolTip lblSpellDefenceManipPhysical;
        private System.Windows.Forms.Label lblSpellDefenceManipPhysicalLabel;
        private LabelWithToolTip lblSpellDefenceManipMental;
        private System.Windows.Forms.Label lblSpellDefenceManipMentalLabel;
        private LabelWithToolTip lblSpellDefenceIllusionPhysical;
        private System.Windows.Forms.Label lblSpellDefenceIllusionPhysicalLabel;
        private LabelWithToolTip lblSpellDefenceIllusionMana;
        private System.Windows.Forms.Label lblSpellDefenceIllusionManaLabel;
        private LabelWithToolTip lblSpellDefenceDecAttWIL;
        private LabelWithToolTip lblSpellDefenceDecAttLOG;
        private LabelWithToolTip lblSpellDefenceDecAttINT;
        private LabelWithToolTip lblSpellDefenceDecAttCHA;
        private LabelWithToolTip lblSpellDefenceDecAttSTR;
        private System.Windows.Forms.Label lblSpellDefenceDecAttWILLabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttLOGLabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttINTLabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttCHALabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttSTRLabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttREALabel;
        private System.Windows.Forms.Label lblSpellDefenceDecAttAGILabel;
        private LabelWithToolTip lblSpellDefenceDecAttREA;
        private LabelWithToolTip lblSpellDefenceDecAttAGI;
        private LabelWithToolTip lblSpellDefenceDecAttBOD;
        private System.Windows.Forms.Label lblSpellDefenceDecAttBODLabel;
        private LabelWithToolTip lblSpellDefenceDetection;
        private System.Windows.Forms.Label lblSpellDefenceDetectionLabel;
        private LabelWithToolTip lblSpellDefenceDirectSoakPhysical;
        private System.Windows.Forms.TreeView treMetamagic;
        private System.Windows.Forms.Label lblVehiclePowertrainLabel;
        private System.Windows.Forms.Label lblVehicleWeaponsmod;
        private System.Windows.Forms.Label lblVehicleProtection;
        private System.Windows.Forms.Label lblVehiclePowertrain;
        private System.Windows.Forms.Label lblVehicleCosmeticLabel;
        private System.Windows.Forms.Label lblVehicleElectromagneticLabel;
        private System.Windows.Forms.Label lblVehicleBodymodLabel;
        private System.Windows.Forms.Label lblVehicleWeaponsmodLabel;
        private System.Windows.Forms.Label lblVehicleProtectionLabel;
        private System.Windows.Forms.Label lblVehicleBodymod;
        private System.Windows.Forms.Label lblVehicleCosmetic;
        private System.Windows.Forms.Label lblVehicleElectromagnetic;
        private System.Windows.Forms.Label lblVehicleDroneModSlots;
        private System.Windows.Forms.Label lblVehicleDroneModSlotsLabel;
        private System.Windows.Forms.Label lblCyberlimbSTR;
        private System.Windows.Forms.Label lblCyberlimbAGI;
        private System.Windows.Forms.Label lblCyberlimbSTRLabel;
        private System.Windows.Forms.Label lblCyberlimbAGILabel;
        private System.Windows.Forms.TabPage tabSkills;
        private UI.Skills.SkillsTabUserControl tabSkillUc;
        private System.Windows.Forms.Button cmdCreateStackedFocus;
        private System.Windows.Forms.Label lblFoci;
        private System.Windows.Forms.TreeView treFoci;
        private System.Windows.Forms.Label lblVehicleSeats;
        private System.Windows.Forms.Label lblVehicleSeatsLabel;
        private System.Windows.Forms.Label lblAINormalProgramsBP;
        private System.Windows.Forms.Label lblBuildAINormalPrograms;
        private System.Windows.Forms.Label lblAIAdvancedProgramsBP;
        private System.Windows.Forms.Label lblBuildAIAdvancedPrograms;
        private System.Windows.Forms.TabPage tabAdvancedPrograms;
        private System.Windows.Forms.Button cmdAddAIProgram;
        private System.Windows.Forms.Label lblAIProgramsRequires;
        private System.Windows.Forms.Label lblAIProgramsRequiresLabel;
        private System.Windows.Forms.Label lblAIProgramsSource;
        private System.Windows.Forms.Label lblAIProgramsSourceLabel;
        private System.Windows.Forms.TreeView treAIPrograms;
        private System.Windows.Forms.Button cmdDeleteAIProgram;
        private System.Windows.Forms.ContextMenuStrip cmsAdvancedProgram;
        private System.Windows.Forms.ToolStripMenuItem tsAddAdvancedProgramOption;
        private System.Windows.Forms.ToolStripMenuItem tsAIProgramNotes;
        private System.Windows.Forms.Label lblHandedness;
        private ElasticComboBox cboPrimaryArm;
        private System.Windows.Forms.CheckBox chkIsMainMugshot;
        private System.Windows.Forms.Label lblNumMugshots;
        private System.Windows.Forms.NumericUpDown nudMugshotIndex;
        private System.Windows.Forms.Label lblTraditionSource;
        private System.Windows.Forms.Label lblTraditionSourceLabel;
        private PowersTabUserControl tabPowerUc;
        private System.Windows.Forms.Label lblBuildRitualsBPLabel;
        private System.Windows.Forms.Label lblBuildRitualsBP;
        private System.Windows.Forms.Label lblBuildPrepsBPLabel;
        private System.Windows.Forms.Label lblBuildPrepsBP;
        private System.Windows.Forms.FlowLayoutPanel pnlAttributes;
        private System.Windows.Forms.Label lblPBuildSpecial;
        private System.Windows.Forms.Label lblPBuildSpecialLabel;
        private System.Windows.Forms.CheckBox chkPrototypeTranshuman;
        private System.Windows.Forms.Label lblQualityLevelLabel;
        private System.Windows.Forms.NumericUpDown nudQualityLevel;
        private System.Windows.Forms.Label lblWeaponRangeAlternate;
        private System.Windows.Forms.Label lblWeaponRangeMain;
        private System.Windows.Forms.Label lblWeaponAlternateRangeExtreme;
        private System.Windows.Forms.Label lblWeaponAlternateRangeLong;
        private System.Windows.Forms.Label lblWeaponAlternateRangeMedium;
        private System.Windows.Forms.Label lblWeaponAlternateRangeShort;
        private System.Windows.Forms.Label lblVehicleWeaponRangeAlternate;
        private System.Windows.Forms.Label lblVehicleWeaponRangeMain;
        private System.Windows.Forms.Label lblVehicleWeaponAlternateRangeExtreme;
        private System.Windows.Forms.Label lblVehicleWeaponAlternateRangeLong;
        private System.Windows.Forms.Label lblVehicleWeaponAlternateRangeMedium;
        private System.Windows.Forms.Label lblVehicleWeaponAlternateRangeShort;
        private System.Windows.Forms.Label lblVehicleWeaponDicePoolLabel;
        private System.Windows.Forms.Label lblVehicleWeaponDicePool;
        private System.Windows.Forms.ToolStripMenuItem mnuSpecialKarmaValue;
        private System.Windows.Forms.Button cmdCyberwareChangeMount;
        private System.Windows.Forms.Button cmdVehicleCyberwareChangeMount;
        private System.Windows.Forms.ContextMenuStrip cmsGearAllowRename;
        private System.Windows.Forms.ToolStripMenuItem tsGearAllowRenameExtra;
        private System.Windows.Forms.ToolStripMenuItem tsGearAllowRenameAddAsPlugin;
        private System.Windows.Forms.ToolStripMenuItem tsGearAllowRenameName;
        private System.Windows.Forms.ToolStripMenuItem tsGearAllowRenameNotes;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleMountWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleMountWeaponAdd;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleMountWeaponAccessory;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleMountWeaponUnderbarrel;
        private System.Windows.Forms.TabPage tabRelationships;
        private System.Windows.Forms.Button cmdContactsExpansionToggle;
        private System.Windows.Forms.Button cmdSwapContactOrder;
        private System.Windows.Forms.ToolStripMenuItem tsWeaponLocationAddWeapon;
        private System.Windows.Forms.ToolStripMenuItem tsGearLocationAddGear;
        private System.Windows.Forms.ToolStripMenuItem tsVehicleLocationAddVehicle;
        private System.Windows.Forms.CheckBox chkVehicleActiveCommlink;
        private System.Windows.Forms.Label lblPrototypeTranshumanESSLabel;
        private System.Windows.Forms.Label lblPrototypeTranshumanESS;
        private System.Windows.Forms.Label lblVehicleWeaponAccuracyLabel;
        private System.Windows.Forms.Label lblVehicleWeaponAccuracy;
        private System.Windows.Forms.ToolStripMenuItem tsEditWeaponMount;
        private System.Windows.Forms.ContextMenuStrip cmsAddContact;
        private System.Windows.Forms.ToolStripMenuItem tsAddFromFile;
        private Chummer.BufferedTableLayoutPanel tlpKarmaSummary;
        private Chummer.BufferedTableLayoutPanel tlpOtherInfo;
        private Chummer.BufferedTableLayoutPanel tlpSpellDefense;
        private System.Windows.Forms.Label lblWeaponCapacity;
        private System.Windows.Forms.Label lblWeaponCapacityLabel;
        private Chummer.BufferedTableLayoutPanel tblLifestyleDetails;
        private Chummer.BufferedTableLayoutPanel tableLayoutPanel2;
	    private System.Windows.Forms.TabPage tabDrugs;
	    private System.Windows.Forms.Button btnDeleteCustomDrug;
	    private System.Windows.Forms.TreeView treCustomDrugs;
	    private System.Windows.Forms.Button btnCreateCustomDrug;
	    private System.Windows.Forms.Label lblDrugComponents;
	    private System.Windows.Forms.Label lblDrugCost;
	    private System.Windows.Forms.Label lblDrugCostLabel;
	    private System.Windows.Forms.Label lblDrugAvail;
	    private System.Windows.Forms.Label lblDrugAvailabel;
	    private System.Windows.Forms.Label lblDrugCategory;
	    private System.Windows.Forms.Label lblDrugCategoryLabel;
	    private System.Windows.Forms.Label lblDrugName;
	    private System.Windows.Forms.Label lblDrugNameLabel;
	    private System.Windows.Forms.Label lblDrugAddictionRating;
	    private System.Windows.Forms.Label lblDrugAddictionThreshold;
	    private System.Windows.Forms.Label lblDrugAddictionThresholdLabel;
	    private System.Windows.Forms.Label lblDrugComponentsLabel;
	    private System.Windows.Forms.Label lblDrugAddictionRatingLabel;
	    private System.Windows.Forms.Label lblDrugGrade;
	    private System.Windows.Forms.Label lblDrugGradeLabel;
	    private System.Windows.Forms.NumericUpDown nudDrugQty;
	    private System.Windows.Forms.Label lblDrugQtyLabel;
        private Chummer.BufferedTableLayoutPanel tblDrugInfo;
        private System.Windows.Forms.Label lblDrugEffectLabel;
        private System.Windows.Forms.Label lblDrugEffect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Chummer.BufferedTableLayoutPanel tlpMagician;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private Chummer.BufferedTableLayoutPanel tlpTechnomancer;
        private System.Windows.Forms.Label lblParagonInformation;
        private System.Windows.Forms.Label lblParagonLabel;
        private System.Windows.Forms.Label lblParagon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private Chummer.BufferedTableLayoutPanel tlpAdvancedPrograms;
        private Chummer.BufferedTableLayoutPanel tlpCommon;
        private Chummer.BufferedTableLayoutPanel tlpCommonLeftSide;
        private Chummer.BufferedTableLayoutPanel tlpCommonBottomLeftSide;
        private System.Windows.Forms.TextBox txtAlias;
        private UI.Shared.LimitTabUserControl lmtControl;
        private Chummer.BufferedTableLayoutPanel tlpMartialArts;
        private Chummer.BufferedTableLayoutPanel tlpInitiation;
        private Chummer.BufferedTableLayoutPanel tlpCritter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Chummer.BufferedTableLayoutPanel tlpCyberware;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private Chummer.BufferedTableLayoutPanel tlpCyberwareMatrix;
        private Chummer.BufferedTableLayoutPanel tlpVehicles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private Chummer.BufferedTableLayoutPanel tlpVehicleWeapon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private Chummer.BufferedTableLayoutPanel tlpCharacterInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel12;
        private Chummer.BufferedTableLayoutPanel tlpGear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel13;
        private Chummer.BufferedTableLayoutPanel tlpArmor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel14;
        private Chummer.BufferedTableLayoutPanel tlpWeapons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel15;
        private Chummer.BufferedTableLayoutPanel tableLayoutPanel4;
        private Chummer.BufferedTableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tlpContacts;
        private System.Windows.Forms.TableLayoutPanel tlpEnemies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tlpPets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel17;
        private System.Windows.Forms.FlowLayoutPanel flpInitiationCheckBoxes;
        private System.Windows.Forms.FlowLayoutPanel flpInitiationButtons;
        private System.Windows.Forms.CheckBox chkCyberwareHomeNode;
        private System.Windows.Forms.CheckBox chkCyberwareActiveCommlink;
        private System.Windows.Forms.FlowLayoutPanel flpCyberware;
        private System.Windows.Forms.GroupBox gpbEssenceConsumption;
        private System.Windows.Forms.TableLayoutPanel tlpCyberwareEssenceConsumption;
        private System.Windows.Forms.TableLayoutPanel tlpCyberwareCommon;
        private System.Windows.Forms.FlowLayoutPanel flpNuyen;
    }
}
