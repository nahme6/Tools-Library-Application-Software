using System;

namespace Tools_Library_Application_Software
{
    public class ToolLibrarySystem : iToolLibrarySystem
    {
        static int toolCollectionSize = 0;
        static ToolCollection[][] toolCategories;

        // Gardening Tools
        ToolCollection[] gardeningTools;
        ToolCollection lineTrimmers
        ToolCollection lawnMowers = toolCategories[0][1] = new ToolCollection(toolCollectionSize); // Lawn Mowers
        ToolCollection handMowers = toolCategories[0][2] = new ToolCollection(toolCollectionSize); // Hand Tools
        ToolCollection wheelBarrows = toolCategories[0][3] = new ToolCollection(toolCollectionSize); // Wheel Barrows
        ToolCollection gardenPowerTools = toolCategories[0][4] = new ToolCollection(toolCollectionSize); // Garden Power Tools

        // Flooring Tools
        ToolCollection[] flooringTools = toolCategories[1] = new ToolCollection[5];
        ToolCollection scrapers = toolCategories[1][0] = new ToolCollection(toolCollectionSize); // Scrapers
        ToolCollection floorLasers = toolCategories[1][1] = new ToolCollection(toolCollectionSize); // Floor Lasers
        ToolCollection floorLevellingTools = toolCategories[1][2] = new ToolCollection(toolCollectionSize); // Floor Levelling Tools
        ToolCollection floorLevellingMaterials = toolCategories[1][3] = new ToolCollection(toolCollectionSize); // Floor Levelling Materials
        ToolCollection floorHandTools = toolCategories[1][4] = new ToolCollection(toolCollectionSize); // Floor Hand Tools
        ToolCollection tilingTools = toolCategories[1][5] = new ToolCollection(toolCollectionSize); // Tiling Tools

        // Fencing Tools
        ToolCollection[] fencingTools = toolCategories[2] = new ToolCollection[4];
        ToolCollection handTools = toolCategories[2][0] = new ToolCollection(toolCollectionSize); // Hand Tools
        ToolCollection electricFencing = toolCategories[2][1] = new ToolCollection(toolCollectionSize); // Electric Fencing
        ToolCollection steelFencingTools = toolCategories[2][2] = new ToolCollection(toolCollectionSize); // Steel Fencing Tools
        ToolCollection powerTools = toolCategories[2][3] = new ToolCollection(toolCollectionSize); // Power Tools
        ToolCollection fencingAccessories = toolCategories[2][4] = new ToolCollection(toolCollectionSize); // Fencing Accessories

        // Measuring Tools
        ToolCollection[] measuringTools = toolCategories[3] = new ToolCollection[5];
        ToolCollection distanceTools = toolCategories[3][0] = new ToolCollection(toolCollectionSize); // Distance Tools
        ToolCollection laserMeasurer = toolCategories[3][1] = new ToolCollection(toolCollectionSize); // Laser Measurer
        ToolCollection measuringJugs = toolCategories[3][2] = new ToolCollection(toolCollectionSize); // Measuring Jugs
        ToolCollection tempretureAndHumidityTools = toolCategories[3][3] = new ToolCollection(toolCollectionSize); // Tempreture & Humidity Tools
        ToolCollection levellingTools = toolCategories[3][4] = new ToolCollection(toolCollectionSize); // Levelling Tools
        ToolCollection markers = toolCategories[3][5] = new ToolCollection(toolCollectionSize); // Markers

        // Cleaning Tools
        ToolCollection[] cleaningTools = toolCategories[4] = new ToolCollection[5];
        ToolCollection draining = toolCategories[4][0] = new ToolCollection(toolCollectionSize); // Draining
        ToolCollection carCleaning = toolCategories[4][1] = new ToolCollection(toolCollectionSize); // Car Cleaning
        ToolCollection vacuum = toolCategories[4][2] = new ToolCollection(toolCollectionSize); // Vacuum
        ToolCollection pressureCleaners = toolCategories[4][3] = new ToolCollection(toolCollectionSize); // Pressure Cleaners
        ToolCollection poolCleaning = toolCategories[4][4] = new ToolCollection(toolCollectionSize); // Pool Cleaning
        ToolCollection floorCleaning = toolCategories[4][5] = new ToolCollection(toolCollectionSize); // Floor Cleaning

        // Painting Tools
        ToolCollection[] paintingTools = toolCategories[5] = new ToolCollection[5];
        ToolCollection sandingTools = toolCategories[5][0] = new ToolCollection(toolCollectionSize); // Sanding Tools
        ToolCollection brushes = toolCategories[5][1] = new ToolCollection(toolCollectionSize); // Brushes
        ToolCollection rollers = toolCategories[5][2] = new ToolCollection(toolCollectionSize); // Rollers
        ToolCollection paintRemovalTools = toolCategories[5][3] = new ToolCollection(toolCollectionSize); // Paint Removal Tools
        ToolCollection paintScrapers = toolCategories[5][4] = new ToolCollection(toolCollectionSize); // Paint Scrapers
        ToolCollection sprayers = toolCategories[5][5] = new ToolCollection(toolCollectionSize); // Sprayers

        // Electronic Tools
        ToolCollection[] electronicTools = toolCategories[6] = new ToolCollection[4];
        ToolCollection voltageTester = toolCategories[6][0] = new ToolCollection(toolCollectionSize); // Voltage Tester
        ToolCollection oscilloscopes = toolCategories[6][1] = new ToolCollection(toolCollectionSize); // Oscilloscopes
        ToolCollection thermalImaging = toolCategories[6][2] = new ToolCollection(toolCollectionSize); // Thermal Imagining
        ToolCollection dataTestTool = toolCategories[6][3] = new ToolCollection(toolCollectionSize); // Data Test Tool
        ToolCollection insulationTesters = toolCategories[6][4] = new ToolCollection(toolCollectionSize); // Insulation Testers

        // Electricity Tools
        ToolCollection[] electricityTools = toolCategories[7] = new ToolCollection[4];
        ToolCollection testEquipment = toolCategories[7][0] = new ToolCollection(toolCollectionSize); // Test Equipment
        ToolCollection safetyEquipment = toolCategories[7][1] = new ToolCollection(toolCollectionSize); // Safety Equipment
        ToolCollection basicHandTools = toolCategories[7][2] = new ToolCollection(toolCollectionSize); // Basic Hand Tools
        ToolCollection circuitProtection = toolCategories[7][3] = new ToolCollection(toolCollectionSize); // Circuit Protection
        ToolCollection cableTools = toolCategories[7][4] = new ToolCollection(toolCollectionSize); // Circuit Tools

        // Automotive Tools
        ToolCollection[] automotiveTools = toolCategories[8] = new ToolCollection[5];
        ToolCollection jacks = toolCategories[8][0] = new ToolCollection(toolCollectionSize); // Jacks
        ToolCollection airCompressors = toolCategories[8][1] = new ToolCollection(toolCollectionSize); // Air Compressors
        ToolCollection batteryChargers = toolCategories[8][2] = new ToolCollection(toolCollectionSize); // Battery Chargers
        ToolCollection socketTools = toolCategories[8][3] = new ToolCollection(toolCollectionSize); // Socket Tools
        ToolCollection braking = toolCategories[8][4] = new ToolCollection(toolCollectionSize); // Braking
        ToolCollection driveTrain = toolCategories[8][5] = new ToolCollection(toolCollectionSize); // Drive Train

        Tool newTool;
        Tool deleteTool;
        public ToolLibrarySystem()
        {
            toolCategories = new ToolCollection[8][];
            toolCategories[0] = new ToolCollection[4];
            gardeningTools = toolCategories[0];
            lineTrimmers = toolCategories[0][0] = new ToolCollection(toolCollectionSize); // Line Trimmers
        }

        public void add(Tool aTool)
        {
            newTool = aTool;
        }

        public void add(Tool aTool, int quantity)
        {
            newTool = aTool;
            newTool.Quantity = quantity;

        }

        public void add(Tool tool, ToolTypes toolType)
        {
            switch (toolType)
            {
                
                // Gardening Tools
                case ToolTypes.lineTrimmers:
                    lineTrimmers.add(tool);
                    break;
                case ToolTypes.lawnMowers:
                    lawnMowers.add(tool);
                    break;
                case ToolTypes.handMowers:
                    handMowers.add(tool);
                    break;
                case ToolTypes.wheelBarrows:
                    wheelBarrows.add(tool);
                    break;
                case ToolTypes.gardenPowerTools:
                    gardenPowerTools.add(tool);
                    break;

                // Flooring Tools
                case ToolTypes.scrapers:
                    scrapers.add(tool);
                    break;
                case ToolTypes.floorLasers:
                    floorLasers.add(tool);
                    break;
                case ToolTypes.floorLevellingTools:
                    floorLevellingTools.add(tool);
                    break;
                case ToolTypes.floorLevellingMaterials:
                    floorLevellingMaterials.add(tool);
                    break;
                case ToolTypes.floorHandTools:
                    floorHandTools.add(tool);
                    break;
                case ToolTypes.tilingTools:
                    tilingTools.add(tool);
                    break;

                // Fencing Tools
                case ToolTypes.handTools:
                    handTools.add(tool);
                    break;
                case ToolTypes.electricFencing:
                    electricFencing.add(tool);
                    break;
                case ToolTypes.steelFencingTools:
                    steelFencingTools.add(tool);
                    break;
                case ToolTypes.powerTools:
                    powerTools.add(tool);
                    break;
                case ToolTypes.fencingAccessories:
                    fencingAccessories.add(tool);
                    break;

                // Measuring Tools
                case ToolTypes.distanceTools:
                    distanceTools.add(tool);
                    break;
                case ToolTypes.laserMeasurer:
                    laserMeasurer.add(tool);
                    break;
                case ToolTypes.measuringJugs:
                    measuringJugs.add(tool);
                    break;
                case ToolTypes.tempretureAndHumidityTools:
                    tempretureAndHumidityTools.add(tool);
                    break;
                case ToolTypes.levellingTools:
                    levellingTools.add(tool);
                    break;
                case ToolTypes.markers:
                    markers.add(tool);
                    break;

                // Cleaning Tools
                case ToolTypes.draining:
                    draining.add(tool);
                    break;
                case ToolTypes.carCleaning:
                    carCleaning.add(tool);
                    break;
                case ToolTypes.vacuum:
                    vacuum.add(tool);
                    break;
                case ToolTypes.pressureCleaners:
                    pressureCleaners.add(tool);
                    break;
                case ToolTypes.poolCleaning:
                    poolCleaning.add(tool);
                    break;
                case ToolTypes.floorCleaning:
                    floorCleaning.add(tool);
                    break;

                // Painting Tools
                case ToolTypes.sandingTools:
                    sandingTools.add(tool);
                    break;
                case ToolTypes.brushes:
                    brushes.add(tool);
                    break;
                case ToolTypes.rollers:
                    rollers.add(tool);
                    break;
                case ToolTypes.paintRemovalTools:
                    paintRemovalTools.add(tool);
                    break;
                case ToolTypes.paintScrapers:
                    paintScrapers.add(tool);
                    break;
                case ToolTypes.sprayers:
                    sprayers.add(tool);
                    break;

                // Electronic Tools
                case ToolTypes.voltageTester:
                    voltageTester.add(tool);
                    break;
                case ToolTypes.oscilloscopes:
                    oscilloscopes.add(tool);
                    break;
                case ToolTypes.thermalImaging:
                    thermalImaging.add(tool);
                    break;
                case ToolTypes.dataTestTool:
                    dataTestTool.add(tool);
                    break;
                case ToolTypes.insulationTesters:
                    insulationTesters.add(tool);
                    break;

                // Electricity Tools
                case ToolTypes.testEquipment:
                    testEquipment.add(tool);
                    break;
                case ToolTypes.safetyEquipment:
                    safetyEquipment.add(tool);
                    break;
                case ToolTypes.basicHandTools:
                    basicHandTools.add(tool);
                    Console.WriteLine(tool.Name + " " + "Added to Tools Library");
                    break;
                case ToolTypes.circuitProtection:
                    circuitProtection.add(tool);
                    break;
                case ToolTypes.cableTools:
                    cableTools.add(tool);
                    break;

                // Automotive Tools
                case ToolTypes.jacks:
                    jacks.add(tool);
                    break;
                case ToolTypes.airCompressors:
                    airCompressors.add(tool);
                    break;
                case ToolTypes.batteryChargers:
                    batteryChargers.add(tool);
                    break;
                case ToolTypes.socketTools:
                    socketTools.add(tool);
                    break;
                case ToolTypes.braking:
                    braking.add(tool);
                    break;
                case ToolTypes.driveTrain:
                    driveTrain.add(tool);
                    break;
                default:
                    Console.WriteLine("Tool Type Doesn't Exist");
                    break;
            }
        }

        public void add(Member aMember)
        {
            //members.add(aMember);
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            aTool.addBorrower(aMember);
            aMember.addTool(aTool);
        }

        public void delete(Tool aTool)
        {
            deleteTool = aTool;
        }

        public void delete(Tool aTool, int quantity)
        {
            deleteTool = aTool;
            deleteTool.Quantity = quantity;
        }

        /*
        public void delete(Tool aTool, ToolCollection toolType)
        {
            deleteTool = aTool;
            deleteTool.Quantity = quantity;
        }
        */

        public void delete(Member aMember)
        {
            //members.delete(aMember);
        }

        public void displayBorrowingTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            aMember.deleteTool(aTool);
            aTool.deleteBorrower(aMember);
        }
    }
}
