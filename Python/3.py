import requests 

name_file='699991.txt'
while True:
	u='https://stepic.org/media/attachments/course67/3.6.3/'+name_file
	r=requests.get(u.strip())
	print(r.text)
	if(r.text[0]=="W" and r.text[1]=="e"):
		print(r.text)
		break
	name_file=str(r.text)