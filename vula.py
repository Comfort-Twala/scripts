"""
Python Script to automatically log into Vula (University student portal)
requirements: selenium
"""
### Imports
import secret, time
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

### Constants
URL = "https://vula.uct.ac.za/portal/login"
USER = secret.USER
PSSWORD = secret.PASS
PROFILE = secret.PROFILE

### Open browser and go to portal page
fp = webdriver.FirefoxProfile(PROFILE)
driver = webdriver.Firefox(fp)
driver.get(URL)

### Get user and password fields and pass values
wait = WebDriverWait(driver, 10)

loginField = wait.until(EC.visibility_of_element_located((By.ID, "userNameInput")))
pwField = driver.find_element_by_id("passwordInput")
loginField.send_keys(USER)
time.sleep(0.5)
pwField.send_keys(PSSWORD)
driver.find_element_by_id("submitButton").click()
