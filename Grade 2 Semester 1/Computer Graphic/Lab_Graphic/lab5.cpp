#include <gl/glut.h>

GLfloat xRotated, yRotated, zRotated;
char c = 'a';
bool sphere = true;
bool color = true;
bool wire = true;
float speed = 0.01;



void display() {
	glClear(GL_COLOR_BUFFER_BIT);

	
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	glTranslatef(0.0, 0.0, -5.0);

	if (color)
		glColor3f(0.0, 1.0, 1.0);
	else
		glColor3f(1.0, 0.0, 0.0);

	glRotatef(xRotated, 1.0, 0.0, 0.0);
	glRotatef(yRotated, 0.0, 1.0, 0.0);
	glRotatef(zRotated, 0.0, 0.0, 1.0);

	if (sphere)
		if(wire)
			glutWireSphere(1, 10, 12);
		else
			glutSolidSphere(1, 10, 12);
	else
		if(wire)
			glutWireTorus(0.4, 0.5, 10, 12);
		else
			glutSolidTorus(0.4, 0.5, 10, 12);
	
	glFlush();
	glutSwapBuffers();
}
void reshape(int width, int height) {
	glViewport(0, 0, width, height);\
}

void idleFunc(void)
{

	switch (c)
	{
	case 'a':
		xRotated += speed;
		break;
	case 'd':
		zRotated += speed;
		break;
	case 'w':
		yRotated += speed;
		break;
	}

	display();
}

void keyboard(unsigned char key, int x, int y) {
	switch (key)
	{
	case 'a':
		c = 'a';
		break;
	case 'd':
		c = 'd';
		break;
	case 'w':
		c = 'w';
		break;
	case 's':
		sphere = !sphere;
		break;
	case '+':
		if(speed <= 0.09)
			speed += 0.01;
		break;
	case '-':
		if(speed >= 0.01)
			speed -= 0.01;
		break;
	case '*':
		color = !color;
		break;
	case '/':
		wire = !wire;
		break;
	}
}

int main(int argc, char* argv[]) {
	glutInit(&argc, argv);
	glutInitWindowSize(500, 500);
	glutInitWindowPosition(0, 0);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutCreateWindow("By Batsukh");

	glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

	xRotated = yRotated = zRotated = 0.0;

	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutKeyboardFunc(keyboard);
	glutIdleFunc(idleFunc);

	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluPerspective(60, 1, 1, 10);

	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	gluLookAt(0.0, 0.0, 5.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);

	glutMainLoop();
}


