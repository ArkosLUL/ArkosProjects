; Косогов Артем Сергеевич ПЗ-17-1
; y = 5*(x+b^2) + 4*a*c^2 - x+4/2*b+1
; b!=-0.5
segst	segment para stack  'stack'
	db	64 dup('stack   ')
segst	ends
dseg segment 'data'

a db 1
b db 2
c db 3
x dw 4
y dw 0
buf dw 0

dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
   push ds
   sub AX,AX
   push AX
   mov ax,dseg
   mov ds,ax
   
   mov al, b ; al = b
   imul b ; ax = ax * b
   add y, ax ; y = y + ax
   mov bx, x ; bx = x
   add y, bx ; y = y + x
   mov ax, y ; ax = y
   mov buf, 5 ; buf = 5
   imul buf ; ax = ax * buf
   
   mov y,ax ; y = ax
   mov buf, 0 ; buf = 0
   
   
   mov al, c ; al = c
   imul c ; ax = ax * c
   imul a ; ax = ax * a
   mov buf, 4 ; buf = 4
   imul buf ; ax = ax * buf

   mov buf, 0 ; buf = 0     
   add y, ax ; y = y + buf
   
   

   add x, 4 ; x = x + 4
   mov al, b ; al = 2
   mov bl, 2 ; bl = 2
   imul bl ; ax = al * bl
   mov buf, ax ; buf = ax
   inc buf ; buf = buf + 1
   mov ax, x ; ax = x
   mov bx, buf ; bx = buf
   idiv bl ; ah = ax / bl
   mov al, ah ; al = ah
   cbw ; ax = al
   sub y, ax ; y = y - ax
   
   ret
main endp
cseg ends
end main