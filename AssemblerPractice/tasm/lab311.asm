;.486
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

mas1 db 2, 4, 8, 16, 20, 23, 27, 30, 3, 10, 17, 29, 65, 47, 18, 30, 19, 7, 33, 14
mas2 db 1, 3, 8, 20, 7, 5, 13, 9, 25, 26, 15, 37, 86, 42, 21, 10, 44, 90, 67, 14
len dw 20
quotient db ?
modulo db ?
count db 0

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov si, 0
   mov cx, len
   cycl1: push cx
   mov quotient,0
   mov modulo,0
   mov al,0
   mov count,0   
   mov al, mas1[si]
   cycl2: cmp al, mas2[si]
   jnge endc
   sub al,mas2[si]
   inc count
   loop cycl2
   endc:
   pop cx
   mov bl,count
   mov quotient, bl
   mov modulo, al
   inc si
   loop cycl1
   ret
main endp
cseg ends
end main