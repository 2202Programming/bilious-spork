#include "stdafx.h"
#include "CppUnitTest.h"
#include "CommmandListMaker.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace auton
{		
	TEST_CLASS(TestOne)
	{
	public:
		
		TEST_METHOD(MakeBasicTest)
		{
			// TODO: Your test code here
			CommmandListMaker* clm = new CommmandListMaker();
			clm->makeBasic();

			int x = 0;
			driveStep* one = new driveStep();
			one->distance = 2;
			one->speed = 2;
			one->command = stepBase::step::driveStraight;
			one->stepNum = x; x++;

			stepBase* two = new stepBase();
			two->command = stepBase::step::stop;
			one->stepNum = x; x++;

			driveStep* oneR = (driveStep*)clm->storage->at(0);
			stepBase* twoR = (driveStep*)clm->storage->at(1);

			Assert::AreEqual(true, one->equals(*oneR));
			Assert::AreEqual(true, two->equals(*twoR));
			delete clm;
		}

		TEST_METHOD(makeDefenceBreaker)
		{
			CommmandListMaker* clm = new CommmandListMaker();
			clm->defence = clm->deb;
			clm->position = clm->pos4;
			clm->makeDefenceBreaker();
			vector<stepBase*>* str = clm->storage;

			Assert::AreEqual((int)str->size(), 5);

			delete clm;
		}

	};
}