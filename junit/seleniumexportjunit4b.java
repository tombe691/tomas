package com.example.tests;

import com.thoughtworks.selenium.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.util.regex.Pattern;

public class seleniumexportjunit4b {
	private Selenium selenium;

	@Before
	public void setUp() throws Exception {
		selenium = new DefaultSelenium("localhost", 4444, "*chrome", "http://www.molk.it/");
		selenium.start();
	}

	@Test
	public void testSeleniumexportjunit4b() throws Exception {
		selenium.open("/");
		selenium.click("link=MÖT STUDENTERNA");
		selenium.click("link=MÖT STUDENTERNA");
		selenium.click("link=UTVECKLARE");
		selenium.click("link=UTVECKLARE");
		selenium.waitForPageToLoad("30000");
		selenium.click("css=img[alt=\"Martin G\"]");
		selenium.click("css=img[alt=\"Martin G\"]");
		selenium.waitForPageToLoad("30000");
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
