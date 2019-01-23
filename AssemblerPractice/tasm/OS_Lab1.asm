; Новый проект tasm16 успешно создан
; Заполнен демо программой «Здравствуй, мир!»
.MODEL SMALL
.STACK 100h

.DATA
	sList DD 'dada', 'eto' , 'ya' 
dupping DD 2 Dup ( 2 dup (ullo)); 
const DW 42,146,-6
positintdecnumber1 dw -33
negatintdecnumber dt 1000
positintdecnumber2 db 80
.CODE
START:
    mov ax,@data
	mov ds,ax
    mov ah,9
    int 21h
    mov ah,4ch
    int 21h
END START