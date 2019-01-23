;.486
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

p1 DW -4,-15,4,2,8
p2 DB 'CS','C++','C#'
p3 DB 99
p4 DW 5 DUP (?)
p5 DB ?
p6 DB -0Fh

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov AX,p4
   ;mov DS,ES сегментные регистры
   ;mov AX,AL разной длины
   mov AL,'c'
   mov AL,12D
   mov bx, offset p3
   mov AX,[BX]
   
   ret
main endp
cseg ends
end main