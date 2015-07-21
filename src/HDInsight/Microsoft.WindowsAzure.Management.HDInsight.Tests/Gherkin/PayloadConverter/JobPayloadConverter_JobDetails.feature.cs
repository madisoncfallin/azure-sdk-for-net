﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Microsoft.WindowsAzure.Management.HDInsight.Tests.Gherkin.PayloadConverter
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class JobPayloadConverter_JobDetailsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JobPayloadConverter_JobDetails.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "JobPayloadConverter_JobDetails", "In order to get and receive data from the server\nAs a component of the SDK\nI want" +
                    " to be able to serialize and deserialize data going back and forth from the serv" +
                    "er.", ProgrammingLanguage.CSharp, new string[] {
                        "CheckIn"});
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "JobPayloadConverter_JobDetails")))
            {
                Microsoft.WindowsAzure.Management.HDInsight.Tests.Gherkin.PayloadConverter.JobPayloadConverter_JobDetailsFeature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can serialize a job detail with an httpStatusCode not Accepted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobPayloadConverter_JobDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanSerializeAJobDetailWithAnHttpStatusCodeNotAccepted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can serialize a job detail with an httpStatusCode not Accepted", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I have a job details object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
   testRunner.And("the request will return the http status code \"BadGateway\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("I serialize the object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("the value of the serialized output should be equivalent with the original", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can serialize a job detail with an errorCode")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobPayloadConverter_JobDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanSerializeAJobDetailWithAnErrorCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can serialize a job detail with an errorCode", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
    testRunner.Given("I have a job details object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
   testRunner.And("the request will return the error id \"ClusterNotFound\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.When("I serialize the object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
  testRunner.Then("the value of the serialized output should be equivalent with the original", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can serialize a job detail with a full pacage of data")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JobPayloadConverter_JobDetails")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanSerializeAJobDetailWithAFullPacageOfData()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can serialize a job detail with a full pacage of data", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("I have a job details object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
   testRunner.And("the job has an Exit Code of 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
   testRunner.And("the job has a Job Id of \"job123\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
   testRunner.And("the job has the Logical Output Path \"http://logicalOutputPath\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
   testRunner.And("the job has the following query:", "SOME HIVE QUERY", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
   testRunner.And("the job has the Status Code \"Initializing\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
   testRunner.And("the job has was submitted on \"Wednesday, June 26, 2013 6:31:02 PM\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
   testRunner.And("the job has the name \"My First Job\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
   testRunner.And("the job has the Physical Output Path \"asv://my@storage/logicalOutputPath\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.When("I serialize the object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
  testRunner.Then("the value of the serialized output should be equivalent with the original", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
