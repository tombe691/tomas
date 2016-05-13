package com.example.tests;

import com.thoughtworks.selenium.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.*;
import java.util.regex.Pattern;

public class seleniumjunit4remotetest {
	private Selenium selenium;

	@Before
	public void setUp() throws Exception {
		selenium = new DefaultSelenium("localhost", 4444, "*chrome", "www.svt.se");
		selenium.start();
	}

	@Test
	public void testSeleniumjunit4remotetest() throws Exception {
		selenium.open("/");
		selenium.selectFrame("contentFrame");
		selenium.click("css=span.headline-biggest");
		selenium.waitForPageToLoad("30000");
		selenium.selectWindow("null");
		selenium.click("link=Barn­kanalen");
		selenium.waitForPageToLoad("30000");
	}

	@After
	public void tearDown() throws Exception {
		selenium.stop();
	}
}
