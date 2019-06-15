all : program1.o program1 install

CFLAGS = -Wall -g

%.o:%.c
	gcc $(CFLAGS) $< -o $@


program1.o : src/main.c src/a_functions.c src/b_functions.c src/c_functions.c src/d_functions.c
	gcc -c src/main.c src/a_functions.c src/b_functions.c src/c_functions.c src/d_functions.c

program1 : main.o a_functions.o b_functions.o c_functions.o d_functions.o
	gcc -o program1 main.o a_functions.o b_functions.o c_functions.o d_functions.o 

clean :
	rm program1 *.o

PREFIX = /home/pi/Documents

.PHONY: install
install: program1
	mkdir -p $(DESTDIR)$(PREFIX)/bin
	cp $< $(DESTDIR)$(PREFIX)/bin/program1

.PHONY: uninstall
uninstall:
	rm -f $(DESTDIR)$(PREFIX)/bin/program1
