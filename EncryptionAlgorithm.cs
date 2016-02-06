/*



██╗  ██╗ █████╗ ██╗   ██╗███████╗████████╗ █████╗  ██████╗██╗  ██╗
██║  ██║██╔══██╗╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝
███████║███████║ ╚████╔╝ ███████╗   ██║   ███████║██║     █████╔╝ 
██╔══██║██╔══██║  ╚██╔╝  ╚════██║   ██║   ██╔══██║██║     ██╔═██╗ 
██║  ██║██║  ██║   ██║   ███████║   ██║   ██║  ██║╚██████╗██║  ██╗
╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝
                
                                                
                                                
 */
 
using System;
using System.IO;
using System.Collections.Generic;

namespace Encrypter
{

	class EncryptionAlgorithm
	{
		public static void  Main()
		{
			
			
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine ("	██╗  ██╗ █████╗ ██╗   ██╗███████╗████████╗ █████╗  ██████╗██╗  ██╗");
			Console.WriteLine ("	██║  ██║██╔══██╗╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔══██╗██╔════╝██║ ██╔╝");
			Console.WriteLine ("	███████║███████║ ╚████╔╝ ███████╗   ██║   ███████║██║     █████╔╝ ");
			Console.WriteLine ("	██╔══██║██╔══██║  ╚██╔╝  ╚════██║   ██║   ██╔══██║██║     ██╔═██╗ ");
			Console.WriteLine ("	██║  ██║██║  ██║   ██║   ███████║   ██║   ██║  ██║╚██████╗██║  ██╗");
			Console.WriteLine ("	╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(" Welcome. What would you like to do? (write the number and press ENTER)");
			Console.WriteLine();
			Console.WriteLine(" 1. Encryption");
			Console.WriteLine(" 2. Decryption");
			Console.WriteLine(" 3. Exit");
			Console.WriteLine();
			
			//The user's answer -- must be one of the options provided, or application restarts
			string chooseMode = Console.ReadLine();
			
			if (chooseMode == "1" || chooseMode == "1.") {
				Encrypt();
			}
			
			if (chooseMode == "2" || chooseMode == "2.") {
				Decrypt();
			}
			
			if (chooseMode == "3" || chooseMode == "3.") {
			} else {
				Console.WriteLine("That is not a valid answer, restarting...");
				System.Threading.Thread.Sleep(500);
				Console.Clear();
				Main();
			}
			
		}
		
		public static void Encrypt () {
			
			Console.SetIn( new StreamReader (Console.OpenStandardInput(350000)));
			
			int keySize;
			
			Console.WriteLine();
			Console.WriteLine("You have chosen the Encryption mode.");
			Console.WriteLine();
			Console.WriteLine("Press Y to continue or N to go back to the menu.");
			
			string encryptContinue = Console.ReadLine();
			
			if (encryptContinue == "n" || encryptContinue == "N") {
				Console.Clear();
				Main();
			}
			
			if (encryptContinue == "y" || encryptContinue == "Y") {
				Console.Clear();
				Console.WriteLine();
				Console.WriteLine("Please write your message to encrypt.");
				Console.WriteLine();
				
				
				char[] message = Console.ReadLine().ToCharArray();
				string confMessage = new String(message);
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("Was your message '" + confMessage + "' ? (y/n)");
				
				string confirmMessage = Console.ReadLine();
				
				if (confirmMessage == "n" || confirmMessage == "N") {
					Console.Clear();
					Main();
			}
			
			if (confirmMessage == "y" || confirmMessage == "Y") {
				
					Console.WriteLine();
					Console.WriteLine("Message confirmed.");
					Console.WriteLine("Please specify the length of the desired encrypted message. (5697-32455809)");
					Console.WriteLine();
					Console.WriteLine("5697 being the weakest encryption, and 32455809 being the strongest.");
					Console.WriteLine();
					Console.WriteLine("Note that higher key lengths may take a few seconds to generate.");
					Console.WriteLine();
					keySize = Int32.Parse(Console.ReadLine());
					
					//After the key length is chosen, the program confirms whether or not the key size is correct
					
					if (keySize < 5697 || keySize > 32455809) {
						Console.WriteLine();
						Console.WriteLine("The encrypted message size is outside of the accepted range. Restarting.");
						Console.Clear();
						Main();
						
					}
					
					if (keySize >= 5697 && keySize <= 32455809) {
						Console.WriteLine();
						Console.WriteLine("You have chosen an encrypted message with a size of " + keySize + " characters.");
						Console.WriteLine();
						Console.WriteLine("Is this the correct length? (Y/N)");
						string keySizeConfirmation = Console.ReadLine();
						
						//If the user does not want the specified size, restart the program
						if (keySizeConfirmation == "n" || keySizeConfirmation == "N") {
							Console.WriteLine();
							Console.WriteLine("You have deemed the encrypted message size as wrong, restarting.");
							Console.Clear();
							Main();
						}
						
						
						//If the user confirms the keysize is correct, continue
						if (keySizeConfirmation == "y" || keySizeConfirmation == "Y") {
							Console.Clear();
							var possibleCharacters = new char[91];
							possibleCharacters[0] = 'a';
							possibleCharacters[1] = 'b';
							possibleCharacters[2] = 'c';
							possibleCharacters[3] = 'd';
							possibleCharacters[4] = 'e';
							possibleCharacters[5] = 'f';
							possibleCharacters[6] = 'g';
							possibleCharacters[7] = 'h';
							possibleCharacters[8] = 'i';
							possibleCharacters[9] = 'j';
							possibleCharacters[10] = 'k';
							possibleCharacters[11] = 'l';
							possibleCharacters[12] = 'm';
							possibleCharacters[13] = 'n';
							possibleCharacters[14] = 'o';
							possibleCharacters[15] = 'p';
							possibleCharacters[16] = 'q';
							possibleCharacters[17] = 'r';
							possibleCharacters[18] = 's';
							possibleCharacters[19] = 't';
							possibleCharacters[20] = 'u';
							possibleCharacters[21] = 'w';
							possibleCharacters[22] = 'v';
							possibleCharacters[23] = 'x';
							possibleCharacters[24] = 'y';
							possibleCharacters[25] = 'z';
							possibleCharacters[26] = '0';
							possibleCharacters[27] = '1';
							possibleCharacters[28] = '2';
							possibleCharacters[29] = '3';
							possibleCharacters[30] = '4';
							possibleCharacters[31] = '5';
							possibleCharacters[32] = '6';
							possibleCharacters[33] = '7';
							possibleCharacters[34] = '8';
							possibleCharacters[35] = '9';
							possibleCharacters[36] = '|';
							possibleCharacters[37] = '&';
							possibleCharacters[38] = '!';
							possibleCharacters[39] = '"';
							possibleCharacters[40] = '@';
							possibleCharacters[41] = '#';
							possibleCharacters[42] = '£';
							possibleCharacters[43] = '$';
							possibleCharacters[44] = '§';
							possibleCharacters[45] = '%';
							possibleCharacters[46] = '/';
							possibleCharacters[47] = '{';
							possibleCharacters[48] = '(';
							possibleCharacters[49] = '[';
							possibleCharacters[50] = ')';
							possibleCharacters[51] = ']';
							possibleCharacters[52] = '=';
							possibleCharacters[53] = '}';
							possibleCharacters[54] = '?';
							possibleCharacters[55] = '»';
							possibleCharacters[56] = '»';
							possibleCharacters[57] = '+';
							possibleCharacters[58] = '*';
							possibleCharacters[59] = '-';
							possibleCharacters[60] = ' ';
							possibleCharacters[61] = '.';
							possibleCharacters[62] = ',';
							possibleCharacters[63] = ':';
							possibleCharacters[64] = ';';
							possibleCharacters[65] = 'A';
							possibleCharacters[66] = 'B';
							possibleCharacters[67] = 'C';
							possibleCharacters[68] = 'D';
							possibleCharacters[69] = 'E';
							possibleCharacters[70] = 'F';
							possibleCharacters[71] = 'G';
							possibleCharacters[72] = 'H';
							possibleCharacters[73] = 'I';
							possibleCharacters[74] = 'J';
							possibleCharacters[75] = 'K';
							possibleCharacters[76] = 'L';
							possibleCharacters[77] = 'M';
							possibleCharacters[78] = 'N';
							possibleCharacters[79] = 'O';
							possibleCharacters[80] = 'P';
							possibleCharacters[81] = 'Q';
							possibleCharacters[82] = 'R';
							possibleCharacters[83] = 'S';
							possibleCharacters[84] = 'T';
							possibleCharacters[85] = 'U';
							possibleCharacters[86] = 'W';
							possibleCharacters[87] = 'V';
							possibleCharacters[88] = 'X';
							possibleCharacters[89] = 'Y';
							possibleCharacters[90] = 'Z';
							
							//Generate the key
							var encryptionKey = new char[keySize];
							var randomCharacter = new Random();
							
							Console.WriteLine();
							Console.WriteLine("Generating your encrypted message...");
							
							for (int i = 0; i < keySize; i++) {
								
								int currentCharacter = randomCharacter.Next(0, 91);
								encryptionKey[i] = possibleCharacters[currentCharacter];
							}

							//When the process is over, show the key to the user
							Console.WriteLine();
							Console.WriteLine("The generation process is over.");
							Console.WriteLine();
							Console.WriteLine("Please choose a file name for to save the encrypted message in. (no extension)");
							string fileName;
							fileName = Console.ReadLine();
							
							if (fileName == null) {
								Console.WriteLine();
								Console.WriteLine("That was not a valid file name, please retry.");
								fileName = Console.ReadLine();
								if (fileName == null) {
									Console.WriteLine();
									Console.WriteLine("You failed again, the program must restart. Press any key to do so.");
									Console.ReadLine();
									Console.Clear();
									Main();
								}
							}
							
							if (fileName != null) {
								var posCalculator = new Random();
								string decryptionKey = "";
								var previousCodes = new List<int>();
								for (int ci = 0; ci < message.Length; ci++) {
									
									int encryptedPos = posCalculator.Next(0, keySize);
									
									//Check if the number has been called before

									if (!previousCodes.Contains(encryptedPos)){
										if (ci == message.Length -1) {
									
									encryptionKey[encryptedPos] = message[ci];
									previousCodes.Add(encryptedPos);
									decryptionKey += encryptedPos.ToString();
									
									} else {
										
										
									
									encryptionKey[encryptedPos] = message[ci];
									previousCodes.Add(encryptedPos);
									decryptionKey += encryptedPos + "|";
									
									}
									} else {
										encryptedPos = posCalculator.Next(0, keySize);
										ci--;
									}
									
									
									
								}
								

								Console.WriteLine(decryptionKey);
								
								
								var outputFile = new StreamWriter(fileName + ".txt");
								outputFile.AutoFlush = true;
								outputFile.Flush();
								if (outputFile.BaseStream != null){
                					outputFile.BaseStream.Flush();
								}
								outputFile.WriteLine(encryptionKey);
								Console.WriteLine();
								Console.WriteLine("Done writing encrypted message file. Preparing to write decryption key.");
								
								Console.WriteLine();
								Console.WriteLine("Please choose a name for the decryption key file.");
								
								string decryptionFileName = Console.ReadLine();


								
								File.WriteAllText(decryptionFileName + ".txt", decryptionKey);
								
								Console.WriteLine();
								Console.WriteLine("Done writing decryption key file.");
								Console.WriteLine();
								Console.WriteLine();
								Console.WriteLine("Final keysize: " + encryptionKey);
								Console.WriteLine("--------------- PROCESS FINISHED ---------------");
								Console.ReadLine();
		
							}		
						}
					}
				}
			}
		}
		
		public static void Decrypt() {
			
			
			Console.WriteLine("Please Indicate a file that contains the encrypted message. (no extension)");
			Console.WriteLine("Make sure the file is in the same directory as this software.");
			
			//The name of the file that contains the encrypted message
			string encryptedFileName = Console.ReadLine();
			
			//This reads the text in the file, and stores it into a string
			string encryptedText = File.ReadAllText(encryptedFileName + ".txt");
			
			//This calculates the length of the text
			int textLength = encryptedText.Length;
			


			
			
			//Creating an array of characters to store the text in, this is then used to grab the characters and add them to the decrypted
			//text string
			var encryptedCharacters = new char[textLength];
			encryptedCharacters = encryptedText.ToCharArray();

			
			Console.WriteLine("Now indicate the name of the file that contains your decryption key");
			//The name of the file that contains the decryption key
			string decryptionFileName = Console.ReadLine();
			
			//This reads the file text
			string decryptionText = File.ReadAllText(decryptionFileName + ".txt");
			
			//Calculate the length of the text
			int decTextLength = decryptionText.Length;
			
			//This identifies each code by splitting at the '|' character, and puts each code in a new string
			string[] letterCodes = decryptionText.Split(new char[] {'|'});
			

			string decryptedText = "Decrypted Text: ";
			
			
			
			for (int i = 0; i < letterCodes.Length; i++) {
				//First get the letter's corresponding letterCode
				if (i == 0) {
					Console.WriteLine();
					Console.WriteLine("Decrypting...");
					Console.WriteLine();
				}
				int code = Int32.Parse(letterCodes[i]);
				System.Threading.Thread.Sleep(25);
				decryptedText += encryptedCharacters[code];
				Console.WriteLine("Decrypted: " + decryptedText);
			}
			
			
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(decryptedText);
			Console.ReadLine();
								
			
		}
	}
}
