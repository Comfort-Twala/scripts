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
faults = ["\xa0", "\u200b", "\u2013", "\u2019", "\u2018"]
## lists to store data 
unies = []
names = []
descriptions = []
page_links = []
img_links = []

## Requesting site and parsing it to html 
site = requests.get(URL)
soup = bs4(site.text, 'html.parser')
container = soup.find('div', class_= "et_pb_module et_pb_accordion et_pb_accordion_0")

for i in range(1, 23):
	unies.append(container.find('div', class_= f"et_pb_toggle et_pb_module et_pb_accordion_item et_pb_accordion_item_{i} et_pb_toggle_close"))

for uni in unies:
	names.append(uni.find('h5', class_= f"et_pb_toggle_title").text)
	content = uni.find('div', class_= f"et_pb_toggle_content clearfix").text
	for fault in faults:
		content = content.replace(fault, " ")
	descriptions.append(".".join(content.split(".")[:-1]))
	page_links.append(uni.find('a')["href"])
	img_links.append(uni.find('img')["src"])

## Format lists to multilists
final_data = []
for uni in range(len(unies)):
	final_data.append(dict([("university", names[uni]), ("description", descriptions[uni]), ("page_links", page_links[uni][2:]), ("img_links", img_links[uni])]))

## Convert to json and write to file
with open("uninfo.json", 'w') as file:
	json.dump(final_data, file, indent = 4)
	file.close()

