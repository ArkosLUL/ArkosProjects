import sys
import argparse
import os
import shutil
import glob
import pathlib

def createParser ():
	parser = argparse.ArgumentParser()
	parser.add_argument ('-R', action = 'store_true', help = 'Enable recoursion while counting subdirectories')
	parser.add_argument ('-D', nargs = 1, type = str, help = 'Set directory to count subdirectories')

	return parser

if __name__ == '__main__':
	global j
	parser = createParser()
	args = parser.parse_args(sys.argv[1:])
	
	if args.D:
		for dir in args.D:
			if os.path.exists(dir):
				path = dir
			else:
				print("Directory {} doesn't exist.".format(dir))
				exit(-1)
	else:
		string = str(os.environ.get('PATHCMD',""))
		if(string != ""):
			path = string
		else:
			path = os.path.dirname(os.path.abspath(__file__))
				
	if args.R:
		j = 0
		for rootdir, dirs, files in os.walk(path):
			for dir in dirs:
					j = j + 1
				
					
	else:
		j = 0
		for rootdir, dirs, files in os.walk(path):
			for dir in dirs:
				if rootdir == path:
						j = j + 1

	print("Найдено {}".format(j) + " подпапок")
	exit(j)

