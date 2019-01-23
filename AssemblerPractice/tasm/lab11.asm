segst	segment para stack  'stack'
	db	64 dup('stack678')
segst	ends
dseg segment 'data'
sixteenNumber DB 5Bh
bufConst DB 12
const1 db 2*8
positiveInteger1 dt 1000
string dt 'privet' 
bufString db ?
positiveInteger2 dw 297
negativeSexteenNumber dw -7Fh
dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov al, 'u'
   mov bufString, 'o'
   mov ax, es
   mov bx, offset sixteenNumber
   mov al, [bx]
   mov ax, positiveInteger2
   mov es, positiveInteger2
   ret
main endp
cseg ends
end main