name "hello-world"

org 100h

mov ax, 3
int 10h

mov ax, 1003h
mov bx, 0
int 10h

mov ax, 0b800h
mov ds, ax

mov [02h], 'H'
mov [04h], 'e'
mov [06h], 'l'
mov [08h], 'l'
mov [0ah], 'o'
mov [0ch], ' '
mov [0eh], 'W'
mov [10h], 'o'
mov [12h], 'r'
mov [14h], 'l'
mov [16h], 'd'
mov [18h], '!'

mov ah, 0
int 16h

ret
