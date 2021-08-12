import secret, time, os, sendMail, geckodriver_autoinstaller
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

URL = "https://uct.service-now.com/sp?id=daily_screening"


def init_driver():
	geckodriver_autoinstaller.install()
	driver = webdriver.Firefox()
	driver.get(URL)
	wait = WebDriverWait(driver, 25)
	return driver, wait

def login(driver, wait):
	wait.until(EC.visibility_of_element_located((By.ID, "i0116"))).send_keys('twlcom001@myuct.ac.za')
	driver.find_element_by_id("idSIButton9").click()
	wait.until(EC.visibility_of_element_located((By.ID, "passwordInput"))).send_keys(secret.PASS)
	driver.find_element_by_id("submitButton").click()
	wait.until(EC.visibility_of_element_located((By.ID, "idBtn_Back"))).click()
	return driver.current_url

def completeCheck(driver, wait):
	pass

def takeScreenshot():
	os.system("gnome-screenshot --file=healthcheck.png")


driver, wait = init_driver()
url = login(driver, wait)
time.sleep(5)
takeScreenshot()
time.sleep(3)
driver.close()
sendMail.main(url)