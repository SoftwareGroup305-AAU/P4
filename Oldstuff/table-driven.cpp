#include <iostream>

#define REJECT -1

const int transitions[2][10] = {
    { /*0*/  1, /*1*/  1, /*2*/  1, /*3*/  1, /*4*/  1, /*5*/  1, /*6*/  1, /*7*/  1, /*8*/  1, /*9*/  1},
    { /*0*/  1, /*1*/  1, /*2*/  1, /*3*/  1, /*4*/  1, /*5*/  1, /*6*/  1, /*7*/  1, /*8*/  1, /*9*/  1}
};

const int accept[] = { 0, 1};

int scan(void) {
    char ch;
    int state = 0;

    while (!accept[state]) {
        ch = getchar() - 'a';
        if (transitions[state][ch] == REJECT) {
            printf("invalid token!\n");
            return 0;
        } else {
            state = transitions[state][ch];
        }
    }
    return 1;
}

int main (void) {
    scan();

    return 0;
}