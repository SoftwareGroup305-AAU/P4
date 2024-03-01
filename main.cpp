#include <iostream>
#include <fstream>
#include <string>

enum token {
    KEYWORD,
    RET,
    INT_LIT,
    IDENT,
    LPAREN,
    RPAREN,
    COLON,
    EQ
};

enum token int_lit (std::string);
enum token ident (std::string);
// enum token iskeywordorret(std::string);

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
                continue;
            }
            else if (c == ')') {
                std::cout << "RPAREN ";
                continue;
            }
            else if (c == ':') {
                std::cout << "COLON ";
                continue;
            }
            else if (c == '=') {
                std::cout << "EQ ";
                continue;
            }
        }
    }
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
    if (str == "funky") {
        std::cout << "KEYWORD ";
        return KEYWORD;
    }
    else if (str == "return") {
        std::cout << "RET ";
        return RET;
    }
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

// enum token iskeywordorret(std::string str) {
//     if (str == "funky") {
//         std::cout << "KEYWORD ";
//         return KEYWORD;
//     }
//     else if (str == "return") {
//         std::cout << "RET";
//         return RET;
//     }
// }