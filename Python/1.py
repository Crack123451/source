ls=[]
with open("text.txt", 'r') as fl:
	for i in fl:
		ls+=[i.strip()]

count=0
symbol=""
num=[]
itog=""
for i in ls:
	while count<len(i):
		if 'a'<=i[count]<='z':
			if(num!=[]):
				if len(num)==1:
					num=int(num[0])
				elif len(num)==2:
					num=int(num[0]+num[1])
				for i in range(0,num):
					itog+=symbol
			symbol=i[count]
			num=[]
		else:
			num+=[i[count]]
		count+=1
	i=itog
	count=0	
print(ls)
