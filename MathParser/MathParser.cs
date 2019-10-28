using System;

namespace Gidyyy.MathParser {
    public class MathParser {

        public static int ParseToInt( string input ) {
            int output = 0;

            // set brackets
            input = SetBrackets( input );

            int CurrentNumber = 0;
            char lastSign = '+';
            for ( int i = 0; i < input.Length; i++ ) {
                //Numbers
                if ( input[i] == '0' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 0;
                } else if ( input[i] == '1' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 1;
                } else if ( input[i] == '2' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 2;
                } else if ( input[i] == '3' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 3;
                } else if ( input[i] == '4' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 4;
                } else if ( input[i] == '5' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 5;
                } else if ( input[i] == '6' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 6;
                } else if ( input[i] == '7' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 7;
                } else if ( input[i] == '8' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 8;
                } else if ( input[i] == '9' ) {
                    CurrentNumber *= 10;
                    CurrentNumber += 9;
                }
                //Math signs
                else if ( input[i] == '+' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (int) Math.Pow( output , CurrentNumber );

                    lastSign = '+';
                    CurrentNumber = 0;
                } else if ( input[i] == '-' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (int) Math.Pow( output , CurrentNumber );

                    lastSign = '-';
                    CurrentNumber = 0;
                } else if ( input[i] == '*' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (int) Math.Pow( output , CurrentNumber );

                    lastSign = '*';
                    CurrentNumber = 0;
                } else if ( input[i] == '/' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (int) Math.Pow( output , CurrentNumber );

                    lastSign = '/';
                    CurrentNumber = 0;
                } else if ( input[i] == '^' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (int) Math.Pow( output , CurrentNumber );

                    lastSign = '^';
                    CurrentNumber = 0;
                }
                // brackets
                 else if ( input[i] == '(' ) {
                    int OpenBrackets = 0;
                    for ( int j = i + 1; j < input.Length; j++ ) {
                        if ( input[j] == '(' )
                            OpenBrackets++;

                        else if ( input[j] == ')' ) {
                            if ( OpenBrackets == 0 ) {
                                CurrentNumber = ParseToInt( input.Substring( i + 1 , j - i - 1 ) );
                                i = j;
                                break;
                            }
                            OpenBrackets--;
                        }
                    }
                }
            }

            if ( lastSign == '+' )
                output += CurrentNumber;
            else if ( lastSign == '-' )
                output -= CurrentNumber;
            else if ( lastSign == '*' )
                output *= CurrentNumber;
            else if ( lastSign == '/' )
                output /= CurrentNumber;
            else if ( lastSign == '^' )
                output = (int) Math.Pow( output , CurrentNumber );

            return output;
        }

        public static float ParseToFloat( string input ) {
            float output = 0;

            // set brackets
            input = SetBrackets( input );

            float CurrentNumber = 0;
            char lastSign = '+';
            int AfterDot = 1;
            bool IsAfterDot = false;
            for ( int i = 0; i < input.Length; i++ ) {
                //Numbers
                if ( input[i] == '0' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 0;
                    } else {
                        float temp = 0 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '1' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 1;
                    } else {
                        float temp = 1 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '2' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 2;
                    } else {
                        float temp = 2 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '3' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 3;
                    } else {
                        float temp = 3 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '4' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 4;
                    } else {
                        float temp = 4 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '5' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 5;
                    } else {
                        float temp = 5 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '6' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 6;
                    } else {
                        float temp = 6 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '7' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 7;
                    } else {
                        float temp = 7 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '8' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 8;
                    } else {
                        float temp = 8 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '9' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 9;
                    } else {
                        float temp = 9 / ( (float) Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                }
                //Math signs
                else if ( input[i] == '+' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (float) Math.Pow( output , CurrentNumber );

                    lastSign = '+';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '-' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (float) Math.Pow( output , CurrentNumber );

                    lastSign = '-';
                    CurrentNumber = 0f;
                    IsAfterDot = false;
                } else if ( input[i] == '*' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (float) Math.Pow( output , CurrentNumber );

                    lastSign = '*';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '/' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (float) Math.Pow( output , CurrentNumber );

                    lastSign = '/';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '^' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = (float) Math.Pow( output , CurrentNumber );

                    lastSign = '^';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                }
                // brackets
                 else if ( input[i] == '(' ) {
                    int OpenBrackets = 0;
                    for ( int j = i + 1; j < input.Length; j++ ) {
                        if ( input[j] == '(' )
                            OpenBrackets++;

                        else if ( input[j] == ')' ) {
                            if ( OpenBrackets == 0 ) {
                                CurrentNumber = ParseToFloat( input.Substring( i + 1 , j - i - 1 ) );
                                i = j;
                                break;
                            }
                            OpenBrackets--;
                        }
                    }
                }

                //Dot
                else if ( input[i] == '.' ) {
                    AfterDot = 1;
                    IsAfterDot = true;
                }
            }

            if ( lastSign == '+' )
                output += CurrentNumber;
            else if ( lastSign == '-' )
                output -= CurrentNumber;
            else if ( lastSign == '*' )
                output *= CurrentNumber;
            else if ( lastSign == '/' )
                output /= CurrentNumber;
            else if ( lastSign == '^' )
                output = (float) Math.Pow( output , CurrentNumber );

            return output;
        }

        public static double ParseToDouble( string input ) {
            double output = 0;

            // set brackets
            input = SetBrackets( input );

            double CurrentNumber = 0;
            char lastSign = '+';
            int AfterDot = 1;
            bool IsAfterDot = false;
            for ( int i = 0; i < input.Length; i++ ) {
                //Numbers
                if ( input[i] == '0' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 0;
                    } else {
                        double temp = 0 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '1' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 1;
                    } else {
                        double temp = 1 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '2' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 2;
                    } else {
                        double temp = 2 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '3' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 3;
                    } else {
                        double temp = 3 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '4' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 4;
                    } else {
                        double temp = 4 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '5' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 5;
                    } else {
                        double temp = 5 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '6' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 6;
                    } else {
                        double temp = 6 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '7' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 7;
                    } else {
                        double temp = 7 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '8' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 8;
                    } else {
                        double temp = 8 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                } else if ( input[i] == '9' ) {
                    if ( !IsAfterDot ) {
                        CurrentNumber *= 10;
                        CurrentNumber += 9;
                    } else {
                        double temp = 9 / ( Math.Pow( 10 , AfterDot ) );
                        CurrentNumber += temp;
                        AfterDot++;
                    }
                }
                //Math signs
                else if ( input[i] == '+' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = Math.Pow( output , CurrentNumber );

                    lastSign = '+';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '-' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = Math.Pow( output , CurrentNumber );

                    lastSign = '-';
                    CurrentNumber = 0f;
                    IsAfterDot = false;
                } else if ( input[i] == '*' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = Math.Pow( output , CurrentNumber );

                    lastSign = '*';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '/' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = Math.Pow( output , CurrentNumber );

                    lastSign = '/';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                } else if ( input[i] == '^' ) {

                    if ( lastSign == '+' )
                        output += CurrentNumber;
                    else if ( lastSign == '-' )
                        output -= CurrentNumber;
                    else if ( lastSign == '*' )
                        output *= CurrentNumber;
                    else if ( lastSign == '/' )
                        output /= CurrentNumber;
                    else if ( lastSign == '^' )
                        output = Math.Pow( output , CurrentNumber );

                    lastSign = '^';
                    CurrentNumber = 0;
                    IsAfterDot = false;
                }
                // brackets
                 else if ( input[i] == '(' ) {
                    int OpenBrackets = 0;
                    for ( int j = i + 1; j < input.Length; j++ ) {
                        if ( input[j] == '(' )
                            OpenBrackets++;

                        else if ( input[j] == ')' ) {
                            if ( OpenBrackets == 0 ) {
                                CurrentNumber = ParseToDouble( input.Substring( i + 1 , j - i - 1 ) );
                                i = j;
                                break;
                            }
                            OpenBrackets--;
                        }
                    }
                }

                //Dot
                else if ( input[i] == '.' ) {
                    AfterDot = 1;
                    IsAfterDot = true;
                }
            }

            if ( lastSign == '+' )
                output += CurrentNumber;
            else if ( lastSign == '-' )
                output -= CurrentNumber;
            else if ( lastSign == '*' )
                output *= CurrentNumber;
            else if ( lastSign == '/' )
                output /= CurrentNumber;
            else if ( lastSign == '^' )
                output = Math.Pow( output , CurrentNumber );

            return output;
        }

        public static string SetBrackets( string input ) {

            for ( int i = 0; i < input.Length; i++ ) {
                if ( input[i] == '*' || input[i] == '/' ) {
                    bool setBracket = false;
                    for ( int j = i; j > 0; j-- ) {
                        if ( input[j] == '+' || input[j] == '-' ) {
                            input = input.Substring( 0 , j + 1 ) + "(" + input.Substring( j + 1 , input.Length - j - 1 );
                            i++;
                            setBracket = true;
                            break;
                        }
                    }
                    if ( setBracket )
                        for ( int j = i; j < input.Length; j++ ) {
                            if ( input[j] == '+' || input[j] == '-' ) {
                                input = input.Substring( 0 , j - 1 ) + ")" + input.Substring( j - 1 , input.Length - j + 1 );
                                setBracket = false;
                                break;
                            }
                        }
                    if ( setBracket )
                        input += ")";
                }
            }

            for ( int i = 0; i < input.Length; i++ ) {
                if ( input[i] == '^' ) {
                    bool setBracket = false;
                    for ( int j = i; j > 0; j-- ) {
                        if ( input[j] == '+' || input[j] == '-' || input[j] == '*' || input[j] == '/' ) {
                            input = input.Substring( 0 , j + 1 ) + "(" + input.Substring( j + 1 , input.Length - j - 1 );
                            i++;
                            setBracket = true;
                            break;
                        }
                    }
                    if ( setBracket )
                        for ( int j = i; j < input.Length; j++ ) {
                            if ( input[j] == '+' || input[j] == '-' || input[j] == '*' || input[j] == '/' ) {
                                input = input.Substring( 0 , j - 1 ) + ")" + input.Substring( j - 1 , input.Length - j + 1 );
                                setBracket = false;
                                break;
                            }
                        }
                    if ( setBracket )
                        input += ")";
                }
            }
            return input;
        }
    }
}
