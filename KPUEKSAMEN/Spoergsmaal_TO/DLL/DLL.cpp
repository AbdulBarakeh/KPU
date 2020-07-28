// DLL.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "DLL.h"
#include <iostream>


// This is an example of an exported variable
DLL_API int nDLL=0;

// This is an example of an exported function.
DLL_API int fnDLL(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
CDLL::CDLL()
{
    return;
}

DLL_API void Bark()
{
    std::cout << "baow baow" << std::endl;
}
DLL_API void Scream()
{
    std::cout << "Ahhh" << std::endl;

}