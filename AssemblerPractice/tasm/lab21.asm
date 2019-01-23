
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

a db 1
b db 2
x dw 4
y dw 0
buf dw 0
buf2 dw 0
temp db 0

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax

	mov ax, x;
	imul x;
	imul x;
	mov buf, ax;
	mov al, a;
	imul a;
	cbw
	imul ax;
	add buf, ax;
	mov al, b;
	cbw
	mov bl, 8
	imul bl;
	mov buf2, ax;
	inc buf2
	mov ax, buf;
	cwd
	idiv buf2
	mov y, ax
   
    mov ax, x;
	imul x;
	imul x;
	mov buf, ax;
	mov bx, buf
	mov al,a
	cbw
	imul buf;
	mov temp, 3
	idiv temp;
	cbw
	add y,ax
	
	mov al, a
	cbw
	imul x
	sub y, ax
	
	
   
   
   ret
main endp
cseg ends
end main