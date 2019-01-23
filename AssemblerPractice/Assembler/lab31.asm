;.486
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

mas1 db 2, 4, 8
	 db 1, 0, 8
	 db 1, 0, -3
len dw 3
buf db ?
bufw dw ?

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   lea bx, mas1
   mov al, byte ptr [bx+0]
   mov cx, len
   cycl1:
   push cx
   mov cx, len
   mov si,0
   cmp byte ptr [bx+di],0
   je zero
   jnge less_zero
   jnle over_zero
   
   mov cx, len
   zero: 
   mov byte ptr [bx+si], 0
   inc si
   loop zero
   jmp endc
   
   mov cx, len
   less_zero: 
   mov byte ptr [bx+si], -1
   inc si
   loop less_zero
   jmp endc
   
   mov cx, len
   over_zero: 
   mov byte ptr [bx+si], 1
   inc si
   loop over_zero
   jmp endc
   
   endc:
   
   pop cx
   add bx, len
   inc di
   loop cycl1
 
   mov ax, len
   imul len
   mov cx,ax
   mov si,0
   debug:
   mov al, mas1[si]
   mov buf, al
   cbw
   mov bufw, ax
   inc si 
   loop debug
   
   ret
main endp
cseg ends
end main