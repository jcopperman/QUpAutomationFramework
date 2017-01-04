# QUp Test Automation Framework
A Selenium test automation framework that implements the Page Object Model pattern, with extra helpers for reading data from spreadsheets, a logger, html table reader, reporting and webservice helper. Uses global configuration so be sure to update the GlobalConfig.xml (soon to be moved to JSON instead) file with your system under test's relevant parameters.

This framework supports SpecFlow, the BDD syntax documentation tool for .Net. 

A sample test project is included to demonstrate the use of the framework. 

TODOS:
Add a IJavascriptExecutor helper for console related tests, a screenshot helper for taking screenshots on failure
and support for headless browser automation
