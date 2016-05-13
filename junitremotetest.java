package com.example.tests;

import com.thoughtworks.selenium.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.util.regex.Pattern;

public class junitremotetest {
	private Selenium selenium;

	@Before
	public void setUp() throws Exception {
		selenium = new DefaultSelenium("localhost", 4444, "*chrome", "https://github.com/");
		selenium.start();
	}

	@Test
	public void testJunitremotetest() throws Exception {
		selenium.open("/SeleniumHQ/selenium/wiki/SeIDEReleaseNotes");
		selenium.click("link=Support");
		selenium.waitForPageToLoad("30000");
		selenium.click("LOCATOR_DETECTION_FAILED");
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
