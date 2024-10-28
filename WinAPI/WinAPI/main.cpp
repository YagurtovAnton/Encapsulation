#include<Windows.h>
#define MESSAGE_BOX

INT WINAPI WinMain(HINSTANCE hInstanse, HINSTANCE hPrevInst, LPSTR IpCmdLine, INT nCmdShow)
{
#ifdef MESSAGE_BOX
	MessageBox
	(
		NULL,
		"Алексей Марков",
		"заголовок окна",
		MB_YESNOCANCEL | MB_USERICON
		| MB_HELP
		| MB_DEFBUTTON4
		| MB_SYSTEMMODAL

	);
#endif // MESSAGE_BOX

	return 0;
}