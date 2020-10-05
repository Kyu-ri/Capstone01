#include <opencv2/core.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgcodecs.hpp>
#include <iostream>
#include <math.h>

using namespace cv;
using namespace std;

int main() {

	Mat image;
	image = imread("�Ž�.jpg", IMREAD_COLOR);
	if (image.empty()) {
		cout << "Could not open or find the image" << endl;
		return -1;
	}

	int baseColor[8] = { 153,10040064,16737792,0,6737151,13421772,16711833,16777215 };
	int Color[8] = { 0,0,0,0,0,0,0,0 };

	uchar r, g, b;
	int** pixels = new int*[image.rows];
	for (int i = 0; i < image.rows; i++) {
		pixels[i] = new int[image.cols];
	}

	int temp = 0;
	int min = 999999999;
	int k = 0;

	for (int i = 0; i < image.rows; ++i) {
		Vec3b* pixel = image.ptr<Vec3b>(i);
		for (int j = 0; j < image.cols; ++j) {
			pixels[i][j] = pixel[j][2] * 16 * 16 * 16 * 16 + pixel[j][1] * 16 * 16 + pixel[j][0];
			//printf("%x\n temp : %d\n", pixels[i][j], temp++);
			//temp++;
			for (k = 0; k < 8; k++) {
				if (min > abs(pixels[i][j] - baseColor[k])) {
					min = abs(pixels[i][j] - baseColor[k]);
					temp = k;
				}
			}
			Color[temp]++; min = 999999999;
		}
		//cout << endl;
	}

	cout << "���̺� : " << Color[0] << " ��" << endl;
	cout << "������ : " << Color[1] << " ��" << endl;
	cout << "������ : " << Color[2] << " ��" << endl;
	cout << "������ : " << Color[3] << " ��" << endl;
	cout << "�ϴû� : " << Color[4] << " ��" << endl;
	cout << "ȸ�� : " << Color[5] << " ��" << endl;
	cout << "��ũ�� : " << Color[6] << " ��" << endl;
	cout << "��� : " << Color[7] << " ��" << endl;
	

	
	
	//printf("%x\n \n", pixels[0][0]);
	//printf("%x\n t\n", pixels[][], temp++);

	namedWindow("Original", WINDOW_AUTOSIZE);
	imshow("Original", image);

	waitKey(0);
	return 0;
}