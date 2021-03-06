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
    public partial class TC_103VerifyMTONeCHIRpSTIMeSyntaxFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "test_0103.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax")))
            {
                AwgTestFramework.Tests.TC_103VerifyMTONeCHIRpSTIMeSyntaxFeature.FeatureSetup(null);
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
        
        public virtual void VerifyMTONeCHIRpSTIMeSyntax(string command, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify MTONe:CHIRp:STIMe Syntax", exampleTags);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:CHIRp:STIMe 1e-3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:CHIRp:STIMe 1e-3")]
        public virtual void VerifyMTONeCHIRpSTIMeSyntax_MTONeCHIRpSTIMe1E_3()
        {
            this.VerifyMTONeCHIRpSTIMeSyntax("MTONe:CHIRp:STIMe 1e-3", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:CHIR:STIM 1e-3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:CHIR:STIM 1e-3")]
        public virtual void VerifyMTONeCHIRpSTIMeSyntax_MTONCHIRSTIM1E_3()
        {
            this.VerifyMTONeCHIRpSTIMeSyntax("MTON:CHIR:STIM 1e-3", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTONe:CHIRp:STIMe 1 kS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTONe:CHIRp:STIMe 1 kS")]
        public virtual void VerifyMTONeCHIRpSTIMeSyntax_MTONeCHIRpSTIMe1KS()
        {
            this.VerifyMTONeCHIRpSTIMeSyntax("MTONe:CHIRp:STIMe 1 kS", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "[ TC-103  ]  Verify MTONe:CHIRp:STIMe Syntax")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "MTON:CHIR:STIM 1 kS")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:command", "MTON:CHIR:STIM 1 kS")]
        public virtual void VerifyMTONeCHIRpSTIMeSyntax_MTONCHIRSTIM1KS()
        {
            this.VerifyMTONeCHIRpSTIMeSyntax("MTON:CHIR:STIM 1 kS", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
