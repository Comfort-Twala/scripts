""" 
Script to scrape South African Universities Short description and links to their respective sites
source: africauniversities.org/south-africa/

info = {
	{
		"university": abc,
		"description": "Where you're suppose to learn something apparently.",
		"page_link": "www.abcity.ac.za",
		"img_link": "https://abcity.ac.za/uploads/logo-img"
	}
}
"""

## IMPORTS
import requests, json
from bs4 import BeautifulSoup as bs4

## CONSTANTS
URL = "http://africauniversities.org/south-africa/"
unies = []
names = []
descriptions = []

site = requests.get(URL)
soup = bs4(site.text, 'html.parser')
container = soup.find('div', class_= "et_pb_module et_pb_accordion et_pb_accordion_0")

for i in range(1, 23):
	unies.append(container.find('div', class_= f"et_pb_toggle et_pb_module et_pb_accordion_item et_pb_accordion_item_{i} et_pb_toggle_close"))

for uni in unies:
	names.append(uni.find('h5', class_= f"et_pb_toggle_title").text)
	descriptions.append(uni.find('div', class_= f"et_pb_toggle_content clearfix").text)


