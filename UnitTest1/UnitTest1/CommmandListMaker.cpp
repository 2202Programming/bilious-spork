#include "stdafx.h"
#include "CommmandListMaker.h"
#define TURNIF_NOSHOT true

namespace auton
{
	CommmandListMaker::CommmandListMaker()
	{
		storage = new std::vector<stepBase*>();
		defence = ram;
		position = pos3;
	}

	CommmandListMaker::~CommmandListMaker()
	{
	}

	void CommmandListMaker::makeBasic() 
	{
			int x = 0;

			driveStep* one = new driveStep();
			one->distance = 2;
			one->speed = 2;
			one->command = stepBase::step::driveStraight;
			one->stepNum = x; x++;
			storage->push_back(one);

			stepBase* two = new stepBase();
			two->command = stepBase::step::stop;
			one->stepNum = x; x++;
			storage->push_back(two);
		
	}

	void CommmandListMaker::makeDefenceBreaker()
	{
		/* Gets the current selction from the dashboard (should default to LowBar)*/
		//Selection

		void* temp = static_cast<void*>(&defence);
		std::string* defence = static_cast<std::string*>(temp);

		temp = static_cast<void*>(&position);
		string* position = static_cast<std::string*>(temp);

		//Bool determining if Shooting is possible on the current defence
		bool CanShoot = false;

		//Step Number Needs to be tracked
		int GlobalStep = 0;

		//Fist Drive Step Distance and Speed
		double DriveDistance;
		double DriveSpeed;

		//The Step We Are Going to Pass
		driveStep* drive = new driveStep();

		//Which Defence we are going over determines the speed and distance they will go
		//But ignores the type and number
		if (defence->compare(deb) == 0)	//DEBRIS
		{
			DriveDistance = 28;
			CanShoot = true;
			DriveSpeed = .75;
		}
		else if (defence->compare(ram)) //RAMPARTS
		{
			DriveDistance = 28;
			DriveSpeed = .75;
			CanShoot = true;
		}
		else if (defence->compare(rock)) //ROCK WALL
		{
			DriveDistance = 28;
			DriveSpeed = .75;
		}
		else if (defence->compare(low)) // LOW BAR
		{
			DriveDistance = 28;
			DriveSpeed = .75;
		}
		else if (defence->compare(moat) == 0) // Moat
		{
			DriveDistance = 28;
			DriveSpeed = .75;
		}
		else //THE OTHERS
		{

			DriveDistance = 0.5;
			DriveSpeed = 0.5;
			CanShoot = false;
		}

		//Seting the Values and Pushing the Command
		drive->stepNum = GlobalStep;
		GlobalStep++;
		drive->command = stepBase::driveStraight;
		drive->distance = DriveDistance;
		drive->speed = DriveSpeed;
		storage->push_back(drive);

		//Turn Decision based on position
		if (CanShoot || TURNIF_NOSHOT) {
			//Eventual TurnStep
			turnStep *turn = new turnStep();

			//The Position it is in gotten through 'rough' means
			int pos = 1;
			pos = position->at(position->length() - 1) - '0';

			//Turn angle and
			double TurnAngle;
			double TurnSpeed; //TODO Remove from IControl this is't used

							  //Switch Controller;
			switch (pos) {
			case 1:
				TurnAngle = 39.09;
				TurnSpeed = .6;
				break;
			case 2:
				TurnAngle = 27.11;
				TurnSpeed = .6;
				break;
			case 3:
				TurnAngle = 11.95;
				TurnSpeed = .6;
				break;
			case 4:
				TurnAngle = -5.06;
				TurnSpeed = .6;
				break;
			case 5:
				TurnAngle = -21.25;
				TurnSpeed = .6;
				break;
			default:
				TurnAngle = 0;
				TurnSpeed = .6;
				break;
			}

			//Sets and Push the Actual Step
			turn->stepNum = GlobalStep;
			GlobalStep++;
			turn->command = stepBase::turn;
			turn->angle = TurnAngle;
			turn->speed = TurnSpeed;
			storage->push_back(turn);
		}

		if (CanShoot) {
			stepBase* prepareShot = new stepBase();
			prepareShot->stepNum = GlobalStep;
			GlobalStep++;
			prepareShot->command = stepBase::target;
			storage->push_back(prepareShot);

			stepBase* shoot = new stepBase();
			shoot->stepNum = GlobalStep;
			GlobalStep++;
			shoot->command = stepBase::shoot;
			storage->push_back(shoot);
		}

		stepBase* stop = new stepBase();
		stop->stepNum = GlobalStep;
		GlobalStep++;
		stop->command = stepBase::stop;
		storage->push_back(stop);
	}
}