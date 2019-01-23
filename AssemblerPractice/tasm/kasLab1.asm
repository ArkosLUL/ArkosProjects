;.486
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'
sList dw 'ya', 'da'
dupping DD 2 Dup ( 2 dup  ('op',2)); 
const1 DW 42
c1 EQU 'kek'
positintdecnumber1 dw -33
negatintdecnumber dt 1000
positintdecnumber2 db -80

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov ax, 'ya'
   mov const1, -200
   mov bx, const1
   mov es, ax
   mov bl, al
   mov c1, al
   ret
main endp
cseg ends
end main