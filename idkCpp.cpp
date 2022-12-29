#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <iostream>

#define arrLen(a) (sizeof(a)/sizeof(a[0]))

using namespace std;

int main() {
    begin: printf("File name, without extension > ");
    char name[128] = {};
    scanf("%s", &name);
    strcat(name, ".cpp");
    char prefix[256];
    int isGit = 0;
    if(name[0] == 'g') {
        strcpy(prefix, "D:\\GitHub\\random-stuff-idk");
        isGit = 1;
    }
    else strcpy(prefix,"C:\\Users\\Kuon\\Documents\\stuff\\22a\\C\\");

    if(name[isGit] == 'l' && name[isGit+1] == 'g') strcat(prefix, "lg\\");
    if(name[isGit] == 'l' && name[isGit+1] == 'q') strcat(prefix, "lq\\");

    strcat(prefix, name);
    FILE *f = fopen(prefix, "r");
    if (f) {
        printf("File already exists!\n");
        goto begin;
    }
    fclose(f);
    freopen(prefix,"w", stdout);
    cout << R"(#include <iostream>
#include <cstring>
#include <cmath>
#include <vector>
#include <algorithm>

#define MAX_INT 0x7fffffff
#define ll long long
#define IL inline

#define max(a,b) (((a) > (b)) ? (a) : (b))
#define min(b,a) (((a) > (b)) ? (a) : (b))

using namespace std;

ll nextLL();
char nextLtr();
void qSort(ll *arr, int l, int r);
void swap(ll *v0, ll *v1);

int main() {
    
    
    return 0;
}

IL ll nextLL() {
    ll x = 0, f = 1;
    char c = getchar();
    while(c < 48 || c > 57) {
        if(c == '-')
            f = -1;
        c = getchar();
    }
    while(c >= 48 && c <= 57) {
        x = (x<<3) + (x<<1) + (c - 48);
        c = getchar();
    }
    return x * f;
}

IL char nextLtr() {
    char c = getchar();
    while(!(c >= 65 && c <= 90 || c >= 97 && c <= 122))
        c = getchar();
    return c;
}

IL void swap(ll *v0, ll *v1) {
    ll temp = *v0;
    *v0 = *v1;
    *v1 = temp;
}

IL void qSort(ll *arr, int l, int r) {
    int i = l, j = r;
    ll k = arr[i];
    while(i < j) {
        while(i < j && arr[i] < k)
            i++;
        swap(arr[i++],arr[j]);
        while(i < j && arr[j] > k)
            j--;
        swap(arr[i],arr[j--]);
    }
    qSort(arr, l, i - 1);
    qSort(arr, i + 1, r);
})";
    fclose(f);
    char cmd[128] = {"code "};
    strcat(cmd, prefix);
    system(cmd);
    
    return 0;
}