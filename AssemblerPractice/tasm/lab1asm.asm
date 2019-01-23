segst	segment para stack  'stack'
	db	64 dup('stack678')
segst	ends
dseg segment 'data'
p1 DB 5 DUP (?) 
p2 DB 13
p3 DB -103
p4 DB 1CH 
p5 DB -40H
p6 DB 'e' 
dseg ends
cseg segment
  assume ds:dseg,cs:cseg,ss:segst
main proc far
MAS DB 'HELLO'
mov AX, MAS
LEA BL, p2 
MOV AL, [BL]
MOV AX, 5
MOV BX, AX
;MOV 'kk', AL ERROR
MOV MAS, AX
MOV BL, AL
;   push ds
;   sub AX,AX
;   push AX
;   mov ax,dseg
;   mov ds,ax
   
;;   mov DL,El
;   mov AL,27
;   mov BX,p6
;   mov p5,BX
;   mov AH,p4
;   mov CX,1024
   ret
main endp
cseg ends
end main