/*
 * Name: Stack data stucture using c++
 * Author: Batsukh
 * Date: Created -> 2021/01/08
 *  
 */

#include <iostream>

using namespace std;

const char errorMessage[][50] =
    {
        "",
        "Init: size > 0 baih estoi",
        "Stack uusgeeguie baina",
        "Push: Stack duuren baina",
        "Pop: Stack hooson baina",
        "Top: Stack hooson baina"
    };


typedef struct
{
    int *array;
    int top;
    unsigned int size;
    unsigned int length;
    unsigned int error = 2;
} Stack;

unsigned int init(Stack *, const int); // 
unsigned int push(Stack *, const int);
int pop(Stack *);
int top(Stack *);
unsigned int length(Stack *);
unsigned int size(Stack *);
bool empty(Stack *);
unsigned int print(Stack *);

int main()
{
    cout << "-----------------------------------------" << endl;
    cout << "   Data structrue - STACK  " << endl;
    
    Stack stack;

    while(true){
        short option = 0;

        cout << "1: Stack-iig uusgeh\n"
             << "2: Element nemeh\n"
             << "3: Element hasah\n"
             << "4: Oroin elementiig harah\n"
             << "5: Stack-iin hemjeeg harah\n"
             << "6: Stack-iin urtiig harah harah\n"
             << "7: Hooson uu?\n"
             << "8: Hevleh\n"
             << "0: Duusgah(garah)\n"
             << "-->Songoltoo oruulna uu: ";
        cin >> option;

        switch(option){
            case 1: {
                // initialize stack
                int size = 0; 
                cout << "\t-->Hemjgeegee oruulna uu: ";
                cin >> size; 

                if(init(&stack, size))
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << size << "-tai stack iig uusgelee" << endl;
            } break;
            
            case 2: {
                int push_value = 0;
                cout << "\t-->Push hiih elementee bicne uu: ";
                cin >> push_value;

                push(&stack, push_value);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << push_value << " -g nemlee" << endl;
            } break;
            
            case 3: {
                int popped_value = pop(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << popped_value << " -g haslaa" << endl;
            } break;
            
            case 4: {
                int peek = top(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << peek << " oroin element" << endl;
            } break;

            case 5: {
                int re_size = size(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << re_size << " size-tai" << endl;
            } break;
            
            case 6: {
                int r_length = length(&stack);

                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << r_length << " urt" << endl;
            } break;
            
            case 7: {
                bool re_empty = empty(&stack);
            
                if(stack.error)
                    cout << "\t" << errorMessage[stack.error] << endl;
                else
                    cout << "\t" << re_empty << endl;
            } break;
            
            case 8: {
                if(print(&stack))
                    cout << "\t" << errorMessage[stack.error] << endl;
            } break;

            case 0:{
                free(stack.array);
                return EXIT_SUCCESS;
            }

            default:
                cout << "Buruu utga oruulsan baina" << endl; 
            break;
        }
    }

    return EXIT_SUCCESS;
}

unsigned int init(Stack * stack, const int size)
{   
    if(size < 1)
    {
        stack->error = 1;
        return stack->error;
    }

    stack->array = (int *) malloc(sizeof(int) * size);
    stack->top = -1;
    stack->size = size;
    stack->length = 0;
    stack->error = 0;
    
    return stack->error;
}

unsigned int push(Stack * stack, const int data)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    if(stack->length >= stack->size){
        stack->error = 3;
        return stack->error;
    }

    stack->array[++stack->top] = data;
    stack->length++;
    stack->error = 0;

    return stack->error;
}

int pop(Stack * stack)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    if(stack->top < 0){
        stack->error = 4;
        return stack->error;
    }

    int popped_value = stack->array[stack->top];
    stack->array[stack->top--] = 0;
    stack->length--;
    stack->error = 0;

    return popped_value;
}

int top(Stack * stack)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    if(stack->top < 0){
        stack->error = 4;
        return stack->error;
    }

    stack->error = 0;

    return stack->array[stack->top];
}

unsigned int length(Stack * stack)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    stack->error = 0;

    return stack->length;
} 

unsigned int size(Stack * stack)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    stack->error = 0;

    return stack->size;
}

bool empty(Stack * stack)
{
    if(stack->size < 1){
        stack->error = 2;
        return stack->error;
    }

    stack->error = 0;

    return (stack->length) ? false : true;
}

unsigned int print(Stack * stack)
{
    if(stack->error){
        stack->error = 2;

        return stack->error;
    }

    for(int i = stack->length - 1; i >= 0; i--){
        if(stack->top == i)
            cout << "\t" << stack->array[i] << " <-- top" << endl;
        else
            cout << "\t" << stack->array[i] << endl;
    }

    stack->error = 0;

    return stack->error;
}