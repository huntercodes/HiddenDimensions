### Hidden Dimensions

##
This application is a file encryption and decryption tool that allows users to protect their sensitive files by encrypting them with a password. The tool uses Advanced Encryption Standard (AES) algorithm to encrypt and decrypt files, which is a widely used and highly secure encryption method.

The application has a user-friendly interface with separate sections for encrypting and decrypting files. Users can select a file they want to encrypt or decrypt, enter a password, and then perform the encryption or decryption with the click of a button. The encrypted files are saved with a ".hd" extension, indicating that they have been encrypted using this tool.

This application is built using C# programming language and the .NET framework, and it utilizes Windows Forms for the user interface. It is a great tool for anyone looking to protect their confidential files from unauthorized access.
##

### Tools Used:
- Visual Studio 2022
- C#
- .NET
- Advanced Encryption Standard (AES)
##

AES is a widely-used symmetric encryption algorithm that has been adopted by the US government as a standard for securing sensitive information. It involves the use of a secret key to encrypt and decrypt data, ensuring that only those with the key can access the information. This project generates a key from the user's password using the 'Rfc2898DeriveBytes' function, which applies a hash function to the password and a salt value to generate a secure key. The encrypted data is then stored in a file, and can only be decrypted by someone with the key (i.e., the user who knows the password).

<p align="center">
  <img src="https://user-images.githubusercontent.com/85328038/229264166-88dee837-f73d-41cd-a097-14ed3a81001d.png" />
</p>

##

Example of an .hd file attempting to be viewed outside the decryption:

##

<p align="center">
  <img src="https://user-images.githubusercontent.com/85328038/229264241-04a9bc93-4262-44d6-b171-54cb82295ac5.png" />
</p>

##

Example of an .hd file being properly decrypted:

##

<p align="center">
  <img src="https://user-images.githubusercontent.com/85328038/229264456-68d9586e-4c3d-40a6-89d8-4476fc9e954d.png" />
</p>
