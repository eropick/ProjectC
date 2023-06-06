using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    internal class Algorithms
    {
        //후위 표기식용 리스트
        public List<string> Postfix;

        //중위 표기식용 리스트
        public List<string> Infix;

        //연산용 스택
        private Stack<string> Oper;

        //계산용 스택
        private Stack<double> Result;

        //괄호 검사용 스택
        private Stack<char> Bracket;

        public Algorithms()
        {
            Postfix = new List<string>();
            Infix = new List<string>();
            Oper = new Stack<string>();
            Result = new Stack<double>();
            Bracket = new Stack<char>();
        }

        //text값이 변할 때 중위표기식을 Parse한다.
        public void Parsing(string data)
        {
            Infix.Clear();

            //숫자를 만들 임시 변수
            char[] number = new char[data.Length];
            //인덱스
            int index = -1;

            //dot 여부
            bool dot = false;

            for (int i = 0; i < data.Length; ++i)
            {
                char c = data[i];
                //마지막인 경우
                if (i == data.Length - 1)
                {
                    //숫자인 경우
                    if (char.IsDigit(c))
                    {
                        number[++index] = c;
                        number[++index] = '\0';
                        Infix.Add(new string(number));
                        break;
                    }
                    else if (c == ')')
                    {
                        if (index >= 0) //나머지 숫자 할당
                        {
                            number[++index] = '\0';
                            Infix.Add(new string(number));
                        }
                        Infix.Add(c.ToString());
                        break;
                    }
                    else if (c == 'e')
                    {
                        Infix.Add(new string("e"));
                    }
                    else if (c == 'π')
                    {
                        Infix.Add(new string("π"));
                    }
                    else //이 외에 케이스는 전부 비정상 케이스
                    {
                        Infix.Clear();
                        break;
                    }
                }
                else //마지막이 아닌 경우
                {
                    //숫자인 경우
                    if (char.IsDigit(c))
                    {
                        number[++index] = c;
                    }
                    else if (c == 'e')
                    {
                        Infix.Add(new string("e"));
                    }
                    else if (c == 'π')
                    {
                        Infix.Add(new string("π"));
                    }
                    else if (c == '.') //dot 인 경우
                    {
                        if (dot == false) //dot이 기존에 안 나온 경우
                        {
                            number[++index] = c;
                            dot = true;
                        }
                        else //dot이 두 번 나온 경우이므로 파싱 종료
                        {
                            Infix.Clear();
                            break;
                        }
                    }
                    //연산자인 경우
                    else if (c == '+' || c == '-' || c == 'x' || c == '÷' || c == '^' || c == '(' || c == ')')
                    {
                        //숫자 파싱이 진행중이라면 종료 후 연산자 삽입
                        if (index >= 0)
                        {
                            number[++index] = '\0';
                            Infix.Add(new string(number));
                            index = -1;
                            number = new char[data.Length];
                            dot = false;
                        }
                        Infix.Add(c.ToString());
                    }
                    else if (c == ' ')
                        continue;
                    else
                    {
                        //그 외에 케이스는 하나로 묶어서 단위 처리
                        string unit = "";
                        switch (c)
                        {
                            case '√':
                                unit = data.Substring(i, 2);
                                i = i + 1;
                                break;
                            case 'a':
                                unit = data.Substring(i, 4);
                                i = i + 3;
                                break;
                            case 'l':
                                if (data[i + 1] == 'n')
                                {
                                    unit = data.Substring(i, 3);
                                    i = i + 2;
                                }
                                else
                                {
                                    unit = data.Substring(i, 4);
                                    i = i + 3;
                                }
                                break;
                            case 's':
                                if (data[i + 3] == '(')
                                {
                                    unit = data.Substring(i, 4);
                                    i = i + 3;
                                }
                                else
                                {
                                    unit = data.Substring(i, 6);
                                    i = i + 5;
                                }
                                break;
                            case 'c':
                                if (data[i + 3] == '(')
                                {
                                    unit = data.Substring(i, 4);
                                    i = i + 3;
                                }
                                else
                                {
                                    unit = data.Substring(i, 6);
                                    i = i + 5;
                                }
                                break;
                            case 't':
                                if (data[i + 3] == '(')
                                {
                                    unit = data.Substring(i, 4);
                                    i = i + 3;
                                }
                                else
                                {
                                    unit = data.Substring(i, 6);
                                    i = i + 5;
                                }
                                break;
                        }
                        if (index >= 0)
                        {
                            number[++index] = '\0';
                            Infix.Add(new string(number));
                            index = -1;
                            number = new char[data.Length];
                            dot = false;
                        }
                        Infix.Add(unit); //하나의 단위로 처리해야 함
                    }
                }
            }

            Oper.Clear();
        }

        //연산자 우선순위를 반환
        public int getPriority(string data)
        {
            if (data.CompareTo("(") == 0 || data.CompareTo(")") == 0)
                return 0;
            else if (data.CompareTo("+") == 0 || data.CompareTo("-") == 0)
                return 1;
            else if (data.CompareTo("x") == 0 || data.CompareTo("÷") == 0)
                return 2;
            else if (data.CompareTo("^") == 0)
                return 3;
            else
                return 0; //기타 함수들은 괄호라고 생각하면 됨
        }


        //중위 표기식을 후위 표기식으로 저장
        public void InfixToPostfix()
        {
            Postfix.Clear();
            foreach (string data in Infix)
            {
                //숫자라면 후위 표기식에 저장
                if (Double.TryParse(data, out double value))
                    Postfix.Add(data);
                else if (data.CompareTo("π") == 0 || data.CompareTo("e") == 0)
                    Postfix.Add(data);
                else //그렇지 않다면 옵션에 따른 스택 이용
                {
                    int PriorityStack;
                    int PriorityData;

                    if (data.CompareTo("+") == 0 || data.CompareTo("-") == 0 ||
                        data.CompareTo("x") == 0 || data.CompareTo("÷") == 0 ||
                        data.CompareTo("^") == 0)
                    {
                        while (true)
                        {
                            string temp = "";
                            if (Oper.TryPeek(out string tp))
                                temp = tp;
                            else
                            {
                                Oper.Push(data);
                                break;
                            }
                            PriorityStack = getPriority(tp);
                            PriorityData = getPriority(data);
                            //스택에 있는 데이터가 우선순위가 더 높다면 꺼내서 출력
                            if (PriorityStack >= PriorityData)
                            {
                                Postfix.Add(Oper.Pop());
                            }
                            else
                            {  //우선순위가 스택이 더 낮다면 스택에 넣고 종료
                                Oper.Push(data);
                                break;
                            }
                        }
                    }
                    else if (data.IndexOf("(") != -1) //왼쪽 괄호가 있는 경우
                    {
                        Oper.Push(data);
                    }
                    else if (data.CompareTo(")") == 0)
                    {
                        Oper.TryPop(out string result);
                        string temp = result;
                        //왼쪽 괄호를 찾을 때까지 출력
                        while (temp.IndexOf("(") == -1)
                        {
                            Postfix.Add(temp);
                            temp = Oper.Pop();
                        }
                        //함수라면 해당 함수를 출력
                        if (temp.IndexOf("(") != 0)
                            Postfix.Add(temp);
                    }
                }
            }
            //남아있는 연산자 모두 출력
            while (true)
            {
                if (Oper.TryPop(out string result))
                    Postfix.Add(result);
                else
                    break;
            }
            //스택 초기화
            Oper.Clear();
        }

        //후위표기식으로 저장된 수식을 연산한 결과를 반환
        public double getResult(bool isDeg)
        {
            double result = 0;
            Result.Clear();
            foreach (string data in Postfix)
            {
                double val1, val2;
                //숫자인 경우 스택에 넣음
                if (Double.TryParse(data, out double d))
                    Result.Push(d);
                else if (data.CompareTo("π") == 0)
                    Result.Push(Math.PI);
                else if (data.CompareTo("e") == 0)
                    Result.Push(Math.E);
                else //그 외에 경우 연산 수행
                {
                    //덧셈
                    if (data.CompareTo("+") == 0)
                    {
                        val2 = Result.Pop();
                        val1 = Result.Pop();
                        Result.Push(val1 + val2);
                    }
                    //뺄셈
                    else if (data.CompareTo("-") == 0)
                    {
                        val2 = Result.Pop();
                        val1 = Result.Pop();
                        Result.Push(val1 - val2);
                    }
                    //곱셈
                    else if (data.CompareTo("x") == 0)
                    {
                        val2 = Result.Pop();
                        val1 = Result.Pop();
                        Result.Push(val1 * val2);
                    }
                    //나눗셈
                    else if (data.CompareTo("÷") == 0)
                    {
                        val2 = Result.Pop();
                        val1 = Result.Pop();
                        Result.Push(val1 / val2);
                    }
                    //지수
                    else if (data.CompareTo("^") == 0)
                    {
                        val2 = Result.Pop();
                        val1 = Result.Pop();
                        Result.Push(Math.Pow(val1, val2));
                    }
                    //abs
                    else if (data.CompareTo("abs(") == 0)
                    {
                        val1 = Result.Pop();
                        Result.Push(Math.Abs(val1));
                    }
                    //루트
                    else if (data.CompareTo("√(") == 0)
                    {
                        val1 = Result.Pop();
                        Result.Push(Math.Sqrt(val1));
                    }
                    //자연로그
                    else if (data.CompareTo("ln(") == 0)
                    {
                        val1 = Result.Pop();
                        Result.Push(Math.Log(val1));
                    }
                    //로그
                    else if (data.CompareTo("log(") == 0)
                    {
                        val1 = Result.Pop();
                        Result.Push(Math.Log10(val1));
                    }
                    //삼각함수
                    else if (data.CompareTo("sin(") == 0)
                    {
                        val1 = Result.Pop();
                        //부동소수점 표기 오류로 인한 근사치
                        if (isDeg) 
                            val1 = DegToRad(val1);
                        double round = Math.Round(Math.Sin(val1) - 1.0, 7) + 1.0;
                        Result.Push(round);
                    }
                    else if (data.CompareTo("cos(") == 0)
                    {
                        val1 = Result.Pop();
                        if (isDeg)
                            val1 = DegToRad(val1);
                        double round = Math.Round(Math.Cos(val1) - 1.0, 7) + 1.0;
                        Result.Push(round);
                    }
                    else if (data.CompareTo("tan(") == 0)
                    {
                        val1 = Result.Pop();
                        if (isDeg)
                            val1 = DegToRad(val1);
                        double round = Math.Round(Math.Tan(val1) - 1.0, 7) + 1.0;
                        Result.Push(round);
                    }
                    else if (data.CompareTo("sin⁻¹(") == 0)
                    {
                        val1 = Result.Pop();
                        if (isDeg)
                            val1 = RadToDeg(Math.Asin(val1));
                        Result.Push(val1);
                    }
                    else if (data.CompareTo("cos⁻¹(") == 0)
                    {
                        val1 = Result.Pop();
                        if (isDeg)
                            val1 = RadToDeg(Math.Acos(val1));
                        Result.Push(val1);
                    }
                    else if (data.CompareTo("tan⁻¹(") == 0)
                    {
                        val1 = Result.Pop();
                        if (isDeg)
                            val1 = RadToDeg(Math.Atan(val1));
                        Result.Push(val1);
                    }
                }
            }
            result = Result.Pop();
            return result;
        }

        //괄호 검사
        public bool checkBracket(string str)
        {
            foreach(char c in str)
            {
                if (c == '(')
                    Bracket.Push(c);
                else if (c == ')')
                    if(!Bracket.TryPop(out _)) //pop이 더 이상 안되는 경우
                        return false;
            }

            //for문 빠져나왔을 때 스택 수가 0이면 성공
            if (Bracket.Count == 0)
                return true;
            else //아닌 경우 실패
            {
                Bracket.Clear();
                return false;
            }
        }

        public bool checkNumber(string str)
        {
            char c = ' ';
            if (str.Length > 0)
                c = str[str.Length - 1];
            else
                return true;

            //곱셈 케이스
            if (c == ')' || c == 'e' || c == 'π')
                return false;
            else
                return true;
        }

        //연산자 입력 검사
        // 0 : 연산자가 앞에 없고 길이가 0 이상(정상 입력)
        // -1 : 길이가 0
        // 1 : 연산자 앞에 있는 상황
        public int checkOper(string str)
        {
            char c = ' ';
            if (str.Length > 0)
                c = str[str.Length - 1];
            else
                return -1;

            if (c == '+' || c == '-' || c == 'x' || c == '÷')
                return 1;
            else if (c == '(') //왼쪽 괄호 케이스
                return 2;
            else
                return 0;
        }

        public int checkFunc(string str)
        {
            char c = ' ';
            int val = checkOper(str);
            if (str.Length > 0)
                c = str[str.Length - 1];

            if (val == 1 || val == -1 || c == '(') //연산자거나 왼쪽 괄호 또는 아무것도 없다면 그대로
                return 0;
            else if (Char.IsDigit(c) || c == ')' || c == 'e' || c == 'π') //숫자거나 오른쪽 괄호라면 x처리
                return 1;
            else
                return -1;
        }

        //소수점 판단
        public int checkDot(string str)
        {
            int length = str.Length;
            if (length == 0)
                return 0;
            else
            {
                char c = str[length - 1];
                //기본 케이스 (왼쪽 괄호, 연산자가 있는 경우) 0.
                if (c == '(' || checkOper(str) == 1)
                    return 0;
                else if (c == ')' || c == 'e' || c == 'π') //곱셈 케이스 (오른쪽 괄호, e, pi함수)
                    return 1;
                else if (char.IsDigit(c)) //숫자케이스
                {
                    for (int i = length - 1; i >= 0; i--)
                    {
                        //숫자가 아닌 경우 감지
                        if (!char.IsDigit(str[i]))
                        {
                            if (str[i] == '.') //쓰기 금지
                                return -1;
                            else
                                return 2; //쓰기 가능
                        }
                        if (i == 0)
                            return 2;
                    }
                }
                return -1;
            }
        }

        public int checkSign(string str)
        {
            int length = str.Length;
            if (length == 0)
                return -1;
            else
            {
                char c = str[length - 1];
                if (c == '(' || checkOper(str) == 1) //기본 케이스 (0- 
                    return -1;
                else if (c == ')') //곱셈 케이스 x(0- 
                    return -2;
                else if (c == 'e' || c == 'π') //해당 문자 앞에 (0- 
                    return -3;
                else if (char.IsDigit(c)) //숫자 케이스 숫자 앞에 (0- : index
                {
                    for (int i = length - 1; i >= 0; i--)
                    {
                        //숫자가 아닌 경우 감지
                        if (!char.IsDigit(str[i]))
                        {
                            if (str[i] != '.')  //dot이 아닌 문자를 만난 경우
                                return i+1;
                        }
                        if (i == 0)
                            return i;
                    }
                }
            }
            return 0;
        }

        //1도 = PI/180
        //x도 = PI*X/180 Radian
        //x Radian = 180*X/PI 도 
        private double DegToRad(double x)
        {
            return Math.PI * x / 180;
        }
        private double RadToDeg(double x)
        {
            return 180 * x / Math.PI;
        }
    }
}