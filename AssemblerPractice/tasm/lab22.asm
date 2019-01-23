;PAVLIUK DMITRIY PZ-17-1
;y = x*x + a*a*b*b*x - (x*x + a*a/a+1)
;у = 154 с остачей при данных значениях
segst	segment para stack  'stack'
	db	64 dup('stack678')
segst	ends
dseg segment 'data'
a DB 2
b DB 3
c DB -2
x DW 4
y DW 0
bufb DB 0
bufw DW 0
bufw2 DW 0 
bufw3 DW 0 
bufw4 DW 0
bufw5 DW 0
dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
  
	mov AX,x
	imul AX
	imul AX, 4
	mov AL, a
	mov bufw, AX
	cbw
	Add bufw, AL
	mov AL a
	sub AL b
	imul Al, 3
	cbw
	idiv bufw2, AX
	mov AL, b
	mov AX, x
	mov bufw3, x
	imul AX, bufw3
	imul AX, bufw3
	mov bufw4, AX
	cbw
	imul bufw4, AX
	mov AL, a
	mov AX, x
	imul AX
	mov bufw5, AX
	cbw
	imul bufw5, AX
	sub bufw4, bufw5
	add bufw2, bufw4









  
 
   
   
   

   
   ret
main endp
cseg ends
end main