/*
 * Name: Stack using node
 * Author: Batsukh
 * Date: Created 2021-01-09 
*/

#include <iostream>

using namespace std;

const char errorMessage[][50] =
    {
        "",
        "Stack hooson baina"
    };

typedef struct Node_Struct{
    int data;
    Node_Struct * next;
} Node; 

typedef struct
{
    Node * top = NULL;
    unsigned int length = 0;
    unsigned int error = 2;
} Stack;

unsigned int push(Stack *, const int);
int pop(Stack *);
int top(Stack *);
unsigned int length(Stack *);
bool empty(Stack *);
unsigned int print(Stack *);

int main()
{
    cout << "-----------------------------------------" << endl;
    cout << "   Data structrue - STACK  " << endl;
    
    Stack stack;

    while(true){
        short option = 0;

        cout << "1: Element nemeh\n"
             << "2: Element hasah\n"
             << "3: Oroin elementiig harah\n"
             << "4: Stack-iin urtiig harah harah\n"
             << "5: Hooson uu?\n"
             << "6: Hevleh\n"
             << "0: Duusgah(garah)\n"
             << "-->Songoltoo oruulna uu: ";
        cin >> option;

        switch(option){
            case 1: {
                int push_value = 0;
                cout << "\t-->Push hiih elementee bicne uu: ";
                cin >> push_value;

                push(&stack, push_value);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << push_value << " -g nemlee" << endl;
            } break;
            
            case 2: {
                int popped_value = pop(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << popped_value << " -g haslaa" << endl;
            } break;
            
            case 3: {
                int peek = top(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << peek << " oroin element" << endl;
            } break;

            case 4: {
                int r_length = length(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << r_length << " urt" << endl;
            } break;
            
            case 5: {
                bool re_empty = empty(&stack);
            
                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << re_empty << endl;
            } break;
            
            case 6: {
                if(print(&stack))
                    cout << "\t" << errorMessage[stack.error] << endl;
            } break;

            case 0:{
                
                return EXIT_SUCCESS;
            }

            default:
                cout << "Buruu utga oruulsan baina" << endl; 
            break;
        }
    }

    return EXIT_SUCCESS;
}

unsigned int push(Stack * stack, const int data)
{
    if(stack->top == NULL)
    {
        Node * new_top = new Node();
        new_top->data = data;
        new_top->next = NULL;
    }
    else
    {   
        Node * new_top = { data, stack->top};

    }
}

int pop(Stack * stack);

int top(Stack * stack);

unsigned int length(Stack * stack)
{
}

bool empty(Stack * stack) 
{
    return (stack->top == NULL) ? true : false;
}

unsigned int print(Stack * stack)
{
    if (stack->top == NULL)
    {
        stack->error = 1; 

        return stack->error;
    }

    int length = stack->length;
    int copy_stack[length] = {0};

    for(int i = length - 1; i >= 0; i++){
        copy_stack[i] =  pop(stack);

        if(i == length - 1)
            cout << "\t" << copy_stack[i] << "<--top" << endl;
        else 
            cout << "\t" << copy_stack[i] << endl; 
    }  

    for(int i = 0; i < length; i++)
        push(stack, copy_stack[i]);
}