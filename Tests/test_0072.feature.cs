﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AwgTestFramework.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class TC_72VerifyMTONeCOMPileCANCelSyntaxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "test_0072.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")))
            {
                AwgTestFramework.Tests.TC_72VerifyMTONeCOMPileCANCelSyntaxFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void VerifyMTONeCOMPileCANCelSyntax(string command, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify MTONe:COMPile:CANCel Syntax", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 5
testRunner.Given("AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.And("the family is 70k for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.And("a reset for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
testRunner.When("I load the MultiTone module for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And("I wait for operation complete for AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("I send the \"{0}\" command for AWG 1", command), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
testRunner.Then("there should be no error on AWG 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMPile:CANCel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMPile:CANCel")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONeCOMPileCANCel()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTONe:COMPile:CANCel", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMPile:CANC")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMPile:CANC")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONeCOMPileCANC()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTONe:COMPile:CANC", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMP:CANCel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMP:CANCel")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONeCOMPCANCel()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTONe:COMP:CANCel", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:COMP:CANC")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:COMP:CANC")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONeCOMPCANC()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTONe:COMP:CANC", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMPile:CANCel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMPile:CANCel")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONCOMPileCANCel()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTON:COMPile:CANCel", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMPile:CANC")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMPile:CANC")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONCOMPileCANC()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTON:COMPile:CANC", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMP:CANCel")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMP:CANCel")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONCOMPCANCel()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTON:COMP:CANCel", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-72  ]  Verify MTONe:COMPile:CANCel Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:COMP:CANC")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:COMP:CANC")]
        public virtual void VerifyMTONeCOMPileCANCelSyntax_MTONCOMPCANC()
        {
            this.VerifyMTONeCOMPileCANCelSyntax("MTON:COMP:CANC", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion