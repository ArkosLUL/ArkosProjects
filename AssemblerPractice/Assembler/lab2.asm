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
buf2 dw ?

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
   ;add y, ax ; y = y + ax
   ;mov bx, x ; bx = x
   add ax, x ; y = y + x
   ;mov ax, y ; ax = y
   mov bl, 5 ; buf = 5
   imul bl ;ax = ax * buf
   
   mov y,ax ; y = ax
   
   
   mov al, c ; al = c
   imul c ; ax = ax * c
   imul a ; ax = ax * a
   mov buf, ax ; 
   mov al, 4 ; buf = 4
   cbw
   imul buf ; ax = ax * buf
  
   add y, ax ; y = y + buf
   
   

   mov ax,x
   mov buf2, ax
   add buf2, 4 ; x = x + 4
   mov al, b ; al = 2
   mov bl, 2 ; bl = 2
   imul bl ; ax = al * bl
   mov buf, ax ; buf = ax
   inc buf ; buf = buf + 1
   mov ax, buf2 ; ax = x
   cwd
   ;mov bx, buf ; bx = buf
   idiv buf ; ah = ax / bl
   ;cbw ; ax = al
   sub y, ax ; y = y - ax
   
   ret
main endp
cseg ends
end main