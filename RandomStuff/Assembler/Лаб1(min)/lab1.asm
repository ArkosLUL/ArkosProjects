segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'
p1 DB 37,-5,14,0
p2 DT 129,-81
p3 DW -5,125,-210,15, p6
p4 DB 'winter','summer','Yes','0 9'
p5 DD 3 dup(22,-6,15), p6 
p6 DB -0b4H,7AH
p7 DB  10001111b
dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov p1,-32
   mov BX,27
   mov AL,BL
   mov BX,offset p3
   mov AX,[BX]
   mov DL,p7
   ret
main endp
cseg ends
end main