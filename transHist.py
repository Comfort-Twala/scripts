""" 
Python script to download bank transaction history from bank website as csv
"""

# Imports 
import secret, time
from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

# CONSTANTS
USER = secret.USERNAME
PWD = secret.PASSWORD
URL = 'https://www.online.fnb.co.za/'

### Open browser and go to banking page
driver = webdriver.Firefox()
driver.get(URL)

### Get user and password fields and pass values
wait = WebDriverWait(driver, 15)

loginField = wait.until(EC.visibility_of_element_located((By.ID, "user")))
pwField = driver.find_element_by_id("pass")
loginField.send_keys(USER)
time.sleep(0.5)
pwField.send_keys(PWD)
driver.find_element_by_id("OBSubmit").click()

wait.until(EC.visibility_of_element_located((By.ID, "welcomeContainer")))
bankAcc = driver.find_elements_by_class_name("ui-icon_reservedMyBankAccounts")[1].click()
time.sleep(1)
driver.find_element_by_id("rowMoreButton0").click()
time.sleep(1)
driver.find_elements_by_id("actionMenuButton2")[2].click()
time.sleep(1)
driver.find_element_by_class_name("downloadButton").click()
time.sleep(1)
driver.find_element_by_id("downloadFormat_dropId").click()
time.sleep(1)
driver.find_element_by_xpath("//li[@data-value='csv']").click()
time.sleep(1)
driver.find_element_by_id("mainDownloadBtn").click()