using System;
using System.Linq;

namespace Tools_Library_Application_Software
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        int toolCount = 0;
        int toolCollectionSize = 30; // Cap change
        public ToolCollection[][] toolCategories;
        // Gardening Tools
        ToolCollection[] gardeningTools;
        ToolCollection lineTrimmers;
        ToolCollection lawnMowers; // Lawn Mowers
        ToolCollection handMowers; // Hand Tools
        ToolCollection wheelBarrows; // Wheel Barrows
        ToolCollection gardenPowerTools; // Garden Power Tools

        // Flooring Tools
        ToolCollection[] flooringTools;
        ToolCollection scrapers; // Scrapers
        ToolCollection floorLasers; // Floor Lasers
        ToolCollection floorLevellingTools; // Floor Levelling Tools
        ToolCollection floorLevellingMaterials; // Floor Levelling Materials
        ToolCollection floorHandTools; // Floor Hand Tools
        ToolCollection tilingTools; // Tiling Tools

        // Fencing Tools
        ToolCollection[] fencingTools;
        ToolCollection handTools; // Hand Tools
        ToolCollection electricFencing; // Electric Fencing
        ToolCollection steelFencingTools; // Steel Fencing Tools
        ToolCollection powerTools; // Power Tools
        ToolCollection fencingAccessories; // Fencing Accessories

        // Measuring Tools
        ToolCollection[] measuringTools;
        ToolCollection distanceTools; // Distance Tools
        ToolCollection laserMeasurer; // Laser Measurer
        ToolCollection measuringJugs; // Measuring Jugs
        ToolCollection tempretureAndHumidityTools; // Tempreture & Humidity Tools
        ToolCollection levellingTools; // Levelling Tools
        ToolCollection markers; // Markers

        // Cleaning Tools
        ToolCollection[] cleaningTools;
        ToolCollection draining; // Draining
        ToolCollection carCleaning; // Car Cleaning
        ToolCollection vacuum; // Vacuum
        ToolCollection pressureCleaners; // Pressure Cleaners
        ToolCollection poolCleaning; // Pool Cleaning
        ToolCollection floorCleaning; // Floor Cleaning

        // Painting Tools
        ToolCollection[] paintingTools;
        ToolCollection sandingTools; // Sanding Tools
        ToolCollection brushes; // Brushes
        ToolCollection rollers; // Rollers
        ToolCollection paintRemovalTools; // Paint Removal Tools
        ToolCollection paintScrapers; // Paint Scrapers
        ToolCollection sprayers; // Sprayers

        // Electronic Tools
        ToolCollection[] electronicTools;
        ToolCollection voltageTester; // Voltage Tester
        ToolCollection oscilloscopes; // Oscilloscopes
        ToolCollection thermalImaging; // Thermal Imagining
        ToolCollection dataTestTool; // Data Test Tool
        ToolCollection insulationTesters; // Insulation Testers

        // Electricity Tools
        ToolCollection[] electricityTools;
        ToolCollection testEquipment; // Test Equipment
        ToolCollection safetyEquipment; // Safety Equipment
        ToolCollection basicHandTools; // Basic Hand Tools
        ToolCollection circuitProtection; // Circuit Protection
        ToolCollection cableTools; // Circuit Tools

        // Automotive Tools
        ToolCollection[] automotiveTools;
        ToolCollection jacks; // Jacks
        ToolCollection airCompressors; // Air Compressors
        ToolCollection batteryChargers; // Battery Chargers
        ToolCollection socketTools; // Socket Tools
        ToolCollection braking; // Braking
        ToolCollection driveTrain; // Drive Train

        Tool newTool;
        public MemberCollection members;
        public ToolLibrarySystem()
        {
            toolCategories = new ToolCollection[9][];

            // Gardening Tools
            gardeningTools = toolCategories[0] = new ToolCollection[5];
            lineTrimmers = toolCategories[0][0] = new ToolCollection(toolCollectionSize); // Line Trimmers
            lawnMowers = toolCategories[0][1] = new ToolCollection(toolCollectionSize); // Lawn Mowers
            handMowers = toolCategories[0][2] = new ToolCollection(toolCollectionSize); // Hand Mowers
            wheelBarrows = toolCategories[0][3] = new ToolCollection(toolCollectionSize); // Wheel Barrows
            gardenPowerTools = toolCategories[0][4] = new ToolCollection(toolCollectionSize); // Garden Power Tools

            // Flooring Tools
            flooringTools = toolCategories[1] = new ToolCollection[6];
            scrapers = toolCategories[1][0] = new ToolCollection(toolCollectionSize); // Scrapers
            floorLasers = toolCategories[1][1] = new ToolCollection(toolCollectionSize); // Floor Lasers
            floorLevellingTools = toolCategories[1][2] = new ToolCollection(toolCollectionSize); // Floor Levelling Tools
            floorLevellingMaterials = toolCategories[1][3] = new ToolCollection(toolCollectionSize); // Floor Levelling Materials
            floorHandTools = toolCategories[1][4] = new ToolCollection(toolCollectionSize); // Floor Hand Tools
            tilingTools = toolCategories[1][5] = new ToolCollection(toolCollectionSize); // Tiling Tools

            // Fencing Tools
            fencingTools = toolCategories[2] = new ToolCollection[5];
            handTools = toolCategories[2][0] = new ToolCollection(toolCollectionSize); // Hand Tools
            electricFencing = toolCategories[2][1] = new ToolCollection(toolCollectionSize); // Electric Fencing
            steelFencingTools = toolCategories[2][2] = new ToolCollection(toolCollectionSize); // Steel Fencing Tools
            powerTools = toolCategories[2][3] = new ToolCollection(toolCollectionSize); // Power Tools
            fencingAccessories = toolCategories[2][4] = new ToolCollection(toolCollectionSize); // Fencing Accessories

            // Measuring Tools
            measuringTools = toolCategories[3] = new ToolCollection[6];
            distanceTools = toolCategories[3][0] = new ToolCollection(toolCollectionSize); // Distance Tools
            laserMeasurer = toolCategories[3][1] = new ToolCollection(toolCollectionSize); // Laser Measurer
            measuringJugs = toolCategories[3][2] = new ToolCollection(toolCollectionSize); // Measuring Jugs
            tempretureAndHumidityTools = toolCategories[3][3] = new ToolCollection(toolCollectionSize); // Tempreture & Humidity Tools
            levellingTools = toolCategories[3][4] = new ToolCollection(toolCollectionSize); // Levelling Tools
            markers = toolCategories[3][5] = new ToolCollection(toolCollectionSize); // Markers

            // Cleaning Tools
            cleaningTools = toolCategories[4] = new ToolCollection[6];
            draining = toolCategories[4][0] = new ToolCollection(toolCollectionSize); // Draining
            carCleaning = toolCategories[4][1] = new ToolCollection(toolCollectionSize); // Car Cleaning
            vacuum = toolCategories[4][2] = new ToolCollection(toolCollectionSize); // Vacuum
            pressureCleaners = toolCategories[4][3] = new ToolCollection(toolCollectionSize); // Pressure Cleaners
            poolCleaning = toolCategories[4][4] = new ToolCollection(toolCollectionSize); // Pool Cleaning
            floorCleaning = toolCategories[4][5] = new ToolCollection(toolCollectionSize); // Floor Cleaning

            // Painting Tools
            paintingTools = toolCategories[5] = new ToolCollection[6];
            sandingTools = toolCategories[5][0] = new ToolCollection(toolCollectionSize); // Sanding Tools
            brushes = toolCategories[5][1] = new ToolCollection(toolCollectionSize); // Brushes
            rollers = toolCategories[5][2] = new ToolCollection(toolCollectionSize); // Rollers
            paintRemovalTools = toolCategories[5][3] = new ToolCollection(toolCollectionSize); // Paint Removal Tools
            paintScrapers = toolCategories[5][4] = new ToolCollection(toolCollectionSize); // Paint Scrapers
            sprayers = toolCategories[5][5] = new ToolCollection(toolCollectionSize); // Sprayers

            // Electronic Tools
            electronicTools = toolCategories[6] = new ToolCollection[5];
            voltageTester = toolCategories[6][0] = new ToolCollection(toolCollectionSize); // Voltage Tester
            oscilloscopes = toolCategories[6][1] = new ToolCollection(toolCollectionSize); // Oscilloscopes
            thermalImaging = toolCategories[6][2] = new ToolCollection(toolCollectionSize); // Thermal Imagining
            dataTestTool = toolCategories[6][3] = new ToolCollection(toolCollectionSize); // Data Test Tool
            insulationTesters = toolCategories[6][4] = new ToolCollection(toolCollectionSize); // Insulation Testers

            // Electricity Tools
            electricityTools = toolCategories[7] = new ToolCollection[5];
            testEquipment = toolCategories[7][0] = new ToolCollection(toolCollectionSize); // Test Equipment
            safetyEquipment = toolCategories[7][1] = new ToolCollection(toolCollectionSize); // Safety Equipment
            basicHandTools = toolCategories[7][2] = new ToolCollection(toolCollectionSize); // Basic Hand Tools
            circuitProtection = toolCategories[7][3] = new ToolCollection(toolCollectionSize); // Circuit Protection
            cableTools = toolCategories[7][4] = new ToolCollection(toolCollectionSize); // Circuit Tools

            // Automotive Tools
            automotiveTools = toolCategories[8] = new ToolCollection[6];
            jacks = toolCategories[8][0] = new ToolCollection(toolCollectionSize); // Jacks
            airCompressors = toolCategories[8][1] = new ToolCollection(toolCollectionSize); // Air Compressors
            batteryChargers = toolCategories[8][2] = new ToolCollection(toolCollectionSize); // Battery Chargers
            socketTools = toolCategories[8][3] = new ToolCollection(toolCollectionSize); // Socket Tools
            braking = toolCategories[8][4] = new ToolCollection(toolCollectionSize); // Braking
            driveTrain = toolCategories[8][5] = new ToolCollection(toolCollectionSize); // Drive Train

            members = new MemberCollection();
        }

        public MemberCollection Members
        {
            get => members;
        }

        public void add(Tool aTool)
        {
            newTool = aTool;
        }

        public void add(Tool aTool, int quantity)
        {
            for (int i = 1; i < toolCategories.Length; i++)
            {
                for (int j = 1; j < toolCategories[i].Length; j++)
                {
                    if (toolCategories[i][j].search(aTool))
                    {
                        aTool.Quantity += quantity;
                    }
                }
            }
        }

        public void add(Tool tool, ToolTypes toolType)
        {
            toolCollectionSelection(toolType).add(tool);
            Console.WriteLine("New Tool Added");
            toolCount += 1;
        }

        public void add(Member aMember)
        {
            members.add(aMember);
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            aMember.addTool(aTool);
            aTool.addBorrower(aMember);
        }

        public void delete(Tool aTool)
        {
            for (int i = 1; i < toolCategories.Length; i++)
            {
                for (int j = 1; j < toolCategories[i].Length; j++)
                {
                    if (toolCategories[i][j].search(aTool))
                    {
                        toolCategories[i][j].delete(aTool);
                        Console.WriteLine("Tool Deleted");
                        toolCount -= 1;
                    }
                }
            }
        }

        public void delete(Tool aTool, int quantity)
        {
            string message = "";
            for (int i = 1; i < toolCategories.Length; i++)
            {
                for (int j = 1; j < toolCategories[i].Length; j++)
                {
                    if (toolCategories[i][j].search(aTool))
                    {
                        aTool.Quantity--;
                        message = "Tool quantity is now " + aTool.Quantity;
                        break;
                    }
                    else
                    {
                        //message = "Tool not found";
                    }
                }
            }
            Console.WriteLine(message);
        }


        public void delete(Member aMember)
        {
            members.delete(aMember);
        }

        public void displayBorrowingTools(Member aMember)
        {
            if (members.search(aMember) == true)
            {
                aMember.GetMemberTools();
            }
            else
            {
                Console.WriteLine("Member Doesn't Exist");
            }
        }

        public void displayTools(string aToolType)
        {
            bool notFound = false;
            ToolTypes toolTypes = ToolTypes.airCompressors;
            switch (aToolType)
            {
                // Garden Tools
                case "Line Trimmers":
                    toolTypes = ToolTypes.lineTrimmers;
                    break;
                case "Lawn Mowers":
                    toolTypes = ToolTypes.lawnMowers;
                    break;
                case "Hand Mowers":
                    toolTypes = ToolTypes.handMowers;
                    break;
                case "Wheel Barrows":
                    toolTypes = ToolTypes.wheelBarrows;
                    break;
                case "Garden Power Tools":
                    toolTypes = ToolTypes.gardenPowerTools;
                    break;

                // Garden Tools
                case "Scapers":
                    toolTypes = ToolTypes.scrapers;
                    break;
                case "Floor Lasers":
                    toolTypes = ToolTypes.floorLasers;
                    break;
                case "Floor Levelling Tools":
                    toolTypes = ToolTypes.floorLevellingTools;
                    break;
                case "Floor Levelling Materials":
                    toolTypes = ToolTypes.floorLevellingMaterials;
                    break;
                case "Floor Hand Tools":
                    toolTypes = ToolTypes.floorLasers;
                    break;
                case "Tiling Tools":
                    toolTypes = ToolTypes.tilingTools;
                    break;

                // Garden Tools
                case "Hand Tools":
                    toolTypes = ToolTypes.scrapers;
                    break;
                case "Electric Fencing":
                    toolTypes = ToolTypes.floorLasers;
                    break;
                case "Steel Fencing Tools":
                    toolTypes = ToolTypes.floorLevellingTools;
                    break;
                case "Power Tools":
                    toolTypes = ToolTypes.floorLevellingMaterials;
                    break;
                case "Fencing Accessories":
                    toolTypes = ToolTypes.floorLasers;
                    break;

                // Garden Tools
                case "Distance Tools":
                    toolTypes = ToolTypes.distanceTools;
                    break;
                case "Laser Measurer":
                    toolTypes = ToolTypes.laserMeasurer;
                    break;
                case "Measuring Jugs":
                    toolTypes = ToolTypes.measuringJugs;
                    break;
                case "Tempreture & Humidity Tools":
                    toolTypes = ToolTypes.tempretureAndHumidityTools;
                    break;
                case "Levelling Tools":
                    toolTypes = ToolTypes.levellingTools;
                    break;
                case "Markers":
                    toolTypes = ToolTypes.markers;
                    break;

                // Garden Tools
                case "Draining":
                    toolTypes = ToolTypes.draining;
                    break;
                case "Car Cleaning":
                    toolTypes = ToolTypes.carCleaning;
                    break;
                case "Vacuum":
                    toolTypes = ToolTypes.vacuum;
                    break;
                case "Pressure Cleaners":
                    toolTypes = ToolTypes.pressureCleaners;
                    break;
                case "Pool Cleaning":
                    toolTypes = ToolTypes.poolCleaning;
                    break;
                case "Floor Cleaning":
                    toolTypes = ToolTypes.floorCleaning;
                    break;

                // Garden Tools
                case "Sanding Tools":
                    toolTypes = ToolTypes.sandingTools;
                    break;
                case "Brushes":
                    toolTypes = ToolTypes.brushes;
                    break;
                case "Rollers":
                    toolTypes = ToolTypes.rollers;
                    break;
                case "Paint Removal Tools":
                    toolTypes = ToolTypes.paintRemovalTools;
                    break;
                case "Paint Scrapers":
                    toolTypes = ToolTypes.paintScrapers;
                    break;
                case "Sprayers":
                    toolTypes = ToolTypes.sprayers;
                    break;

                // Garden Tools
                case "Voltage Tester":
                    toolTypes = ToolTypes.voltageTester;
                    break;
                case "Oscilloscopes":
                    toolTypes = ToolTypes.oscilloscopes;
                    break;
                case "Thermal Imaging":
                    toolTypes = ToolTypes.thermalImaging;
                    break;
                case "Data test Tools":
                    toolTypes = ToolTypes.dataTestTool;
                    break;
                case "Insulation Testers":
                    toolTypes = ToolTypes.insulationTesters;
                    break;

                // Garden Tools
                case "Test Equipment":
                    toolTypes = ToolTypes.testEquipment;
                    break;
                case "Safety Equipment":
                    toolTypes = ToolTypes.safetyEquipment;
                    break;
                case "Basic Hand Tools":
                    toolTypes = ToolTypes.basicHandTools;
                    break;
                case "Circuit Protection":
                    toolTypes = ToolTypes.circuitProtection;
                    break;
                case "Cable Tools":
                    toolTypes = ToolTypes.cableTools;
                    break;

                // Garden Tools
                case "Jacks":
                    toolTypes = ToolTypes.jacks;
                    break;
                case "Air Compressors":
                    toolTypes = ToolTypes.airCompressors;
                    break;
                case "Battery Chargers":
                    toolTypes = ToolTypes.batteryChargers;
                    break;
                case "Socket Tools":
                    toolTypes = ToolTypes.socketTools;
                    break;
                case "Braking":
                    toolTypes = ToolTypes.braking;
                    break;
                case "Drivetrain":
                    toolTypes = ToolTypes.driveTrain;
                    break;
                default:
                    Console.WriteLine("Tool Type not found\n");
                    notFound = true;
                    break;
            }

            if (notFound == false)
            {
                Console.WriteLine(aToolType + ":");
                toolCollectionSelection(toolTypes).writeToolsToConsole();
            }
        }

        public ToolCollection toolCollectionSelection(ToolTypes toolType)
        {
            switch (toolType)
            {
                // Garden Tools
                case ToolTypes.lineTrimmers:
                    return toolCategories[0][0];
                case ToolTypes.lawnMowers:
                    return toolCategories[0][1];
                case ToolTypes.handMowers:
                    return toolCategories[0][2];
                case ToolTypes.wheelBarrows:
                    return toolCategories[0][3];
                case ToolTypes.gardenPowerTools:
                    return toolCategories[0][4];

                // Flooring Tools
                case ToolTypes.scrapers:
                    return toolCategories[1][0];
                case ToolTypes.floorLasers:
                    return toolCategories[1][1];
                case ToolTypes.floorLevellingTools:
                    return toolCategories[1][2];
                case ToolTypes.floorLevellingMaterials:
                    return toolCategories[1][3];
                case ToolTypes.floorHandTools:
                    return toolCategories[1][4];
                case ToolTypes.tilingTools:
                    return toolCategories[1][5];

                // Fencing Tools
                case ToolTypes.handTools:
                    return toolCategories[2][0];
                case ToolTypes.electricFencing:
                    return toolCategories[2][1];
                case ToolTypes.steelFencingTools:
                    return toolCategories[2][2];
                case ToolTypes.powerTools:
                    return toolCategories[2][3];
                case ToolTypes.fencingAccessories:
                    return toolCategories[2][4];

                // Measuring Tools
                case ToolTypes.distanceTools:
                    return toolCategories[3][0];
                case ToolTypes.laserMeasurer:
                    return toolCategories[3][1];
                case ToolTypes.measuringJugs:
                    return toolCategories[3][2];
                case ToolTypes.tempretureAndHumidityTools:
                    return toolCategories[3][3];
                case ToolTypes.levellingTools:
                    return toolCategories[3][4];
                case ToolTypes.markers:
                    return toolCategories[3][5];

                // Cleaning Tools
                case ToolTypes.draining:
                    return toolCategories[4][0];
                case ToolTypes.carCleaning:
                    return toolCategories[4][1];
                case ToolTypes.vacuum:
                    return toolCategories[4][2];
                case ToolTypes.pressureCleaners:
                    return toolCategories[4][3];
                case ToolTypes.poolCleaning:
                    return toolCategories[4][4];
                case ToolTypes.floorCleaning:
                    return toolCategories[4][5];

                // Painting Tools
                case ToolTypes.sandingTools:
                    return toolCategories[5][0];
                case ToolTypes.brushes:
                    return toolCategories[5][1];
                case ToolTypes.rollers:
                    return toolCategories[5][2];
                case ToolTypes.paintRemovalTools:
                    return toolCategories[5][3];
                case ToolTypes.paintScrapers:
                    return toolCategories[5][4];
                case ToolTypes.sprayers:
                    return toolCategories[5][5];

                // Electronic Tools
                case ToolTypes.voltageTester:
                    return toolCategories[6][0];
                case ToolTypes.oscilloscopes:
                    return toolCategories[6][1];
                case ToolTypes.thermalImaging:
                    return toolCategories[6][2];
                case ToolTypes.dataTestTool:
                    return toolCategories[6][3];
                case ToolTypes.insulationTesters:
                    return toolCategories[6][4];

                // Electricity Tools
                case ToolTypes.testEquipment:
                    return toolCategories[7][0];
                case ToolTypes.safetyEquipment:
                    return toolCategories[7][1];
                case ToolTypes.basicHandTools:
                    return toolCategories[7][2];
                case ToolTypes.circuitProtection:
                    return toolCategories[7][3];
                case ToolTypes.cableTools:
                    return toolCategories[7][4];

                // Automotive Tools
                case ToolTypes.jacks:
                    return toolCategories[8][0];
                case ToolTypes.airCompressors:
                    return toolCategories[8][1];
                case ToolTypes.batteryChargers:
                    return toolCategories[8][2];
                case ToolTypes.socketTools:
                    return toolCategories[8][3];
                case ToolTypes.braking:
                    return toolCategories[8][4];
                case ToolTypes.driveTrain:
                    return toolCategories[8][5];
                default:
                    Console.WriteLine("Tool Type Doesn't Exist");
                    return null;
            }
        }

        public string[] listTools(Member aMember)
        {
            if (members.search(aMember))
            {
                return aMember.Tools;
            }
            else
            {
                string[] message = { "No Member Tools" };
                return message;
            }
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            aMember.deleteTool(aTool);
            aTool.deleteBorrower(aMember);
            Console.WriteLine("Tool returned");
        }

        public void displayMembers()
        {
            foreach (Member member in members.toArray())
            {
                Console.WriteLine(member.ToString());
            }
        }

        public void findMemberDetails(string firstName, string lastName)
        {
            Member searchMember = new Member(firstName, lastName, null, null);
            bool found = false;
            foreach (Member member in members.toArray())
            {
                if (member.FirstName == searchMember.FirstName && member.LastName == searchMember.LastName)
                {
                    searchMember.ContactNumber = member.ContactNumber;
                    searchMember.PIN = member.PIN;
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine(searchMember.FirstName + " " + searchMember.LastName + ": \n " +
                    "Contact Number:\n" +
                    searchMember.ContactNumber +
                    "Member Pin:\n" +
                    searchMember.PIN);
            }
            else
            {
                Console.WriteLine("Member not found");
            }

        }
        public bool memberLogin(Member aMember)
        {
            bool accessAccepted = false;
            foreach (Member member in members.toArray())
            {
                if (member.FirstName == aMember.FirstName && member.LastName == aMember.LastName && member.PIN == aMember.PIN)
                {
                    aMember = member;
                    accessAccepted = true;
                }
                else
                {
                    accessAccepted = false;
                }
            }
            return accessAccepted;
        }
        public void displayTopTHree()
        {
            ToolCollection allTools = new ToolCollection(toolCount);

            for (int i = 0; i < toolCategories.Length; i++)
            {
                for (int j = 0; j < toolCategories[i].Length; j++)
                {
                    foreach (Tool tool in toolCategories[i][j].toArray() ?? Enumerable.Empty<Tool>())
                    {
                        if (tool != null)
                        {
                            allTools.add(tool);
                        }
                    }
                }
            }

            Tool[] totalTool = allTools.toArray();
            heapSort(totalTool, toolCount - 1);

            for (int i = totalTool.Length - 1; i > totalTool.Length - 4; i--)
            {
                Console.WriteLine("{0}) {1}", totalTool.Length - i, totalTool[i]);
            }
            
        }
        public static void heapSort(Tool[] arr, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                Tool temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        static void heapify(Tool[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left].NoBorrowings > arr[largest].NoBorrowings)
                largest = left;
            if (right < n && arr[right].NoBorrowings > arr[largest].NoBorrowings)
                largest = right;
            if (largest != i)
            {
                Tool swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }
    }
}
