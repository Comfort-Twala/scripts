"""
Python Script to automatically log into Vula (University student portal)
requirements: selenium, pwinput, webdriver-manager
"""
### Imports
import time, pwinput, os
from selenium import webdriver
from selenium.webdriver.chrome.service import Service
from webdriver_manager.chrome import ChromeDriverManager
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

### Constants
BROWSER_PATH = os.popen("which brave").read().strip()  ## Set path of the browser
OPTION = webdriver.ChromeOptions()
OPTION.binary_location = BROWSER_PATH
BROWSER = webdriver.Chrome(service=Service(ChromeDriverManager().install()), options=OPTION)

URL = "https://vula.uct.ac.za/portal/login"
USER = "twlcom001"
PSSWORD = pwinput.pwinput(prompt="Enter Vula password: ", mask="#")

### Open browser and go to portal page
driver = BROWSER
driver.get(URL)

### Get user and password fields and pass values
wait = WebDriverWait(driver, 10)

loginField = wait.until(EC.visibility_of_element_located((By.ID, "userNameInput")))
pwField = driver.find_element("id", "passwordInput")
loginField.send_keys(USER)
time.sleep(0.5)
pwField.send_keys(PSSWORD)
driver.find_element("id", "submitButton").click()
