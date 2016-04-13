#pragma once
#include <stdio.h>
#include <vector>
#include <string>

using namespace std;
namespace auton
{

	class stepBase {
	public:

		enum step {
			driveStraight,
			turn,
			target,
			shoot,
			stop,
		};

		int stepNum;
		step command;

		bool equals(stepBase x)
		{
			return stepNum == x.stepNum && command == x.command;
		}
	};

	class driveStep : public stepBase {
	public:
		float distance;
		float speed;

		bool equals(driveStep x)
		{
			return stepBase::equals(x) && distance == x.distance && speed == x.speed;
		}
	};

	class turnStep :public stepBase {
	public:
		float speed;
		float angle;

		bool equals(turnStep x)
		{
			return stepBase::equals(x) && speed == x.speed && angle == x.angle;
		}
	};



	class CommmandListMaker
	{

	public:
		CommmandListMaker();
		~CommmandListMaker();

		string defence;
		string position;

		vector<stepBase*>* storage;

		void makeDefenceBreaker();

		void makeBasic();

		std::string ram = "Ramparts";
		std::string low = "Low Bar";
		std::string rock = "Rock Wall";
		std::string port = "Portculis";
		std::string chev = "Cheval de Frise";
		std::string sall = "Sally Port";
		std::string deb = "Rough Terrain";
		std::string moat = "Moat";
		std::string draw = "Drawbridge";

		std::string pos1 = "Position 1";
		std::string pos2 = "Position 2";
		std::string pos3 = "Position 3";
		std::string pos4 = "Position 4";
		std::string pos5 = "Position 5";

	};
}
