/*#include <GL\freeglut.h>
#include <math.h>

float WinWid = 844;
float WinHeight = 554;

void draw()
{
	// Border
	glBegin(GL_LINE_LOOP);

	glVertex2f(397, 257);
	glVertex2f(397, -257);
	glVertex2f(-397, -257);
	glVertex2f(-397, 257);

	glEnd();
	
	glBegin(GL_LINE_STRIP);

	// penalty area
	glVertex2f(397, 76);
	glVertex2f(335, 76);
	glVertex2f(335, -76);
	glVertex2f(397, -76);

	glEnd();
	
	glBegin(GL_LINE_STRIP);

	// penalty area
	glVertex2f(-397, 76);
	glVertex2f(-335, 76);
	glVertex2f(-335, -76);
	glVertex2f(-397, -76);
	glEnd();


	glBegin(GL_LINE_STRIP);

	// goalkeeper area
	glVertex2f(397, 34);
	glVertex2f(377, 34);
	glVertex2f(377, -34);
	glVertex2f(397, -34);
	glEnd();


	glBegin(GL_LINE_STRIP);

	// goalkeeper area
	glVertex2f(-397, 34);
	glVertex2f(-377, 34);
	glVertex2f(-377, -34);
	glVertex2f(-397, -34);
	glEnd();
	
	glBegin(GL_LINES);

	//Goliin shugam
	glVertex2f(0, 257);
	glVertex2f(0, -257);

	glEnd();



	// Center circle
	glBegin(GL_LINE_LOOP);
	for (int i = 0; i < 365; i++)
	{
		float theta = 2.0f * 3.1415926f * float(i) / float(365);//get the current angle

		float x = 34 * cosf(theta);//calculate the x component
		float y = 34 * sinf(theta);//calculate the y component

		glVertex2f(x, y);//output vertex
	}
	glEnd();

	
	glBegin(GL_LINE_LOOP);
	for (int i = 0; i < 365; i++)
	{
		float theta = 2.0f * 3.1415926f * float(i) / float(365);//get the current angle

		float x = 34 * cosf(theta);//calculate the x component
		float y = 34 * sinf(theta);//calculate the y component

		if(335 > x + 356)
			glVertex2f(x + 356, y);//output vertex
	}
	glEnd();
	
	glBegin(GL_LINE_LOOP);
	for (int i = 0; i < 365; i++)
	{
		float theta = 2.0f * 3.1415926f * float(i) / float(365);//get the current angle

		float x = 34 * cosf(theta);//calculate the x component
		float y = 34 * sinf(theta);//calculate the y component

		if(-335 < x - 356)
			glVertex2f(x - 356, y);//output vertex
	}
	glEnd();

	glFlush();
}

void initialize()
{
	glClearColor(0.0, 0.0, 0.0, 0.0);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-WinWid / 2, WinWid / 2, -WinHeight / 2, WinHeight / 2, -200.0, 200.0);
}

int main(int argc, char** argv)
{
	//initialization
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB); //static window, color   
	glutInitWindowSize(WinWid, WinHeight); //setWindowSize
	glutInitWindowPosition(50, 100);
	glutCreateWindow("DrawWindow");
	//registration
	glutDisplayFunc(draw); //zurah funct(butsaah utga ni void bn)
	initialize(); // void torliin funct
	glutMainLoop(); //programiig haatal delgetsend zursan heveer nm
	return 0;
*/