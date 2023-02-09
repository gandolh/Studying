package fx.study.sudoku.computationlogic;

import fx.study.sudoku.SudokuGame;
import fx.study.sudoku.constants.GameState;
import fx.study.sudoku.constants.Rows;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

import static fx.study.sudoku.SudokuGame.GRID_BOUNDARY;

public class GameLogic {
    public static SudokuGame getNewGame() {
        return new SudokuGame(
                GameState.NEW,
                GameGenerator.getNewGameGrid()
        );
    }

    public static GameState checkForCompletion(int[][] grid) {
        if (sudokuIsInvalid(grid)) return GameState.ACTIVE;
        if (tilesAreNotFilled(grid)) return GameState.ACTIVE;
        return GameState.COMPLETE;
    }

    public static boolean sudokuIsInvalid(int[][] grid) {
        if(rowsAreInvalid(grid)) return true;
        if(columnsAreInvalid(grid))return true;
        if(squareAreInvalid(grid))return true;
        return false;

    }

    private static boolean columnsAreInvalid(int[][] grid) {
        for(int x = 0 ;x < GRID_BOUNDARY;x++){
            List<Integer> row = new ArrayList<>();
            for(int y = 0 ; y<GRID_BOUNDARY;y++){
                row.add(grid[x][y]);
            }
            if(collectionHasRepeats(row)) return true;
        }
        return false;
    }

    private static boolean rowsAreInvalid(int[][] grid) {
        for(int x = 0 ;x < GRID_BOUNDARY;x++){
            List<Integer> row = new ArrayList<>();
            for(int y = 0 ; y<GRID_BOUNDARY;y++){
                row.add(grid[y][x]);
            }
            if(collectionHasRepeats(row)) return true;
        }
        return false;
    }

    private static boolean squareAreInvalid(int[][] grid) {
        if(rowOfSquaresIsInvalid(Rows.TOP, grid))return true;
        if(rowOfSquaresIsInvalid(Rows.MIDDLE, grid))return true;
        if(rowOfSquaresIsInvalid(Rows.BOTTOM, grid))return true;
        return false;
    }

    private static boolean rowOfSquaresIsInvalid(Rows value, int[][] grid) {
        switch(value){
            case TOP:
                if(squareIsInvalid(0,0,grid))return true;
                if(squareIsInvalid(0,3,grid))return true;
                if(squareIsInvalid(0,6,grid))return true;
                return false;
            case MIDDLE:
                if(squareIsInvalid(3,0,grid))return true;
                if(squareIsInvalid(3,3,grid))return true;
                if(squareIsInvalid(3,6,grid))return true;
                return false;
            case BOTTOM:
                if(squareIsInvalid(6,0,grid))return true;
                if(squareIsInvalid(6,3,grid))return true;
                if(squareIsInvalid(6,6,grid))return true;
                return false;
            default:
                return false;

        }
    }

    private static boolean squareIsInvalid(int xIndex, int yIndex, int[][] grid) {
            int yIndexEnd  = yIndex +3;
            int xIndexEnd = xIndex +3;
            List<Integer> square = new ArrayList<>();
            while(yIndex <  yIndexEnd) {
                while (xIndex < xIndexEnd) {
                    square.add(grid[xIndex][yIndex]);
                    xIndex++;
                }
                xIndex -= 3;
                yIndex++;
            }
        if(collectionHasRepeats(square))return true;
        else return false;

    }

    public static boolean collectionHasRepeats(List<Integer> square) {
        for(int index = 1; index <=GRID_BOUNDARY;index++){
            if(Collections.frequency(square, index) > 1) return true;
        }
        return false;
    }

    public static boolean tilesAreNotFilled(int[][] grid) {
        for (int x = 0; x < GRID_BOUNDARY; x++) {
            for (int y = 0; y < GRID_BOUNDARY; y++) {
                if(grid[x][y] == 0 )return true;
            }
        }
        return false;
    }


}
