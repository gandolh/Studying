# run the compillation
gcc -c main.c -o main.o
gcc -o main main.o -lmy_math -L.
LD_LIBRARY_PATH=. ./main
