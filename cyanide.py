""" 
Script to download all comics on the Cyanide and Happiness website and save them locally.
"""

## IMPORTS 
import requests
from bs4 import BeautifulSoup as bs4

## CONSTANTS
URL = "https://explosm.net"

## Opening site and looping through every image downloading it
site = URL + "/comics/latest"
prev = True

while prev:
	page = requests.get(site)
	soup = bs4(page.text, 'html.parser')
	img = "https:" + soup.find('img', id = "main-comic")['src']
	name = img[img.rfind('/')+1:img.find(".png")+4]

	## Getting picture and saving it
	try:	
		r = requests.get(img, stream = True)
		with open(f"comics/{name}", "wb") as file:
			for chunk in r.iter_content():
				file.write(chunk)
			file.close()
	except:
		pass

	## Next picture
	try:
		prev_page = soup.find('a', class_ = "nav-previous")["href"]
		site = URL + prev_page
	except:
		prev = False

print("It is DONE!")