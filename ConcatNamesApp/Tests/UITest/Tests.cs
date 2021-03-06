﻿using NUnit.Framework;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void FirstNameTextIsDisplayed()
		{
			AppResult[] results = app.WaitForElement(c => c.Marked("First name"));
			app.Screenshot("Welcome screen.");

			Assert.IsTrue(results.Any());
		}

        [Test]
        public void LastNameTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Last name"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }

        [Test]
        public void ButtonConcatIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Concat"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }

        [Test]
        public void ConcatButtonWorks()
        {
            app.EnterText("EntryFirstName", "It");
            app.EnterText("EntryLastName", "Works");
            app.Tap("ButtonConcat");
            var result = app.Query("LabelResult").FirstOrDefault(oo => oo.Text == "It Works!");
            Assert.IsTrue(result != null);
        }
    }
}
