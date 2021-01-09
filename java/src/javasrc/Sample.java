/**
 *
 */
package javasrc;

import java.util.Scanner;

/**
 * @author HagiAyato
 *
 */
public class Sample {

	/**
	 *
	 */
	public Sample() {
		// TODO 自動生成されたコンストラクター・スタブ
	}

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO 自動生成されたメソッド・スタブ
		if (args.length <= 0) {
			System.out.println("出力メッセージなし");
		} else {
			System.out.println("出力メッセージ：" + args[0]);
		}
		// Enterキー入力待ち
		// 参考：https://stackoverflow.com/questions/26184409/java-console-prompt-for-enter-input-before-moving-on
		System.out.println("Press \"ENTER\" to exit...");
		Scanner scanner = new Scanner(System.in);
		scanner.nextLine();
	}
}
