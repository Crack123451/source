import requests 

count=0
u='https://stepic.org/media/attachments/course67/3.6.2/050.txt'
r=requests.get(u.strip())
for i in r.text.splitlines():
	count+=1
print(count)