#include <iostream>
#include <fstream>
#include <string>

enum token {
    INT_LIT,
    IDENT,
    LPAREN,
    RPAREN
};

enum token int_lit (std::string);
enum token ident (std::string);
bool iskeyword(void);

int main (void) {
    std::string str;
    std::ifstream file("testfile.iye");

    while (!file.eof()) {
        file >> str;
        for (char c : str) {
            if (isspace(c)) {
                continue;
            }
            else if (isdigit(c)) {
                int_lit(str);
                break;  
            }
            else if (isalpha(c)) {
                ident(str);
                break;
            }
            else if (c == '(') {
                std::cout << "LPAREN ";
                break;
            }
            else if (c == ')') {
                std::cout << "RPAREN ";
                break;
            }
        }
        // char character = file.get();
    }

    // while (getline(file, str)) {
    //     for (char c : str) {
    //         std::string s(1, c);
    //         std::cout << s;
    //         if (isdigit(c)) {
    //             return int_lit();
    //         }
    //         else {
    //             continue;
    //         }
    //     }
    // }

    file.close();
    return 0;
}

enum token int_lit (std::string str) {
    for (char c : str) {
        if (isdigit(c)) {
            
        }
        else {
            break;
        }
    }
    std::cout << "INT_LIT ";
    return INT_LIT;
}

enum token ident (std::string str) {
    for (char c : str) {
        if (isalnum(c)) {
            
        }
        else {
            break;
        }
    }
    std::cout << "IDENT ";
    return IDENT;
}

bool iskeyword(void) {
    return false;
}