#include <opencv2/core.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/imgcodecs.hpp>
#include <iostream>
#include <math.h>

using namespace cv;
using namespace std;

int main() {

	Mat image;
	image = imread("거실.jpg", IMREAD_COLOR);
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

	cout << "네이비 : " << Color[0] << " 개" << endl;
	cout << "진브라운 : " << Color[1] << " 개" << endl;
	cout << "오렌지 : " << Color[2] << " 개" << endl;
	cout << "검정색 : " << Color[3] << " 개" << endl;
	cout << "하늘색 : " << Color[4] << " 개" << endl;
	cout << "회색 : " << Color[5] << " 개" << endl;
	cout << "핑크색 : " << Color[6] << " 개" << endl;
	cout << "흰색 : " << Color[7] << " 개" << endl;
	

	
	
	//printf("%x\n \n", pixels[0][0]);
	//printf("%x\n t\n", pixels[][], temp++);

	namedWindow("Original", WINDOW_AUTOSIZE);
	imshow("Original", image);

	waitKey(0);
	return 0;
}