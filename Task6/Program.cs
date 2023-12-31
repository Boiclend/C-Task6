﻿using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

// Программа должна выполнять преобразования строки (длина строки 255 символов):

// СТРОКА ЗАГЛАВНЫМИ БУКВАМИ
// строка в нижнем регистре
// С Заглавной Буквы (Первый Символ Каждого Слова В Строке )
// пЕРВЫЙ сИМВОЛ в нИЖНЕМ рЕГИСТРЕ
// Как в предложении(с заглавной буквы).
// Символ 'f' — выход из программы
// Организовать в программе меню, через которое можно удобно выбирать любое действие. Программа должна выполняться пока пользователь не введет  символ 'f'.


void UpperCase(string txt) { // все буквы в UpperCase
    Console.WriteLine(txt.ToUpper()); 
}

void LowerCase(string txt) { // все буквы в LowerCase
    Console.WriteLine(txt.ToLower());
}

void UpperFirstSym(string txt) { // Первые буквы заглавные
        
    TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
    txt = textInfo.ToTitleCase(txt);
    Console.WriteLine(txt);
}

void LowerFirstSym(string txt) { // Первые буквы предложения в LowerCase
    char[] str = txt.ToCharArray();
    char temp = ' ';
    string Converter;
    char ss;
    string SymbolToLow;
    temp = str[0];
    Converter = temp.ToString();
    SymbolToLow = Converter.ToLower();
    ss = char.Parse(SymbolToLow);
    str[0] = ss;
        for (int i = 0; i < str.Length; i++)
        {   
            if (str[i] == ' ')
            {
                temp = str[i + 1];
                Converter = temp.ToString();
                SymbolToLow = Converter.ToLower();
                ss = char.Parse(SymbolToLow);
                str[i + 1] = ss;
            }
        }
    txt = new String(str);
    Console.WriteLine();
    Console.Write(txt);
    Console.WriteLine();
}

void FirstSymbolToUpper(string txt) { // Только первый символ заглавный
    txt = txt.ToLower();
    char[] str = txt.ToCharArray();
    char temp = ' ';
    string Converter;
    char ss;
    string SymbolToUpper;
    temp = str[0];
    Converter = temp.ToString();
    SymbolToUpper = Converter.ToUpper();
    ss = char.Parse(SymbolToUpper);
    str[0] = ss;
    txt = new String(str);
    Console.WriteLine();
    Console.Write(txt);
    Console.WriteLine();
}

char Menu() { // меню программы
    Console.WriteLine("Для преобразования строки в заглавные буквы нажмите : 1");
    Console.WriteLine("Для преобразования строки в нижний регистр нфжмите : 2");
    Console.WriteLine("Для преобразования строки с Заглавной Буквы нажмите : 3");
    Console.WriteLine("Для преобразования строки в первый символ в нижнем регистре нажмите : 4");
    Console.WriteLine("Для преобразования строки как в обычном предложении нажмите : 5");
    Console.WriteLine("Для выхода нажмите : f");
    Console.WriteLine();
    Console.WriteLine("Введите необходимое действие: ");
    char oper = char.Parse(Console.ReadLine());
    return oper;
}

Console.WriteLine("Введите текст");
string Text = Console.ReadLine();
char Operation = Menu();


while (Operation != 'f'){
   if (Operation != '1' & Operation != '2' & Operation != '3' & Operation != '4' & Operation != '5') {
        Console.WriteLine("Введеный символ не соответствует условию. Повторите попытку ");
        break;
    }
   else{
        if (Operation == '1') {
            UpperCase(Text);
        }
        if (Operation == '2') {
            LowerCase(Text);
        }
        if (Operation == '3') {
            UpperFirstSym(Text);
        }
        if (Operation == '4') {
            LowerFirstSym(Text);
        }
        if (Operation == '5') {
            FirstSymbolToUpper(Text);
        }
   Operation = Menu();
        }
}