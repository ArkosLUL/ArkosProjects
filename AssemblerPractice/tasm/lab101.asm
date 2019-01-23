;.486
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

p1 DW 5,6,14,20,33
p2 DW 3 dup(1,2,3)
p3 DT 5Ah
p4 DW ?
p5 DB 18h
p6 DB '%'


dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   mov ax,p1
   mov al,'#'
   mov ds,ax
   mov p5,al 
   mov ax,p1
   mov p6,al	
	  
   ret
main endp
cseg ends
end main